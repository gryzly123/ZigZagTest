namespace ZigZagTest
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Group_ConfigureSerial = new System.Windows.Forms.GroupBox();
            this.Serial_BPSRate = new System.Windows.Forms.ComboBox();
            this.Serial_PortName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Serial_Handshake = new System.Windows.Forms.ComboBox();
            this.Serial_StopBits = new System.Windows.Forms.ComboBox();
            this.Serial_ParityCheck = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Group_ConfigureUDP = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UDP_IP4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UDP_IP3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UDP_IP2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UDP_Port = new System.Windows.Forms.TextBox();
            this.UDP_IP1 = new System.Windows.Forms.TextBox();
            this.Configuration_Main = new System.Windows.Forms.GroupBox();
            this.Button_Connect = new System.Windows.Forms.Button();
            this.Configuration_Serial = new System.Windows.Forms.RadioButton();
            this.Configuration_UDP = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Button_GenerateRaport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SerialPortSingleton = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.MainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Group_ConfigureSerial.SuspendLayout();
            this.Group_ConfigureUDP.SuspendLayout();
            this.Configuration_Main.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.tabPage1);
            this.MainTabControl.Controls.Add(this.tabPage2);
            this.MainTabControl.Controls.Add(this.tabPage3);
            this.MainTabControl.Location = new System.Drawing.Point(12, 12);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(315, 366);
            this.MainTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Group_ConfigureSerial);
            this.tabPage1.Controls.Add(this.Group_ConfigureUDP);
            this.tabPage1.Controls.Add(this.Configuration_Main);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(307, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Konfiguracja";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Group_ConfigureSerial
            // 
            this.Group_ConfigureSerial.Controls.Add(this.Serial_BPSRate);
            this.Group_ConfigureSerial.Controls.Add(this.Serial_PortName);
            this.Group_ConfigureSerial.Controls.Add(this.label5);
            this.Group_ConfigureSerial.Controls.Add(this.label4);
            this.Group_ConfigureSerial.Controls.Add(this.label3);
            this.Group_ConfigureSerial.Controls.Add(this.label2);
            this.Group_ConfigureSerial.Controls.Add(this.Serial_Handshake);
            this.Group_ConfigureSerial.Controls.Add(this.Serial_StopBits);
            this.Group_ConfigureSerial.Controls.Add(this.Serial_ParityCheck);
            this.Group_ConfigureSerial.Controls.Add(this.label1);
            this.Group_ConfigureSerial.Enabled = false;
            this.Group_ConfigureSerial.Location = new System.Drawing.Point(3, 171);
            this.Group_ConfigureSerial.Name = "Group_ConfigureSerial";
            this.Group_ConfigureSerial.Size = new System.Drawing.Size(301, 163);
            this.Group_ConfigureSerial.TabIndex = 4;
            this.Group_ConfigureSerial.TabStop = false;
            this.Group_ConfigureSerial.Text = "Konfiguracja portu szeregowego";
            // 
            // Serial_BPSRate
            // 
            this.Serial_BPSRate.FormattingEnabled = true;
            this.Serial_BPSRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "33600"});
            this.Serial_BPSRate.Location = new System.Drawing.Point(123, 53);
            this.Serial_BPSRate.Name = "Serial_BPSRate";
            this.Serial_BPSRate.Size = new System.Drawing.Size(172, 21);
            this.Serial_BPSRate.TabIndex = 11;
            this.Serial_BPSRate.Text = "9600";
            // 
            // Serial_PortName
            // 
            this.Serial_PortName.FormattingEnabled = true;
            this.Serial_PortName.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.Serial_PortName.Location = new System.Drawing.Point(123, 26);
            this.Serial_PortName.Name = "Serial_PortName";
            this.Serial_PortName.Size = new System.Drawing.Size(172, 21);
            this.Serial_PortName.TabIndex = 10;
            this.Serial_PortName.Text = "COM1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Uścisk dłoni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bity stopu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kontrola parzystości";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Baud Rate (BPS)";
            // 
            // Serial_Handshake
            // 
            this.Serial_Handshake.DisplayMember = "Brak";
            this.Serial_Handshake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Serial_Handshake.FormattingEnabled = true;
            this.Serial_Handshake.Items.AddRange(new object[] {
            "Brak",
            "X ON X OFF",
            "Zarządaj przesłania",
            "Zarządzaj przełania X ON X OFF"});
            this.Serial_Handshake.Location = new System.Drawing.Point(123, 134);
            this.Serial_Handshake.Name = "Serial_Handshake";
            this.Serial_Handshake.Size = new System.Drawing.Size(172, 21);
            this.Serial_Handshake.TabIndex = 5;
            this.Serial_Handshake.ValueMember = "Brak";
            // 
            // Serial_StopBits
            // 
            this.Serial_StopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Serial_StopBits.FormattingEnabled = true;
            this.Serial_StopBits.Items.AddRange(new object[] {
            "Brak",
            "One",
            "Two",
            "One Point Five"});
            this.Serial_StopBits.Location = new System.Drawing.Point(123, 107);
            this.Serial_StopBits.Name = "Serial_StopBits";
            this.Serial_StopBits.Size = new System.Drawing.Size(172, 21);
            this.Serial_StopBits.TabIndex = 4;
            // 
            // Serial_ParityCheck
            // 
            this.Serial_ParityCheck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Serial_ParityCheck.FormattingEnabled = true;
            this.Serial_ParityCheck.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.Serial_ParityCheck.Location = new System.Drawing.Point(123, 80);
            this.Serial_ParityCheck.Name = "Serial_ParityCheck";
            this.Serial_ParityCheck.Size = new System.Drawing.Size(172, 21);
            this.Serial_ParityCheck.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // Group_ConfigureUDP
            // 
            this.Group_ConfigureUDP.Controls.Add(this.label10);
            this.Group_ConfigureUDP.Controls.Add(this.label9);
            this.Group_ConfigureUDP.Controls.Add(this.UDP_IP4);
            this.Group_ConfigureUDP.Controls.Add(this.label8);
            this.Group_ConfigureUDP.Controls.Add(this.UDP_IP3);
            this.Group_ConfigureUDP.Controls.Add(this.label7);
            this.Group_ConfigureUDP.Controls.Add(this.UDP_IP2);
            this.Group_ConfigureUDP.Controls.Add(this.label6);
            this.Group_ConfigureUDP.Controls.Add(this.UDP_Port);
            this.Group_ConfigureUDP.Controls.Add(this.UDP_IP1);
            this.Group_ConfigureUDP.Enabled = false;
            this.Group_ConfigureUDP.Location = new System.Drawing.Point(3, 82);
            this.Group_ConfigureUDP.Name = "Group_ConfigureUDP";
            this.Group_ConfigureUDP.Size = new System.Drawing.Size(301, 83);
            this.Group_ConfigureUDP.TabIndex = 3;
            this.Group_ConfigureUDP.TabStop = false;
            this.Group_ConfigureUDP.Text = "Konfiguracja połączenia UDP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Port";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Adres IP";
            // 
            // UDP_IP4
            // 
            this.UDP_IP4.Location = new System.Drawing.Point(264, 20);
            this.UDP_IP4.Name = "UDP_IP4";
            this.UDP_IP4.Size = new System.Drawing.Size(29, 20);
            this.UDP_IP4.TabIndex = 8;
            this.UDP_IP4.Text = "0";
            this.UDP_IP4.TextChanged += new System.EventHandler(this.UDPIP_ValidateTextChange);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = ".";
            // 
            // UDP_IP3
            // 
            this.UDP_IP3.Location = new System.Drawing.Point(217, 20);
            this.UDP_IP3.Name = "UDP_IP3";
            this.UDP_IP3.Size = new System.Drawing.Size(29, 20);
            this.UDP_IP3.TabIndex = 6;
            this.UDP_IP3.Text = "0";
            this.UDP_IP3.TextChanged += new System.EventHandler(this.UDPIP_ValidateTextChange);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = ".";
            // 
            // UDP_IP2
            // 
            this.UDP_IP2.Location = new System.Drawing.Point(170, 20);
            this.UDP_IP2.Name = "UDP_IP2";
            this.UDP_IP2.Size = new System.Drawing.Size(29, 20);
            this.UDP_IP2.TabIndex = 4;
            this.UDP_IP2.Text = "0";
            this.UDP_IP2.TextChanged += new System.EventHandler(this.UDPIP_ValidateTextChange);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = ".";
            // 
            // UDP_Port
            // 
            this.UDP_Port.Location = new System.Drawing.Point(123, 46);
            this.UDP_Port.Name = "UDP_Port";
            this.UDP_Port.Size = new System.Drawing.Size(43, 20);
            this.UDP_Port.TabIndex = 1;
            this.UDP_Port.Text = "0";
            this.UDP_Port.TextChanged += new System.EventHandler(this.UDPIP_ValidateTextChange);
            // 
            // UDP_IP1
            // 
            this.UDP_IP1.Location = new System.Drawing.Point(123, 20);
            this.UDP_IP1.Name = "UDP_IP1";
            this.UDP_IP1.Size = new System.Drawing.Size(29, 20);
            this.UDP_IP1.TabIndex = 0;
            this.UDP_IP1.Text = "0";
            this.UDP_IP1.TextChanged += new System.EventHandler(this.UDPIP_ValidateTextChange);
            // 
            // Configuration_Main
            // 
            this.Configuration_Main.Controls.Add(this.Button_Connect);
            this.Configuration_Main.Controls.Add(this.Configuration_Serial);
            this.Configuration_Main.Controls.Add(this.Configuration_UDP);
            this.Configuration_Main.Location = new System.Drawing.Point(3, 3);
            this.Configuration_Main.Name = "Configuration_Main";
            this.Configuration_Main.Size = new System.Drawing.Size(301, 73);
            this.Configuration_Main.TabIndex = 1;
            this.Configuration_Main.TabStop = false;
            this.Configuration_Main.Text = "Jak połączyć się z odbiornikiem?";
            // 
            // Button_Connect
            // 
            this.Button_Connect.Enabled = false;
            this.Button_Connect.Location = new System.Drawing.Point(170, 19);
            this.Button_Connect.Name = "Button_Connect";
            this.Button_Connect.Size = new System.Drawing.Size(125, 40);
            this.Button_Connect.TabIndex = 2;
            this.Button_Connect.Text = "Połącz";
            this.Button_Connect.UseVisualStyleBackColor = true;
            // 
            // Configuration_Serial
            // 
            this.Configuration_Serial.AutoSize = true;
            this.Configuration_Serial.Location = new System.Drawing.Point(6, 42);
            this.Configuration_Serial.Name = "Configuration_Serial";
            this.Configuration_Serial.Size = new System.Drawing.Size(97, 17);
            this.Configuration_Serial.TabIndex = 1;
            this.Configuration_Serial.TabStop = true;
            this.Configuration_Serial.Text = "Port szeregowy";
            this.Configuration_Serial.UseVisualStyleBackColor = true;
            this.Configuration_Serial.CheckedChanged += new System.EventHandler(this.ConnectionType_Changed);
            // 
            // Configuration_UDP
            // 
            this.Configuration_UDP.AutoSize = true;
            this.Configuration_UDP.Location = new System.Drawing.Point(6, 19);
            this.Configuration_UDP.Name = "Configuration_UDP";
            this.Configuration_UDP.Size = new System.Drawing.Size(48, 17);
            this.Configuration_UDP.TabIndex = 0;
            this.Configuration_UDP.TabStop = true;
            this.Configuration_UDP.Text = "UDP";
            this.Configuration_UDP.UseVisualStyleBackColor = true;
            this.Configuration_UDP.CheckedChanged += new System.EventHandler(this.ConnectionType_Changed);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(307, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Odczyty GPS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 247);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odczyty";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(286, 147);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 78);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Heads up";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(218, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(10, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "-";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(218, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(10, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(66, 47);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(10, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "-";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(66, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(10, 13);
            this.label20.TabIndex = 5;
            this.label20.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(158, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "COG";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(158, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "SOG";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Longitude";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Latitude";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.Button_GenerateRaport);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(307, 340);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Próba wężowa";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Button_GenerateRaport
            // 
            this.Button_GenerateRaport.Location = new System.Drawing.Point(157, 307);
            this.Button_GenerateRaport.Name = "Button_GenerateRaport";
            this.Button_GenerateRaport.Size = new System.Drawing.Size(147, 30);
            this.Button_GenerateRaport.TabIndex = 1;
            this.Button_GenerateRaport.Text = "Generuj raport";
            this.Button_GenerateRaport.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 239);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statystyki ostatniej próby";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(289, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Rozpocznij próbę";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(4, 248);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 53);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wynik próby:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "T:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(10, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "-";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(128, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(10, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "-";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(105, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "k:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(221, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(10, 13);
            this.label23.TabIndex = 5;
            this.label23.Text = "-";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(198, 20);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(19, 13);
            this.label24.TabIndex = 4;
            this.label24.Text = "δc";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 394);
            this.Controls.Add(this.MainTabControl);
            this.Name = "MainWindow";
            this.Text = "ZigZag - Próba wężowa";
            this.MainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Group_ConfigureSerial.ResumeLayout(false);
            this.Group_ConfigureSerial.PerformLayout();
            this.Group_ConfigureUDP.ResumeLayout(false);
            this.Group_ConfigureUDP.PerformLayout();
            this.Configuration_Main.ResumeLayout(false);
            this.Configuration_Main.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox Group_ConfigureSerial;
        private System.Windows.Forms.ComboBox Serial_BPSRate;
        private System.Windows.Forms.ComboBox Serial_PortName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Serial_Handshake;
        private System.Windows.Forms.ComboBox Serial_StopBits;
        private System.Windows.Forms.ComboBox Serial_ParityCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Group_ConfigureUDP;
        private System.Windows.Forms.GroupBox Configuration_Main;
        private System.Windows.Forms.Button Button_Connect;
        private System.Windows.Forms.RadioButton Configuration_Serial;
        private System.Windows.Forms.RadioButton Configuration_UDP;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button Button_GenerateRaport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.IO.Ports.SerialPort SerialPortSingleton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UDP_Port;
        private System.Windows.Forms.TextBox UDP_IP1;
        private System.Windows.Forms.TextBox UDP_IP4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox UDP_IP3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UDP_IP2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}

