﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigZagTest
{
    public delegate void UpdateLocation(float Lat, float Lon);
    public delegate void UpdateCOG(float COG);
    public delegate void UpdateSOG(float SOG);

    public static class NMEAParser
    {
        public static UpdateLocation OnLocationUpdated;
        public static UpdateCOG OnRotationUpdated;
        public static UpdateSOG OnVelocityUpdated;
        static int SatelliteCount = 0;
        public static int GetSatelliteCount() { return SatelliteCount; }

        public static void ParseLine(string Line)
        {
            if(Checksum(Line))
            {
                string[] SplitLine = Line.Split(',');
                switch(SplitLine[0])
                {
                    case "$GPGGA": GGA(SplitLine); break;
                    case "$GPRMC": RMC(SplitLine); break;
                    case "$GPVTG": VTG(SplitLine); break;
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
                for (int k = 0; k < MessageSize; k++)
                {
                    byte Char = Convert.ToByte(Message[k]);
                    Sum ^= Char;
                }
                if (Sum.Equals(TargetSum)) return true;
            }
            catch { }

            return false;
        }
        private static void GGA(string[] SplitLine)
        {
            float Latitude = Convert.ToSingle(SplitLine[2].Replace('.', ','));
            float Longitude = Convert.ToSingle(SplitLine[4].Replace('.', ','));
            if (SplitLine[3] == "S") Latitude *= -1;
            if (SplitLine[5] == "W") Longitude *= -1;
            SatelliteCount = Convert.ToInt32(SplitLine[7]);
            OnLocationUpdated.Invoke(Latitude, Longitude);
        }


        private static void RMC(string[] SplitLine)
        {
            float Latitude = Convert.ToSingle(SplitLine[2].Replace('.', ','));
            float Longitude = Convert.ToSingle(SplitLine[4].Replace('.', ','));
            if (SplitLine[3] == "S") Latitude *= -1;
            if (SplitLine[5] == "W") Longitude *= -1;
            SatelliteCount = Convert.ToInt32(SplitLine[7]);
            OnLocationUpdated.Invoke(Latitude, Longitude);
        }

        private static void VTG(string[] SplitLine)
        {
            throw new NotImplementedException();
        }
    }
}
