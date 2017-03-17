using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZigZagTest
{
    public partial class MainWindow : Form
    {
        enum ConnectionType
        {
            None,
            UDP,
            Serial
        };
        ConnectionType SelectedConnectionType = ConnectionType.None;


        public MainWindow()
        {
            InitializeComponent();
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
                    Button_Connect.Enabled = false;
                    break;
            }
        }

        private void Button_Connect_Click(object sender, EventArgs e)
        {
            switch (SelectedConnectionType)
            {
                case ConnectionType.UDP:    CreateUDP();    break;
                case ConnectionType.Serial: CreateSerial(); break;
            }

            AppGlobals.CurrentDataReceiver.StartReading();
        }

        private void CreateSerial()
        {
            Parity P = Parity.None;
            StopBits SB = StopBits.None;
            Handshake H = Handshake.None;

            switch (Serial_ParityCheck.Text)
            {
                case "Brak": P = Parity.None; break;
                case "Odd": P = Parity.Odd; break;
                case "Even": P = Parity.Even; break;
                case "Mark": P = Parity.Mark; break;
                case "Space": P = Parity.Space; break;
            }

            switch (Serial_StopBits.Text)
            {
                case "Brak": SB = StopBits.None; break;
                case "One": SB = StopBits.One; break;
                case "Two": SB = StopBits.Two; break;
                case "One Point Five": SB = StopBits.OnePointFive; break;
            }

            switch (Serial_Handshake.Text)
            {
                case "Brak": H = Handshake.None; break;
                case "X ON X OFF": H = Handshake.XOnXOff; break;
                case "Zarządaj przesłania": H = Handshake.RequestToSend; break;
                case "Zarządzaj przełania X ON X OFF": H = Handshake.RequestToSendXOnXOff; break;
            }

            AppGlobals.CurrentDataReceiver = new SerialReceiver(
                                                                Serial_PortName.Text,
                                                                Convert.ToInt32(Serial_BPSRate.Text),
                                                                P, SB, H
                                                               );
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
    }
}
