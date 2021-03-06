﻿using System;

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
        private int AngleRudder, AngleTurn, Count;              //zmienne konfiguracyjne próby
        private TimeSpan[] Times;                               //zmienne wynikowe próby
        private float SOG, COG;                                 //chwilowe wartości prędkości i kąta ze źródła danych
        private float TargetSOG, TargetCOG;                     //docelowe wartości prędkości i kąta
        private float RelativeCourseAngle;                      //zależny kąt od początku próby na podstawie którego podejmowana jest decyzja o odbiciu
        private int CurrentTry;                                 //numer obecnego zawrotu
        private State CurrentState;                             //obecny stan w maszynie stanu próby
        private bool Started, Finished;                         //zmienne pomocnicze stanu próby
        private DateTime StartedTime;                           //czas w UTC od rozpoczęcia próby
        public StateChanged OnStateChanged;                     //delegata wysyłająca zmianę stanu próby dla okna instrukcji

        public ZigZag(int AngleRudder, int AngleTurn, int Count)
        {
            this.AngleRudder = AngleRudder;
            this.AngleTurn = AngleTurn;
            this.Count = Count;
            Times = new TimeSpan[2 * Count];

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
            float CourseChange = COG - this.COG;
            if (CourseChange > 350) CourseChange -= 360;
            if (CourseChange < -350) CourseChange += 350;
            RelativeCourseAngle += CourseChange;
            this.COG = COG;
        }

        private void VelocityUpdated(float SOG)
        {
            this.SOG = SOG;
        }

        //interfejs
        public bool NotStarted() { return !Started; }
        public bool NotFinished() { return !Finished; }
        public float GetRelativeCOG() { return RelativeCourseAngle; }

        //kontrola symulacji
        public void Begin()
        {
            if(!Started)
            {
                Started = true;
                TargetSOG = SOG;
                TargetCOG = COG;
                RelativeCourseAngle = 0;
                NextEvent();
            }
        }

        public bool Tick()
        {
            if(Finished) return false;

            switch(CurrentState)
            {
                case State.TurningLeft:
                    if (RelativeCourseAngle < -AngleTurn) NextEvent();
                    break;

                case State.TurningRight:
                    if (RelativeCourseAngle > AngleTurn) NextEvent();
                    break;

                case State.RevertingLeft:
                    if (RelativeCourseAngle > -AngleTurn) NextEvent();
                    break;

                case State.RevertingRight:
                    if (RelativeCourseAngle < AngleTurn) NextEvent();
                    break;
            }

            return true;
        }

        private void NextEvent()
        {
            switch(CurrentState)
            {
                case State.Preparation:
                    CurrentState = State.TurningLeft;
                    StartedTime = DateTime.UtcNow;

                    break;

                case State.TurningLeft:
                    CurrentState = State.RevertingLeft;
                    Times[2 * CurrentTry + 0] = DateTime.UtcNow - StartedTime;

                    break;

                case State.RevertingLeft:
                    CurrentState = State.TurningRight;
                    Times[2 * CurrentTry + 1] = DateTime.UtcNow - StartedTime;
                    NextTry(State.TurningRight);

                    break;

                case State.TurningRight:
                    CurrentState = State.RevertingRight;
                    Times[2 * CurrentTry + 1] = DateTime.UtcNow - StartedTime;

                    break;

                case State.RevertingRight:
                    Times[2 * CurrentTry + 0] = DateTime.UtcNow - StartedTime;
                    NextTry(State.TurningLeft);
                    break;
            }

            OnStateChanged.Invoke(CurrentState, CurrentTry, AngleTurn, AngleRudder);
        }

        private void NextTry(State NewState)
        {
            CurrentTry++;

            if (CurrentTry < Count) CurrentState = NewState;
            else
            {
                CurrentState = State.Finished;
                Finished = true;
                Finish();
            }
        }

        private void Finish()
        {
            AppGlobals.CurrentRaport = new RaportContainer(this);
        }

        //metody do pobierania danych przez kontener raportu
        public TimeSpan[] RC_GetTimes() { return Times; }
        public DateTime RC_GetStart() { return StartedTime; }
        public int RC_GetTryCount() { return Count; }
        public int RC_GetRudder() { return AngleRudder; }
        public int RC_GetTurn() { return AngleTurn; }
    }
}
