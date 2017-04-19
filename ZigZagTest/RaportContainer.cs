using System;
using System.Collections.Generic;

namespace ZigZagTest
{
    public class RaportContainer
    {
        private float RudderAngle, TurnAngle;
        private TimeSpan[] Times;
        private int TryCount;
        private ZigZagNomotoResult Result;
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
            Result = CalculateNomoto();
            DataSnapshots = AppGlobals.CurrentGPSManager.GetSnapshotsUpToThisPoint();
        }

        private ZigZagNomotoResult CalculateNomoto()
        {
            throw new NotImplementedException();
        }

        public string GenerateRaport()
        {
            string Raport = "Raport próby wężowej\n\n\n";
            Raport += "Próba została przeprowadzona " + StartTime.ToString()
                    + ". Wykonano " + TryCount.ToString() + "manewrów, dla których"
                    + " nastawa steru wynosiła " + RudderAngle.ToString() + " stopni, a statek "
                    + "wychylał się o kąt " + TurnAngle.ToString() + " stopni (względnem dna)."
                    + "\n\n Czasy odbić:\n\nOdbicie\tDorównanie\n\n";

            for(int i = 0; i < TryCount / 2; i++)
            {
                Raport += Times[2 * i].ToString() + "\t" + Times[2 * i + 1].ToString() + "\n";
            }

            Raport += "\n\nZ otrzymanych wyników wyliczyć można następujące parametry dla symulacji "
                   + " (model Nomoto): " + Result.GetResult();

            Raport += "Zmiany pozycji GPS:\n\n";


            DateTime FirstRecord = AppGlobals.CurrentGPSManager.GetFirstRecord();
            int j = 0;

            foreach (GPSData Data in DataSnapshots)
            {
                Raport += Data.GetLogString(FirstRecord, j);
                j++;
            }

            Raport += "\n\nOtrzymane komunikaty NMEA0183:\n\n";

            foreach (string Line in DataReceiver.GetLineHistory(-1)) Raport += Line + "\n";

            return Raport;
        }
    }
}
