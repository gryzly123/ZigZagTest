namespace ZigZagTest
{
    partial class ZigZagTest
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
            this.Label_Instruction = new System.Windows.Forms.Label();
            this.Button_Begin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label_RelativeCourse = new System.Windows.Forms.Label();
            this.Label_COG = new System.Windows.Forms.Label();
            this.Label_Time = new System.Windows.Forms.Label();
            this.Label_SOG = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ZigZag_Timer = new System.Windows.Forms.Timer(this.components);
            this.Label_Log = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_Instruction
            // 
            this.Label_Instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_Instruction.Location = new System.Drawing.Point(12, 9);
            this.Label_Instruction.Name = "Label_Instruction";
            this.Label_Instruction.Size = new System.Drawing.Size(427, 120);
            this.Label_Instruction.TabIndex = 0;
            this.Label_Instruction.Text = "Wybierz kąt zerowy i kliknij \'Rozpocznij\'";
            this.Label_Instruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Begin
            // 
            this.Button_Begin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Begin.Location = new System.Drawing.Point(12, 132);
            this.Button_Begin.Name = "Button_Begin";
            this.Button_Begin.Size = new System.Drawing.Size(427, 71);
            this.Button_Begin.TabIndex = 1;
            this.Button_Begin.Text = "ROZPOCZNIJ";
            this.Button_Begin.UseVisualStyleBackColor = true;
            this.Button_Begin.Click += new System.EventHandler(this.Button_Begin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Czas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kąt absolutny:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kąt względny:";
            // 
            // Label_RelativeCourse
            // 
            this.Label_RelativeCourse.AutoSize = true;
            this.Label_RelativeCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_RelativeCourse.Location = new System.Drawing.Point(216, 319);
            this.Label_RelativeCourse.Name = "Label_RelativeCourse";
            this.Label_RelativeCourse.Size = new System.Drawing.Size(23, 31);
            this.Label_RelativeCourse.TabIndex = 7;
            this.Label_RelativeCourse.Text = "-";
            // 
            // Label_COG
            // 
            this.Label_COG.AutoSize = true;
            this.Label_COG.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_COG.Location = new System.Drawing.Point(216, 279);
            this.Label_COG.Name = "Label_COG";
            this.Label_COG.Size = new System.Drawing.Size(23, 31);
            this.Label_COG.TabIndex = 6;
            this.Label_COG.Text = "-";
            // 
            // Label_Time
            // 
            this.Label_Time.AutoSize = true;
            this.Label_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_Time.Location = new System.Drawing.Point(216, 238);
            this.Label_Time.Name = "Label_Time";
            this.Label_Time.Size = new System.Drawing.Size(128, 31);
            this.Label_Time.TabIndex = 5;
            this.Label_Time.Text = "0:00:00.0";
            // 
            // Label_SOG
            // 
            this.Label_SOG.AutoSize = true;
            this.Label_SOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_SOG.Location = new System.Drawing.Point(216, 359);
            this.Label_SOG.Name = "Label_SOG";
            this.Label_SOG.Size = new System.Drawing.Size(23, 31);
            this.Label_SOG.TabIndex = 9;
            this.Label_SOG.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(12, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 31);
            this.label8.TabIndex = 8;
            this.label8.Text = "Prędkość:";
            // 
            // ZigZag_Timer
            // 
            this.ZigZag_Timer.Enabled = true;
            this.ZigZag_Timer.Tick += new System.EventHandler(this.ZigZag_Timer_Tick);
            // 
            // Label_Log
            // 
            this.Label_Log.AutoSize = true;
            this.Label_Log.Location = new System.Drawing.Point(12, 417);
            this.Label_Log.Name = "Label_Log";
            this.Label_Log.Size = new System.Drawing.Size(57, 13);
            this.Label_Log.TabIndex = 10;
            this.Label_Log.Text = "Label_Log";
            // 
            // ZigZagTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 408);
            this.Controls.Add(this.Label_Log);
            this.Controls.Add(this.Label_SOG);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Label_RelativeCourse);
            this.Controls.Add(this.Label_COG);
            this.Controls.Add(this.Label_Time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Begin);
            this.Controls.Add(this.Label_Instruction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ZigZagTest";
            this.Text = "Przebieg próby";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Instruction;
        private System.Windows.Forms.Button Button_Begin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_RelativeCourse;
        private System.Windows.Forms.Label Label_COG;
        private System.Windows.Forms.Label Label_Time;
        private System.Windows.Forms.Label Label_SOG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer ZigZag_Timer;
        private System.Windows.Forms.Label Label_Log;
    }
}