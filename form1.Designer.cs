namespace FinalProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.battery = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.bloodSugarLabel = new System.Windows.Forms.Label();
            this.ReservoirLabel = new System.Windows.Forms.Label();
            this.Enabled = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(236, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clock";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(423, 577);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Message Doctor\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(217, 577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 46);
            this.label3.TabIndex = 7;
            this.label3.Text = "Blood Sugar Levels\r\n\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(50, 577);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Help Search\r\n";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Window;
            this.monthCalendar1.Location = new System.Drawing.Point(275, 210);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.White;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Blue;
            this.progressBar1.Location = new System.Drawing.Point(470, 429);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(250, 46);
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Value = 100;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(465, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Reservoir Levels";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(624, 577);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Manual Dose";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(635, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 31);
            this.label8.TabIndex = 19;
            this.label8.Text = "Name";
            // 
            // battery
            // 
            this.battery.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.battery.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.battery.Location = new System.Drawing.Point(300, 12);
            this.battery.Name = "battery";
            this.battery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.battery.RightToLeftLayout = true;
            this.battery.Size = new System.Drawing.Size(169, 100);
            this.battery.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.battery.TabIndex = 20;
            this.battery.Value = 100;
            this.battery.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(5, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 27);
            this.label9.TabIndex = 22;
            this.label9.Text = "Blood Sugar";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // bloodSugarLabel
            // 
            this.bloodSugarLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bloodSugarLabel.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodSugarLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bloodSugarLabel.Location = new System.Drawing.Point(158, 396);
            this.bloodSugarLabel.Name = "bloodSugarLabel";
            this.bloodSugarLabel.Size = new System.Drawing.Size(149, 23);
            this.bloodSugarLabel.TabIndex = 24;
            this.bloodSugarLabel.Text = "label10";
            // 
            // ReservoirLabel
            // 
            this.ReservoirLabel.BackColor = System.Drawing.Color.White;
            this.ReservoirLabel.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservoirLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReservoirLabel.Location = new System.Drawing.Point(664, 396);
            this.ReservoirLabel.Name = "ReservoirLabel";
            this.ReservoirLabel.Size = new System.Drawing.Size(125, 27);
            this.ReservoirLabel.TabIndex = 25;
            this.ReservoirLabel.Text = "label10";
            // 
            // Enabled
            // 
            this.Enabled.BackColor = System.Drawing.Color.SkyBlue;
            this.Enabled.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Enabled.Location = new System.Drawing.Point(22, 448);
            this.Enabled.Name = "Enabled";
            this.Enabled.Size = new System.Drawing.Size(164, 73);
            this.Enabled.TabIndex = 26;
            this.Enabled.Text = "Enable Auto Mode";
            this.Enabled.UseVisualStyleBackColor = false;
            this.Enabled.Click += new System.EventHandler(this.Enabled_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Image = global::FinalProject.Properties.Resources.charts_imag;
            this.button3.Location = new System.Drawing.Point(218, 606);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 160);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Image = global::FinalProject.Properties.Resources.avatarImage;
            this.button8.Location = new System.Drawing.Point(565, 1);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(224, 180);
            this.button8.TabIndex = 18;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Image = global::FinalProject.Properties.Resources.connectivityImage;
            this.button5.Location = new System.Drawing.Point(3, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 124);
            this.button5.TabIndex = 17;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Image = global::FinalProject.Properties.Resources.batteryImage;
            this.button7.Location = new System.Drawing.Point(266, -41);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(219, 165);
            this.button7.TabIndex = 16;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Image = global::FinalProject.Properties.Resources.bluetooth_icon;
            this.button6.Location = new System.Drawing.Point(147, -8);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 132);
            this.button6.TabIndex = 15;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Image = global::FinalProject.Properties.Resources.takingInsulinResized;
            this.button4.Location = new System.Drawing.Point(597, 606);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 160);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = global::FinalProject.Properties.Resources.HelpImageResizedasdfasdf;
            this.button1.Location = new System.Drawing.Point(18, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 160);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = global::FinalProject.Properties.Resources.messageIconResized;
            this.button2.Location = new System.Drawing.Point(427, 606);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 160);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(790, 768);
            this.Controls.Add(this.Enabled);
            this.Controls.Add(this.ReservoirLabel);
            this.Controls.Add(this.bloodSugarLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.battery);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Resovior level";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ProgressBar battery;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label bloodSugarLabel;
        private System.Windows.Forms.Label ReservoirLabel;
        private System.Windows.Forms.Button Enabled;
    }
}

