using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigZagTest
{
    public class Angle
    {
        private float AngleDeg;

        public Angle(float Angle, bool isRad = false)
        {
            if (isRad) Angle = Angle * 180.0f / (float)Math.PI;
            AngleDeg = Angle;
        }

        public float Deg() { return AngleDeg; }
        public float Rad() { return AngleDeg / 180.0f * (float)Math.PI; }

        public void Add(float Angle, bool isRad = false)
        {
            if (isRad) Angle = Angle * 180.0f / (float)Math.PI;
            AngleDeg += Angle;

            while(AngleDeg>360) AngleDeg -= 360;
            if   (AngleDeg < 0) AngleDeg += 360;
        }

        //zwraca kąt, o jaki trzeba obrócić A1, żeby był tożsamy z A2
        public static float Rotation(Angle A1, Angle A2, bool isRad = false)
        {
            float Diff = A2.AngleDeg - A1.AngleDeg;
            if (isRad) Diff = Diff * 180.0f / (float)Math.PI;
            return Diff;
        }
    }
}
