using System;
using System.Linq;

namespace ZigZagTest
{
    public delegate void UpdateLocation(float Lat, float Lon);
    public delegate void UpdateCOG(float COG);
    public delegate void UpdateSOG(float SOG);
    public delegate void UpdateHDT(float HDT);
    public delegate void UpdateSat(int SatCount);

    public static class NMEAParser
    {
        private static bool Debug_UseFracDegrees = false;

        public static UpdateLocation OnLocationUpdated;
        public static UpdateCOG OnCourseUpdated;
        public static UpdateSOG OnSpeedUpdated;
        public static UpdateHDT OnHeadingUpdated;
        public static UpdateSat OnSatelliteUpdated;
        static int SatelliteCount = 0;
        public static int GetSatelliteCount() { return SatelliteCount; }

        public static void ParseLine(string Line)
        {
            if(Checksum(Line))
            {
                string[] SplitLine = Line.Split(',');
                SplitLine[0] = SplitLine[0].Remove(0, 3); //ignorujemy źródło GP/GL/GN (GPS, GLONASS, GPS+GLONASS)
                switch(SplitLine[0])
                {
                    case "GGA": GGA(SplitLine); break;
                    case "RMC": RMC(SplitLine); break;
                    case "GLL": GLL(SplitLine); break;
                    case "GSV": GSV(SplitLine); break;
                    case "HDT": HDT(SplitLine); break;
                    case "VTG": VTG(SplitLine); break;
                }
            }
        }

        private static bool Checksum(string Line)
        {
            int Size = Line.Count();
            try
            {
                string Message = Line.Substring(1, Size - 4);
                string SumString = Line.Substring(Size - 2, 2);
                int TargetSum = Convert.ToInt32(SumString, 16);
                byte Sum = 0;
                int MessageSize = Message.Length;
                for (int k = 0; k < MessageSize; k++) Sum ^= Convert.ToByte(Message[k]);
                if (Sum == TargetSum) return true;
            }
            catch { }

            return false;
        }

        private static void GGA(string[] SplitLine)
        {
            try
            {
                float Latitude = Convert.ToSingle(SplitLine[2]);
                float Longitude = Convert.ToSingle(SplitLine[4]);

                Latitude = FixMinutes(Latitude);
                Longitude = FixMinutes(Longitude);

                if (SplitLine[3] == "S") Latitude *= -1;
                if (SplitLine[5] == "W") Longitude *= -1;
                OnLocationUpdated.Invoke(Latitude, Longitude);
            } catch { }

            try
            {
                int SatCount = Convert.ToInt32(SplitLine[7]);
                OnSatelliteUpdated.Invoke(SatCount);
            } catch { }
        }

        private static void RMC(string[] SplitLine)
        {
            try
            {
                float Latitude = Convert.ToSingle(SplitLine[3]);
                float Longitude = Convert.ToSingle(SplitLine[5]);
                if (SplitLine[4] == "S") Latitude *= -1;
                if (SplitLine[6] == "W") Longitude *= -1;
                float SOG = Convert.ToSingle(Convert.ToDouble(SplitLine[7]));
                float COG = Convert.ToSingle(Convert.ToDouble(SplitLine[8]));
                OnLocationUpdated.Invoke(Latitude, Longitude);
                OnSpeedUpdated.Invoke(SOG);
                OnCourseUpdated.Invoke(COG);
            } catch { }
        }

        private static void GLL(string[] SplitLine)
        {
            try
            {
                float Latitude = Convert.ToSingle(SplitLine[1]);
                float Longitude = Convert.ToSingle(SplitLine[3]);
                if (SplitLine[2] == "S") Latitude *= -1;
                if (SplitLine[4] == "W") Longitude *= -1;
                OnLocationUpdated.Invoke(Latitude, Longitude);
            }
            catch { }
        }

        private static void GSV(string[] SplitLine)
        {
            try
            {
                int SatCount = Convert.ToInt32(SplitLine[3]);
                OnSatelliteUpdated.Invoke(SatCount);
            }
            catch { }
        }

        private static void HDT(string[] SplitLine)
        {
            try
            {
                float Heading = Convert.ToSingle(SplitLine[1]);
                OnHeadingUpdated.Invoke(Heading);
            }
            catch { }
        }

        private static void VTG(string[] SplitLine)
        {
            try
            {
                float SOG = Convert.ToSingle(SplitLine[5]);
                OnSpeedUpdated.Invoke(SOG);
            }
            catch { }
        }

        private static float FixMinutes(float In)
        {
            if (Debug_UseFracDegrees) return In;

            int  Whole = Convert.ToInt32(In);
            float Frac = In - Convert.ToSingle(Whole);

            int Degree = Whole / 100;
            int Minute = Whole % 100;

            float TotalMinute = Convert.ToSingle(Minute) + Frac;
            float TotalPos = Convert.ToSingle(Whole) + (TotalMinute / 60);

            return TotalPos;
        }
    }
}
