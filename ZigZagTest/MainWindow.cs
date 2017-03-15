using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
