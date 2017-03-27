namespace ZigZagTest
{
    partial class ZigZagConfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Label_Count = new System.Windows.Forms.Label();
            this.Trackbar_Count = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.Label_Angle = new System.Windows.Forms.Label();
            this.Trackbar_Angle = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Start = new System.Windows.Forms.Button();
            this.Trackbar_Angle2 = new System.Windows.Forms.TrackBar();
            this.Label_Angle2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar_Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar_Angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar_Angle2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Label_Angle2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Trackbar_Angle2);
            this.groupBox1.Controls.Add(this.Label_Count);
            this.groupBox1.Controls.Add(this.Trackbar_Count);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Label_Angle);
            this.groupBox1.Controls.Add(this.Trackbar_Angle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ustawienia próby";
            // 
            // Label_Count
            // 
            this.Label_Count.Location = new System.Drawing.Point(12, 131);
            this.Label_Count.Name = "Label_Count";
            this.Label_Count.Size = new System.Drawing.Size(126, 13);
            this.Label_Count.TabIndex = 5;
            this.Label_Count.Text = "5";
            this.Label_Count.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Trackbar_Count
            // 
            this.Trackbar_Count.Location = new System.Drawing.Point(144, 118);
            this.Trackbar_Count.Minimum = 3;
            this.Trackbar_Count.Name = "Trackbar_Count";
            this.Trackbar_Count.Size = new System.Drawing.Size(120, 45);
            this.Trackbar_Count.TabIndex = 4;
            this.Trackbar_Count.Value = 5;
            this.Trackbar_Count.Scroll += new System.EventHandler(this.Trackbar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ilość prób (odbić):";
            // 
            // Label_Angle
            // 
            this.Label_Angle.Location = new System.Drawing.Point(12, 29);
            this.Label_Angle.Name = "Label_Angle";
            this.Label_Angle.Size = new System.Drawing.Size(126, 13);
            this.Label_Angle.TabIndex = 2;
            this.Label_Angle.Text = "20 deg";
            this.Label_Angle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Trackbar_Angle
            // 
            this.Trackbar_Angle.Location = new System.Drawing.Point(144, 16);
            this.Trackbar_Angle.Maximum = 4;
            this.Trackbar_Angle.Minimum = 1;
            this.Trackbar_Angle.Name = "Trackbar_Angle";
            this.Trackbar_Angle.Size = new System.Drawing.Size(120, 45);
            this.Trackbar_Angle.TabIndex = 1;
            this.Trackbar_Angle.Value = 4;
            this.Trackbar_Angle.Scroll += new System.EventHandler(this.Trackbar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wychylenie nastawy:";
            // 
            // Button_Start
            // 
            this.Button_Start.Location = new System.Drawing.Point(12, 193);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(271, 23);
            this.Button_Start.TabIndex = 1;
            this.Button_Start.Text = "Rozpocznij";
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // Trackbar_Angle2
            // 
            this.Trackbar_Angle2.Location = new System.Drawing.Point(144, 67);
            this.Trackbar_Angle2.Maximum = 7;
            this.Trackbar_Angle2.Minimum = 4;
            this.Trackbar_Angle2.Name = "Trackbar_Angle2";
            this.Trackbar_Angle2.Size = new System.Drawing.Size(120, 45);
            this.Trackbar_Angle2.TabIndex = 6;
            this.Trackbar_Angle2.Value = 7;
            this.Trackbar_Angle2.Scroll += new System.EventHandler(this.Trackbar_Scroll);
            // 
            // Label_Angle2
            // 
            this.Label_Angle2.Location = new System.Drawing.Point(12, 80);
            this.Label_Angle2.Name = "Label_Angle2";
            this.Label_Angle2.Size = new System.Drawing.Size(126, 13);
            this.Label_Angle2.TabIndex = 8;
            this.Label_Angle2.Text = "20 deg";
            this.Label_Angle2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wychylenie do odbicia (δ):";
            // 
            // ZigZagConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 228);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ZigZagConfig";
            this.Text = "Ustawienia próby";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar_Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar_Angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar_Angle2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Count;
        private System.Windows.Forms.TrackBar Trackbar_Count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_Angle;
        private System.Windows.Forms.TrackBar Trackbar_Angle;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.Label Label_Angle2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar Trackbar_Angle2;
    }
}