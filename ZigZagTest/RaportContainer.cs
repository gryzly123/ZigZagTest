using System;
using System.Collections.Generic;

namespace ZigZagTest
{
    public class RaportContainer
    {
        private float RudderAngle, TurnAngle;
        private TimeSpan[] Times;
        private int TryCount;
        private DateTime StartTime;
        private List<GPSData> DataSnapshots;

        public TimeSpan[] GetTimes() { return Times; }

        public RaportContainer(ZigZag Data)
        {
            Times = Data.RC_GetTimes();
            RudderAngle = Data.RC_GetRudder();
            TurnAngle = Data.RC_GetTurn();
            TryCount = Data.RC_GetTryCount();
            StartTime = Data.RC_GetStart();
            DataSnapshots = AppGlobals.CurrentGPSManager.GetSnapshotsUpToThisPoint();
        }

        public string GenerateRaport()
        {
            string Raport = "RAPORT PRÓBY WĘŻOWEJ\r\n\r\n\r\n";
            Raport += "Próba została przeprowadzona " + StartTime.ToString()
                    + ". Wykonano " + TryCount.ToString() + " manewrów,\r\ndla których docelowa"
                    + " nastawa steru wynosiła " + RudderAngle.ToString() + " stopni, a statek przed dokonaniem\r\nmanewru odbicia "
                    + "miał wychylić się o kąt " + TurnAngle.ToString() + " stopni (względnem dna)."
                    + "\r\n\r\nCzasy odbić:\r\n\r\nOdbicie\t\tDorównanie\r\n\r\n";

            for(int i = 0; i < TryCount; i++)
            {
                Raport += Times[2 * i].ToString(@"h\:mm\:ss\.f") + "\t" + Times[2 * i + 1].ToString(@"h\:mm\:ss\.f") + "\r\n";
            }

            Raport += "\r\n\r\nZmiany pozycji GPS:\r\n\r\n";

            DateTime FirstRecord = AppGlobals.CurrentGPSManager.GetFirstRecord();
            int j = 0;
            
            foreach (GPSData Data in DataSnapshots)
            {
                Raport += Data.GetLogString(FirstRecord, j) + "\r\n";
                j++;
            }

            Raport += "\r\n\r\nOtrzymane komunikaty NMEA0183:\r\n\r\n";

            foreach (string Line in DataReceiver.GetLineHistory(-1)) Raport += Line + "\r\n";

            return Raport;
        }
    }
}
