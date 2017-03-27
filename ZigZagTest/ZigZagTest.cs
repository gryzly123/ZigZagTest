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
    public partial class ZigZagTest : Form
    {
        private ZigZag Test;

        public ZigZagTest(ZigZag CurrentTest)
        {
            InitializeComponent();
            Test = CurrentTest;
            Test.OnStateChanged = new StateChanged(SetNewInstructions);
            
        }

        private void Button_Begin_Click(object sender, EventArgs e)
        {
            if(!Test.Running()) Test.Begin();
        }

        private void ZigZag_Timer_Tick(object sender, EventArgs e)
        {
            Test.Tick();
        }

        private void SetNewInstructions(State NewState)
        {

        }
    }
}
