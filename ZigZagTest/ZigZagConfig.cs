using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZigZagTest
{
    public partial class ZigZagConfig : Form
    {
        private int Angle, Angle2, Count;

        public ZigZagConfig()
        {
            InitializeComponent();
            UpdateTrackbars();
        }


        private void Trackbar_Scroll(object sender, EventArgs e)
        {
            UpdateTrackbars();
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            AppGlobals.CurrentZigZag = new ZigZag(Angle, Angle2, Count);
            ZigZagTest Test = new ZigZagTest(AppGlobals.CurrentZigZag);
            Test.Show();
            Close();
        }

        private void UpdateTrackbars()
        {
            Angle = Trackbar_Angle.Value * 5;
            Angle2 = Trackbar_Angle2.Value * 5;
            Count = Trackbar_Count.Value;

            Label_Angle.Text = Angle.ToString() + " deg";
            Label_Angle2.Text = Angle2.ToString() + " deg";
            Label_Count.Text = Count.ToString();
        }
    }
}
