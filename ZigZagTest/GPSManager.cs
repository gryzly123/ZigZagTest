using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigZagTest
{
    public struct GPSData
    {
        private float Longitude { get; }
        private float Latitude { get; }
        private float COG { get; }
        private float SOG { get; }
    }

    public class GPSManager
    {
        GPSData CurrentState;
        List<GPSData> DataSnapshots;
    }
}
