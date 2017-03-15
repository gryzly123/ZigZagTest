using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZigZagTest
{
    public delegate void StructureUpdated();

    public class GPSData
    {
        const float EMPTY = -10000.0f;
        public StructureUpdated OnStructureUpdate;

        public float Longitude;
        public float Latitude;
        public float COG;
        public float SOG;

        public GPSData()
        {
            Longitude = EMPTY;
            Latitude = EMPTY;
            COG = EMPTY;
            SOG = EMPTY;
        }

        public void UpdateLocation(float Lat, float Lon)
        {
            Latitude = Lat;
            Longitude = Lon;
        }

        public void UpdateSpeed(float SOG)
        {
            this.SOG = SOG;
        }

        public void UpdateCourse(float COG)
        {
            this.COG = COG;
        }

        public GPSData Clone()
        {
            GPSData NewInstance = new GPSData();
            NewInstance.Longitude = Longitude;
            NewInstance.Latitude = Latitude;
            NewInstance.COG = COG;
            NewInstance.SOG = SOG;
            return NewInstance;
        }
    }

    public class GPSManager
    {
        GPSData CurrentState;
        List<GPSData> DataSnapshots;
        DateTime FirstRecord;
        Timer Tick;

        public GPSManager(StructureUpdated UpdateHUD)
        {
            CurrentState = new GPSData();
            DataSnapshots = new List<GPSData>();
            FirstRecord = DateTime.UtcNow;
            NMEAParser.OnLocationUpdated = new UpdateLocation(CurrentState.UpdateLocation);
            NMEAParser.OnRotationUpdated = new UpdateCOG(CurrentState.UpdateSpeed);
            NMEAParser.OnVelocityUpdated = new UpdateSOG(CurrentState.UpdateCourse);
            CurrentState.OnStructureUpdate = UpdateHUD;

            Tick = new Timer();
            Tick.Interval = 1000;
            Tick.Tick += OnTick;
            Tick.Start();
        }

        private void OnTick(object sender, EventArgs e)
        {
            DataSnapshots.Add(CurrentState.Clone());
        }


    }
}
