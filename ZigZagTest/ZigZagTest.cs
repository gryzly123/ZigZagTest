using System;
using System.Windows.Forms;

namespace ZigZagTest
{
    public delegate void DebugPrint(string Message);

    public partial class ZigZagTest : Form
    {
        private ZigZag Test;
        private DateTime StartTime;
        private float COG, CurrentCOG = -1.0f, SOG, CurrentSOG = -2.0f;
        public static DebugPrint PrintToTestWindow;
        private bool TestFinished = false;

        public ZigZagTest(ZigZag CurrentTest)
        {
            InitializeComponent();
            Test = CurrentTest;
            Test.OnStateChanged = new StateChanged(SetNewInstructions);

            NMEAParser.OnCourseUpdated += new UpdateCOG(this.RotationUpdated);
            NMEAParser.OnSpeedUpdated += new UpdateSOG(this.VelocityUpdated);

            PrintToTestWindow += new DebugPrint(DebugPrintToLabel);
        }

        void DebugPrintToLabel(string Message)
        {
            Label_Log.Invoke(new Action(() => { Label_Log.Text = Message; }));
        }

        ~ZigZagTest()
        {
            foreach(Delegate D in NMEAParser.OnCourseUpdated.GetInvocationList())
            {
                if (D.Target == this) NMEAParser.OnCourseUpdated -= (UpdateCOG)D;
            }

            foreach (Delegate D in NMEAParser.OnSpeedUpdated.GetInvocationList())
            {
                if (D.Target == this) NMEAParser.OnSpeedUpdated -= (UpdateSOG)D;
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
            Label_COG.Invoke            (new Action(() => { if (Test.NotStarted()) Label_COG.Text = COG.ToString("0.0") + " deg";                                                    }));
            Label_RelativeCourse.Invoke (new Action(() => { Label_RelativeCourse.Text = (!Test.NotStarted()) ? Test.GetRelativeCOG().ToString("0.0") + " deg" : "-";                 }));
            Label_SOG.Invoke            (new Action(() => { Label_SOG.Text = SOG.ToString("0.0") + " kn " + ((!Test.NotStarted()) ? "(" + CurrentSOG.ToString("0.0") + " kn)" : ""); }));
        }

        private void Button_Begin_Click(object sender, EventArgs e)
        {
            if (Test.NotStarted())
            {
                Test.Begin();
                StartTime = DateTime.UtcNow;
            }
            else if(!Test.NotFinished())
            {
                AppGlobals.AppReference.ReactToFinishedTest();
                this.Close();
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
            Button_Begin.Enabled = true;
            Button_Begin.Text = "Zakończ";
            TestFinished = true;
            
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

                case State.Finished:
                    Message = "Test zakończono.";
                    FinishTest();
                    break;
                }

            Label_Instruction.Invoke(new Action(() => { Label_Instruction.Text = Message; }));
        }
    }
}
