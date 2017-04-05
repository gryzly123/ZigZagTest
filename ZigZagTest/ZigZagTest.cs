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
            if (!Test.Tick()) FinishTest();
        }

        private void FinishTest()
        {
            throw new NotImplementedException();
        }

        private void SetNewInstructions(State NewState, float TargetCOG, float TargetRudder)
        {
            string Message = "";

            switch(NewState)
            {
                case State.TurningLeft:
                    Message = "Nastaw ster na " + TargetRudder.ToString() + " w lewo!";
                    break;

                case State.TurningRight:
                    Message = "Nastaw ster na " + TargetRudder.ToString() + " w prawo!";
                    break;

                case State.TurningLeft:
                    Message = "Nastaw ster na " + TargetRudder.ToString() + "!";
                    break;

                case State.TurningLeft:
                    Message = "Nastaw ster na " + TargetRudder.ToString() + "!";
                    break;
            }
        }
    }
}
