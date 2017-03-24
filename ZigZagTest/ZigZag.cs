using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigZagTest
{
    public class ZigZagResult
    {
        private float T, K, DC;

        public float GetT() { return T; }
        public float GetK() { return K; }
        public float GetDC() { return DC; }

        public ZigZagResult(float T, float K, float DC)
        {
            this.T = T;
            this.K = K;
            this.DC = DC;
        }
    }

    public enum State
    {
        Preparation,    //ustawienie statku na stałą prędkość u0 przed testem
        TurningLeft,    //od momentu wychylenia steru w lewo, kiedy statek skręca w lewo
        RevertingLeft,  //od momentu wychylenia steru w prawo, kiedy statek dalej skręca w lewo
        TurningRight,   //od momentu wychylenia steru w prawo, kiedy statek skręca w prawo
        RevertingRight, //od momentu wychylenia steru w lewo, kiedy statek dalej skręca w prawo
        Finished        //koniec próby wężowej
    }

    public class ZigZag
    {
        private int Angle, Count;
        private TimeSpan[] Times;
        private ZigZagResult Result;
        private State CurrentState;
        private float SOG, COG/*, ROT*/;
        //private DateTime SinceLastCOGUpdate, SinceLastSOGUpdate;

        public ZigZag(int Angle, int Count)
        {
            this.Angle = Angle;
            this.Count = Count;
            Times = new TimeSpan[4 * Count];

            NMEAParser.OnRotationUpdated += new UpdateCOG(this.RotationUpdated);
            NMEAParser.OnVelocityUpdated += new UpdateSOG(this.VelocityUpdated);
        }

        private void RotationUpdated(float COG)
        {
            this.COG = COG;
            //if (SinceLastCOGUpdate == null) SinceLastCOGUpdate = DateTime.UtcNow;
            //
            //ROT = COG - this.COG;
            //if (ROT > 180) ROT -= 360;
            //if (ROT < -180) ROT += 360;
            //
            //float SinceLastUpdate = (float)(DateTime.UtcNow - SinceLastCOGUpdate).TotalSeconds;
            //ROT /= SinceLastUpdate;
        }

        private void VelocityUpdated(float SOG)
        {

        }

        private void Tick()
        {

        }

    }
}
