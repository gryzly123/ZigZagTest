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
        private DateTime StartTime;
        private float COG, CurrentCOG = -1.0f, SOG, CurrentSOG = -2.0f;

        public ZigZagTest(ZigZag CurrentTest)
        {
            InitializeComponent();
            Test = CurrentTest;
            Test.OnStateChanged = new StateChanged(SetNewInstructions);

            NMEAParser.OnRotationUpdated += new UpdateCOG(this.RotationUpdated);
            NMEAParser.OnVelocityUpdated += new UpdateSOG(this.VelocityUpdated);
        }

        ~ZigZagTest()
        {
            foreach(Delegate D in NMEAParser.OnRotationUpdated.GetInvocationList())
            {
                if (D.Target == this) NMEAParser.OnRotationUpdated -= (UpdateCOG)D;
            }

            foreach (Delegate D in NMEAParser.OnVelocityUpdated.GetInvocationList())
            {
                if (D.Target == this) NMEAParser.OnVelocityUpdated -= (UpdateSOG)D;
            }

            MessageBox.Show("ŻigZagTest()");
        }

        //delegaty
        private void RotationUpdated(float COG)
        {
            if (Test.NotStarted()) this.COG = COG;
            else CurrentCOG = COG - this.COG;

            UpdateLabels();
        }
        private void VelocityUpdated(float SOG)
        {
            if (Test.NotStarted()) this.SOG = SOG;
            else CurrentSOG = SOG - this.SOG;

            UpdateLabels();
        }

        private void UpdateLabels()
        {
            Label_COG.Invoke            (new Action(() => { if (COG >= 0) Label_COG.Text = COG.ToString("0.0") + " deg";                                                          }));
            Label_RelativeCourse.Invoke (new Action(() => { Label_RelativeCourse.Text = (CurrentCOG >= 0) ? CurrentCOG.ToString("0.0") + " deg" : "-";                            }));
            Label_SOG.Invoke            (new Action(() => { Label_SOG.Text = SOG.ToString("0.0") + " kn " + ((CurrentSOG >= 0) ? "(" + CurrentSOG.ToString("0.0") + " kn)" : ""); }));
        }

        private void Button_Begin_Click(object sender, EventArgs e)
        {
            if (Test.NotStarted())
            {
                Test.Begin();
                StartTime = DateTime.UtcNow;
            }
        }

        private void ZigZag_Timer_Tick(object sender, EventArgs e)
        {
            if (!Test.Tick()) FinishTest();
            else if(!Test.NotStarted())
            {
                Label_Time.Text = (DateTime.UtcNow - StartTime).ToString(@"h\:mm\:ss\.f");
            }
        }

        private void FinishTest()
        {
            throw new NotImplementedException();
        }

        private void SetNewInstructions(State NewState, int CurrentTry, float TargetCOG, float TargetRudder)
        {
            string Message = "";

            if (CurrentTry == 0 && NewState == State.TurningLeft) Message = "Nastaw ster na " + TargetRudder.ToString() + " stopni w lewo!";
            else switch(NewState)
            {
                case State.TurningLeft:
                    Message = "Czekaj";
                    break;

                case State.TurningRight:
                    Message = "Czekaj";
                    break;

                case State.RevertingLeft:
                    Message = "Odbij ster na " + TargetRudder.ToString() + " stopni w prawo!";
                    break;

                case State.RevertingRight:
                    Message = "Odbij ster na " + TargetRudder.ToString() + " stopni w lewo!";
                    break;
            }

            Label_Instruction.Invoke(new Action(() => { Label_Instruction.Text = Message; }));
        }
    }
}
