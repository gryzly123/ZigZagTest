using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZigZagTest
{
    public delegate void StateChanged(State NewState, int CurrentTry, float TargetCOG, float TargetRudder);

    public enum RangeSubset
    {
        Inside,
        Outside,
        Before,
        After,
        NotEqual
    };

    public class ZigZagNomotoResult
    {
        private float T, K, DC;

        public float GetT() { return T; }
        public float GetK() { return K; }
        public float GetDC() { return DC; }

        public ZigZagNomotoResult(float T, float K, float DC)
        {
            this.T = T;
            this.K = K;
            this.DC = DC;
        }
    }

    public enum State
    {
        Preparation,    // ustawienie statku na stałą prędkość u0 przed testem
        TurningLeft,    // od momentu wychylenia steru w lewo, kiedy statek skręca w lewo
        RevertingLeft,  // od momentu wychylenia steru w prawo, kiedy statek dalej skręca w lewo
        TurningRight,   // od momentu wychylenia steru w prawo, kiedy statek skręca w prawo
        RevertingRight, // od momentu wychylenia steru w lewo, kiedy statek dalej skręca w prawo
        Finished,       // koniec próby wężowej
        Failed          // próba nie powiodła się ze wzglęgu na zbyt duży odchył prędkości od początkowej
    }

    public class ZigZag
    {
        private int AngleRudder, AngleTurn, Count;
        private TimeSpan[] Times;
        private State CurrentState;
        private float SOG, COG;
        private float TargetSOG, TargetCOG;
        private bool Started;
        private DateTime StartedTime;
        private bool Finished;
        private int CurrentTry;
        public StateChanged OnStateChanged;

        public ZigZag(int AngleRudder, int AngleTurn, int Count)
        {
            this.AngleRudder = AngleRudder;
            this.AngleTurn = AngleTurn;
            this.Count = Count;
            Times = new TimeSpan[4 * Count];

            Started = false;
            Finished = false;
            CurrentTry = 0;
            CurrentState = State.Preparation;

            NMEAParser.OnCourseUpdated += new UpdateCOG(this.RotationUpdated);
            NMEAParser.OnSpeedUpdated += new UpdateSOG(this.VelocityUpdated);
        }

        //delegaty
        private void RotationUpdated(float COG)
        {
            this.COG = COG;
        }
        private void VelocityUpdated(float SOG)
        {
            this.SOG = SOG;
        }

        //interfejs
        public bool NotStarted() { return !Started; }
        public bool NotFinished() { return !Finished; }

        //kontrola symulacji
        public void Begin()
        {
            if(!Started)
            {
                Started = true;
                TargetSOG = SOG;
                TargetCOG = COG;
                NextEvent();
            }
        }

        public bool Tick()
        {
            if(Finished) return false;

            switch(CurrentState)
            {
                case State.TurningLeft:
                    if (AngleInRange(COG, TargetCOG, AngleRudder, RangeSubset.After)) NextEvent();
                    break;

                case State.TurningRight:
                    if (!AngleInRange(COG, TargetCOG, -AngleRudder, RangeSubset.After)) NextEvent();
                    break;

                case State.RevertingLeft:
                    if (AngleInRange(COG, TargetCOG, AngleRudder, RangeSubset.Before)) NextEvent();
                    break;


                case State.RevertingRight:
                    if (AngleInRange(COG, TargetCOG, -AngleRudder, RangeSubset.Before)) NextEvent();
                    break;
            }

            return true;
        }

        private bool AngleInRange(float Angle, float TargetAngle, float Range, RangeSubset Subset)
        {
            float Difference = TargetAngle - Angle;
            if (Difference > 180) Difference -= 180;

            bool InAfter = Difference > Range;
            bool InBefore = Difference < 0;
            bool InOutside = InAfter || InBefore;
            bool InInside = !InOutside;

            switch(Subset)
            {
                case RangeSubset.Inside: return InInside;
                case RangeSubset.Outside: return InOutside;
                case RangeSubset.Before: return InBefore;
                case RangeSubset.After: return InAfter;
                case RangeSubset.NotEqual: return Difference != Range;
                default: return false;
            }
        }

        private void NextEvent()
        {
            MessageBox.Show("NextEvent()");

            switch(CurrentState)
            {
                case State.Preparation:
                    CurrentState = State.TurningLeft;
                    StartedTime = DateTime.UtcNow;

                    break;

                case State.TurningLeft:
                    CurrentState = State.RevertingLeft;
                    Times[CurrentTry + 0] = DateTime.UtcNow - StartedTime;

                    break;

                case State.RevertingLeft:
                    CurrentState = State.TurningRight;
                    Times[CurrentTry + 1] = DateTime.UtcNow - StartedTime;

                    break;

                case State.TurningRight:
                    CurrentState = State.RevertingRight;
                    Times[CurrentTry + 2] = DateTime.UtcNow - StartedTime;

                    break;

                case State.RevertingRight:
                    Times[CurrentTry + 3] = DateTime.UtcNow - StartedTime;

                    CurrentTry++;
                    if (CurrentTry < Count) CurrentState = State.TurningLeft;
                    else
                    {
                        CurrentState = State.Finished;
                        Finished = true;
                    }
                    break;
            }
                    OnStateChanged.Invoke(CurrentState, CurrentTry, AngleRudder, AngleTurn);
        }
    }
}
