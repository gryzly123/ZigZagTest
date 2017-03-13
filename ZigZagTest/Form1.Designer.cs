﻿namespace ZigZagTest
{
    partial class Form1
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
            this.PortName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HandshakeSet = new System.Windows.Forms.ComboBox();
            this.StopBitsSelection = new System.Windows.Forms.ComboBox();
            this.ParityBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Group_ConfigureUDP = new System.Windows.Forms.GroupBox();
            this.Configuration_Main = new System.Windows.Forms.GroupBox();
            this.Button_Connect = new System.Windows.Forms.Button();
            this.Configuration_Serial = new System.Windows.Forms.RadioButton();
            this.Configuration_UDP = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Button_GenerateRaport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Button_PerformTest = new System.Windows.Forms.Button();
            this.SerialPortSingleton = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Group_ConfigureSerial.SuspendLayout();
            this.Group_ConfigureUDP.SuspendLayout();
            this.Configuration_Main.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.Group_ConfigureSerial.Controls.Add(this.PortName);
            this.Group_ConfigureSerial.Controls.Add(this.label5);
            this.Group_ConfigureSerial.Controls.Add(this.label4);
            this.Group_ConfigureSerial.Controls.Add(this.label3);
            this.Group_ConfigureSerial.Controls.Add(this.label2);
            this.Group_ConfigureSerial.Controls.Add(this.HandshakeSet);
            this.Group_ConfigureSerial.Controls.Add(this.StopBitsSelection);
            this.Group_ConfigureSerial.Controls.Add(this.ParityBox);
            this.Group_ConfigureSerial.Controls.Add(this.label1);
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
            // 
            // PortName
            // 
            this.PortName.FormattingEnabled = true;
            this.PortName.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.PortName.Location = new System.Drawing.Point(123, 26);
            this.PortName.Name = "PortName";
            this.PortName.Size = new System.Drawing.Size(172, 21);
            this.PortName.TabIndex = 10;
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
            // HandshakeSet
            // 
            this.HandshakeSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HandshakeSet.FormattingEnabled = true;
            this.HandshakeSet.Items.AddRange(new object[] {
            "Brak",
            "X ON X OFF",
            "Zarządaj przesłania",
            "Zarządzaj przełania X ON X OFF"});
            this.HandshakeSet.Location = new System.Drawing.Point(123, 134);
            this.HandshakeSet.Name = "HandshakeSet";
            this.HandshakeSet.Size = new System.Drawing.Size(172, 21);
            this.HandshakeSet.TabIndex = 5;
            // 
            // StopBitsSelection
            // 
            this.StopBitsSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopBitsSelection.FormattingEnabled = true;
            this.StopBitsSelection.Items.AddRange(new object[] {
            "Brak",
            "One",
            "Two",
            "One Point Five"});
            this.StopBitsSelection.Location = new System.Drawing.Point(123, 107);
            this.StopBitsSelection.Name = "StopBitsSelection";
            this.StopBitsSelection.Size = new System.Drawing.Size(172, 21);
            this.StopBitsSelection.TabIndex = 4;
            // 
            // ParityBox
            // 
            this.ParityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParityBox.FormattingEnabled = true;
            this.ParityBox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.ParityBox.Location = new System.Drawing.Point(123, 80);
            this.ParityBox.Name = "ParityBox";
            this.ParityBox.Size = new System.Drawing.Size(172, 21);
            this.ParityBox.TabIndex = 3;
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
            this.Group_ConfigureUDP.Controls.Add(this.textBox5);
            this.Group_ConfigureUDP.Controls.Add(this.label8);
            this.Group_ConfigureUDP.Controls.Add(this.textBox4);
            this.Group_ConfigureUDP.Controls.Add(this.label7);
            this.Group_ConfigureUDP.Controls.Add(this.textBox3);
            this.Group_ConfigureUDP.Controls.Add(this.label6);
            this.Group_ConfigureUDP.Controls.Add(this.textBox2);
            this.Group_ConfigureUDP.Controls.Add(this.textBox1);
            this.Group_ConfigureUDP.Location = new System.Drawing.Point(3, 82);
            this.Group_ConfigureUDP.Name = "Group_ConfigureUDP";
            this.Group_ConfigureUDP.Size = new System.Drawing.Size(301, 83);
            this.Group_ConfigureUDP.TabIndex = 3;
            this.Group_ConfigureUDP.TabStop = false;
            this.Group_ConfigureUDP.Text = "Konfiguracja połączenia UDP";
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
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(307, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Odczyty GPS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 137);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // tabPage3
            // 
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
            this.Button_GenerateRaport.Location = new System.Drawing.Point(4, 307);
            this.Button_GenerateRaport.Name = "Button_GenerateRaport";
            this.Button_GenerateRaport.Size = new System.Drawing.Size(300, 30);
            this.Button_GenerateRaport.TabIndex = 1;
            this.Button_GenerateRaport.Text = "Generuj raport";
            this.Button_GenerateRaport.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 298);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statystyki ostatniej próby";
            // 
            // Button_PerformTest
            // 
            this.Button_PerformTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_PerformTest.Location = new System.Drawing.Point(12, 384);
            this.Button_PerformTest.Name = "Button_PerformTest";
            this.Button_PerformTest.Size = new System.Drawing.Size(315, 55);
            this.Button_PerformTest.TabIndex = 1;
            this.Button_PerformTest.Text = "ROZPOCZNIJ PRÓBĘ WĘŻOWĄ";
            this.Button_PerformTest.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(29, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(43, 20);
            this.textBox2.TabIndex = 1;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(170, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(29, 20);
            this.textBox3.TabIndex = 4;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(217, 20);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(29, 20);
            this.textBox4.TabIndex = 6;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(264, 20);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(29, 20);
            this.textBox5.TabIndex = 8;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 445);
            this.Controls.Add(this.Button_PerformTest);
            this.Controls.Add(this.MainTabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Group_ConfigureSerial.ResumeLayout(false);
            this.Group_ConfigureSerial.PerformLayout();
            this.Group_ConfigureUDP.ResumeLayout(false);
            this.Group_ConfigureUDP.PerformLayout();
            this.Configuration_Main.ResumeLayout(false);
            this.Configuration_Main.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox Group_ConfigureSerial;
        private System.Windows.Forms.ComboBox Serial_BPSRate;
        private System.Windows.Forms.ComboBox PortName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox HandshakeSet;
        private System.Windows.Forms.ComboBox StopBitsSelection;
        private System.Windows.Forms.ComboBox ParityBox;
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
        private System.Windows.Forms.Button Button_PerformTest;
        private System.IO.Ports.SerialPort SerialPortSingleton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}
