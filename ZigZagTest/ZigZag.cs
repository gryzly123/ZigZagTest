using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZigZagTest
{
    public delegate void StateChanged(State NewState);

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
        private TimeSpan CurrentTime;
        private State CurrentState;
        private float SOG, COG;
        private float TargetSOG, TargetCOG;
        private bool Started;
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
            CurrentTime = new TimeSpan(0);
            CurrentTry = 0;

            NMEAParser.OnRotationUpdated += new UpdateCOG(this.RotationUpdated);
            NMEAParser.OnVelocityUpdated += new UpdateSOG(this.VelocityUpdated);
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
        public bool Running() { return Started && !Finished; }

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

        public void Tick()
        {
            if(Running())
            {
                CurrentTime += new TimeSpan(0, 0, 0, 0, 100);
            }

            switch(CurrentState)
            {
                case State.TurningLeft: 

            }
        }

        private void NextEvent()
        {
            switch(CurrentState)
            {
                case State.Preparation: CurrentState = State.TurningLeft; break;

                case State.TurningLeft: CurrentState = State.RevertingLeft; break;

                case State.RevertingLeft: CurrentState = State.TurningRight; break;

                case State.TurningRight: CurrentState = State.RevertingRight; break;

                case State.RevertingRight:

                    CurrentTry++;
                    if (CurrentTry < Count) CurrentState = State.TurningLeft;
                    else
                    {
                        CurrentState = State.Finished;
                        Finished = true;
                    }
                    break;
            }
                    OnStateChanged.Invoke(CurrentState);
        }
    }
}
