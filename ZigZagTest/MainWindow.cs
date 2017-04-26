using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace ZigZagTest
{
    public partial class MainWindow : Form
    {
        enum ConnectionType
        {
            None,
            UDP,
            Serial,
            ConnectedNow
        };
        ConnectionType SelectedConnectionType = ConnectionType.None;
        bool RunningConnection = false;
        bool CanUseSerialPort = true;

        public MainWindow()
        {
            InitializeComponent();
            AppGlobals.AppReference = this;

            //zawsze używaj kropek zamiast przecinków (ustawiane per wątek)
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            //konfiguracja portu szeregowego
            Serial_PortName.Items.Clear();
            foreach (string Item in SerialPort.GetPortNames()) Serial_PortName.Items.Add(Item);
            if (Serial_PortName.Items.Count != 0) Serial_PortName.SelectedIndex = 0;
            else CanUseSerialPort = false;
            Configuration_Serial.Enabled = false;
            Serial_ParityCheck.SelectedIndex = 0;
            Serial_StopBits.SelectedIndex = 0;
            Serial_Handshake.SelectedIndex = 0;

            //konfiguracja delegat HUDa
            NMEAParser.OnLocationUpdated = new UpdateLocation(HUD_UpdateLocation);
            NMEAParser.OnCourseUpdated = new UpdateCOG(HUD_UpdateCourse);
            NMEAParser.OnHeadingUpdated = new UpdateHDT(HUD_UpdateHeading);
            NMEAParser.OnSatelliteUpdated = new UpdateSat(HUD_UpdateSatCount);
            NMEAParser.OnSpeedUpdated = new UpdateSOG(HUD_UpdateSpeed);
        }

        private void HUD_UpdateLocation(float Lat, float Lon)
        {
            HUD_Lat.Invoke(new Action(() => HUD_Lat.Text = Lat.ToString("0.00000") + " " + (Lat >= 0 ? "N" : "S")));
            HUD_Lon.Invoke(new Action(() => HUD_Lon.Text = Lon.ToString("0.00000") + " " + (Lon >= 0 ? "E" : "W")));
        }

        private void HUD_UpdateCourse(float COG)
        {
            HUD_COG.Invoke(new Action(() => HUD_COG.Text = COG.ToString("0.0") + " deg"));
        }

        private void HUD_UpdateHeading(float HDT)
        {
            HUD_Heading.Invoke(new Action(() => HUD_Heading.Text = HDT.ToString("0.0") + " deg"));
        }

        private void HUD_UpdateSpeed(float SOG)
        {
            HUD_SOG.Invoke(new Action(() => HUD_SOG.Text = SOG.ToString("0.0") + " kn"));
        }

        private void HUD_UpdateSatCount(int SatCount)
        {
            HUD_SatCount.Invoke(new Action(() => HUD_SatCount.Text = SatCount.ToString()));
        }

        private void UDPIP_ValidateTextChange(object sender, EventArgs e)
        {
            TextBox CurrentBox = (TextBox)sender;
            string Text = CurrentBox.Text;
            string Text2 = new string(Text.Where(c => char.IsNumber(c)).ToArray());
            Int32 ActualNumber;
            Int32 MaxSize = 255;
            if (CurrentBox.Equals(UDP_Port)) MaxSize = 65535;


            try
            {
                ActualNumber = Convert.ToInt32(Text2);
                if (ActualNumber > MaxSize) ActualNumber = MaxSize;
                Text2 = ActualNumber.ToString();
            }
            catch
            {
                Text2 = "0";
            }

            CurrentBox.Text = Text2;
            CurrentBox.SelectionStart = CurrentBox.Text.Length;
        }

        private void ConnectionType_Changed(object sender, EventArgs e)
        {
            RadioButton Button = (RadioButton)sender;
            if (Button.Checked)
            {
                if (Button.Equals(Configuration_UDP)) SelectedConnectionType = ConnectionType.UDP;
                if (Button.Equals(Configuration_Serial)) SelectedConnectionType = ConnectionType.Serial;
            }

            ConfigurationScreen_UpdateGroups();
        }

        private void ConfigurationScreen_UpdateGroups()
        {
            switch(SelectedConnectionType)
            {
                case ConnectionType.UDP:
                    Group_ConfigureUDP.Enabled = true;
                    Group_ConfigureSerial.Enabled = false;
                    Button_Connect.Enabled = true;
                    break;

                case ConnectionType.Serial:
                    Group_ConfigureUDP.Enabled = false;
                    Group_ConfigureSerial.Enabled = true;
                    Button_Connect.Enabled = true;
                    break;

                case ConnectionType.None:
                    Group_ConfigureUDP.Enabled = false;
                    Group_ConfigureSerial.Enabled = false;
                    Button_Connect.Enabled = true;
                    break;

                case ConnectionType.ConnectedNow:
                    Group_ConfigureUDP.Enabled = false;
                    Group_ConfigureSerial.Enabled = false;
                    Button_Connect.Enabled = true;
                    break;
            }
        }

        private void Button_Connect_Click(object sender, EventArgs e)
        {
            switch (SelectedConnectionType)
            {
                case ConnectionType.UDP: CreateUDP(); break;
                case ConnectionType.Serial: CreateSerial(); break;
                case ConnectionType.ConnectedNow:

                    AppGlobals.CurrentDataReceiver.StopReading();
                    Button_Connect.Text = "Połącz";
                    SelectedConnectionType = (Configuration_UDP.Checked) ? ConnectionType.UDP : ConnectionType.Serial;
                    ConfigurationScreen_UpdateGroups();
                    return;
            }

            SelectedConnectionType = ConnectionType.ConnectedNow;
            Button_Connect.Text = "Rozłącz";
            ConfigurationScreen_UpdateGroups();

            AppGlobals.CurrentGPSManager = new GPSManager();
            AppGlobals.CurrentDataReceiver.AddDelegateOnDataReceived(new ReceiveLine(AddLine));
            AppGlobals.CurrentDataReceiver.StartReading();
        }

        private void AddLine(string Line)
        {
            List<string> LineHistory = DataReceiver.GetLineHistory(15);
            List_DataReadings.Invoke(new Action(() =>
                {
                    List_DataReadings.Items.Clear();
                    foreach (string NMEALine in LineHistory) List_DataReadings.Items.Insert(0, NMEALine);
                }
            ));
        }

        private void CreateSerial()
        {
            string PN = Serial_PortName.Text;
            int BPS = Convert.ToInt32(Serial_BPSRate.Text);
            Parity P = Parity.None;
            StopBits SB = StopBits.None;
            Handshake H = Handshake.None;

            switch (Serial_ParityCheck.SelectedIndex)
            {
                case 0: P = Parity.None; break;
                case 1: P = Parity.Odd; break;
                case 2: P = Parity.Even; break;
                case 3: P = Parity.Mark; break;
                case 4: P = Parity.Space; break;
            }

            switch (Serial_StopBits.SelectedIndex)
            {
                case 0: SB = StopBits.None; break;
                case 1: SB = StopBits.One; break;
                case 2: SB = StopBits.Two; break;
                case 3: SB = StopBits.OnePointFive; break;
            }

            switch (Serial_Handshake.SelectedIndex)
            {
                case 0: H = Handshake.None; break;
                case 1: H = Handshake.XOnXOff; break;
                case 2: H = Handshake.RequestToSend; break;
                case 3: H = Handshake.RequestToSendXOnXOff; break;
            }

            AppGlobals.CurrentDataReceiver = new SerialReceiver(PN, BPS, P, SB, H);
        }

        private void CreateUDP()
        {
            bool Any = UDP_Any.Checked;
            Int16 Port = Convert.ToInt16(UDP_Port.Text);

            if (Any)
            {
                AppGlobals.CurrentDataReceiver = new UDPReceiver(Port);
            }
            else
            {
                string IP = UDP_IP1.Text + "." + UDP_IP2.Text + "." + UDP_IP3.Text + "." + UDP_IP4.Text;
                AppGlobals.CurrentDataReceiver = new UDPReceiver(IP, Port);
            }
        }

        private void UDP_Any_CheckedChanged(object sender, EventArgs e)
        {
            bool Set = !UDP_Any.Checked;

            UDP_IP1.Enabled = Set;
            UDP_IP2.Enabled = Set;
            UDP_IP3.Enabled = Set;
            UDP_IP4.Enabled = Set;
        }

        private void Button_BeginZigZag_Click(object sender, EventArgs e)
        {
            ZigZagConfig Config = new ZigZagConfig();
            Config.ShowDialog();
        }

        private void Button_GenerateRaport_Click(object sender, EventArgs e)
        {
            FileStream SaveToFile = new FileStream("raport.txt", FileMode.Create, FileAccess.Write);
            StreamWriter Saver = new StreamWriter(SaveToFile);

            Saver.Write(AppGlobals.CurrentRaport.GenerateRaport());
            Saver.Flush();
            Saver.Close();
        }

        public void ReactToFinishedTest()
        {
            Button_GenerateRaport.Enabled = true;
            AddResultsToGridView(AppGlobals.CurrentRaport.GetTimes());
        }

        private void AddResultsToGridView(TimeSpan[] Times)
        {
            //todo: przetestować
            GridView_TestTimes.Columns.Add("Czas odbicia", "");
            GridView_TestTimes.Columns.Add("Czas nawrotu", "");

            int RowCount = Times.Count() / 2;
            for (int i = 0; i < RowCount; i++)
            {
                GridView_TestTimes.Rows.Add(RowCount);
                GridView_TestTimes.Rows[i * 2].Cells[0].Value = Times[i * 2].ToString(@"h\:mm\:ss\.f");
                GridView_TestTimes.Rows[i * 2].Cells[1].Value = Times[i*2+1].ToString(@"h\:mm\:ss\.f");
            }
        }
    }
}
