namespace CMPE2300NolanDeutschLab02
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbExplosionRadius = new System.Windows.Forms.TrackBar();
            this.tbIncomingMissiles = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNumMissiles = new System.Windows.Forms.Label();
            this.lblExplosionRadius = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbLegendary = new System.Windows.Forms.RadioButton();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.rbModerate = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblKillRatio = new System.Windows.Forms.Label();
            this.lblLaunched = new System.Windows.Forms.Label();
            this.lblDestroyed = new System.Windows.Forms.Label();
            this.lblTotalIncoming = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl05 = new System.Windows.Forms.Label();
            this.lbl04 = new System.Windows.Forms.Label();
            this.lbl03 = new System.Windows.Forms.Label();
            this.lbl02 = new System.Windows.Forms.Label();
            this.lbl01 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbExplosionRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIncomingMissiles)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnPause);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(303, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 46);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Stop";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(163, 19);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(103, 46);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(25, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(103, 46);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbExplosionRadius
            // 
            this.tbExplosionRadius.Location = new System.Drawing.Point(34, 35);
            this.tbExplosionRadius.Maximum = 100;
            this.tbExplosionRadius.Minimum = 5;
            this.tbExplosionRadius.Name = "tbExplosionRadius";
            this.tbExplosionRadius.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbExplosionRadius.Size = new System.Drawing.Size(45, 114);
            this.tbExplosionRadius.TabIndex = 1;
            this.tbExplosionRadius.TickFrequency = 5;
            this.tbExplosionRadius.Value = 50;
            this.tbExplosionRadius.Scroll += new System.EventHandler(this.tbExplosionRadius_Scroll);
            // 
            // tbIncomingMissiles
            // 
            this.tbIncomingMissiles.Location = new System.Drawing.Point(305, 35);
            this.tbIncomingMissiles.Maximum = 100;
            this.tbIncomingMissiles.Minimum = 1;
            this.tbIncomingMissiles.Name = "tbIncomingMissiles";
            this.tbIncomingMissiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbIncomingMissiles.Size = new System.Drawing.Size(45, 114);
            this.tbIncomingMissiles.TabIndex = 4;
            this.tbIncomingMissiles.Value = 5;
            this.tbIncomingMissiles.Scroll += new System.EventHandler(this.tbIncomingMissiles_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNumMissiles);
            this.groupBox2.Controls.Add(this.lblExplosionRadius);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lbl2);
            this.groupBox2.Controls.Add(this.lbl1);
            this.groupBox2.Controls.Add(this.tbExplosionRadius);
            this.groupBox2.Controls.Add(this.tbIncomingMissiles);
            this.groupBox2.Location = new System.Drawing.Point(41, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 182);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // lblNumMissiles
            // 
            this.lblNumMissiles.AutoSize = true;
            this.lblNumMissiles.Location = new System.Drawing.Point(315, 152);
            this.lblNumMissiles.Name = "lblNumMissiles";
            this.lblNumMissiles.Size = new System.Drawing.Size(13, 13);
            this.lblNumMissiles.TabIndex = 13;
            this.lblNumMissiles.Text = "5";
            // 
            // lblExplosionRadius
            // 
            this.lblExplosionRadius.AutoSize = true;
            this.lblExplosionRadius.Location = new System.Drawing.Point(40, 152);
            this.lblExplosionRadius.Name = "lblExplosionRadius";
            this.lblExplosionRadius.Size = new System.Drawing.Size(19, 13);
            this.lblExplosionRadius.TabIndex = 12;
            this.lblExplosionRadius.Text = "50";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbLegendary);
            this.groupBox3.Controls.Add(this.rbHard);
            this.groupBox3.Controls.Add(this.rbModerate);
            this.groupBox3.Controls.Add(this.rbEasy);
            this.groupBox3.Location = new System.Drawing.Point(135, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(103, 114);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Difficulty";
            // 
            // rbLegendary
            // 
            this.rbLegendary.AutoSize = true;
            this.rbLegendary.Location = new System.Drawing.Point(3, 87);
            this.rbLegendary.Name = "rbLegendary";
            this.rbLegendary.Size = new System.Drawing.Size(75, 17);
            this.rbLegendary.TabIndex = 13;
            this.rbLegendary.TabStop = true;
            this.rbLegendary.Text = "Legendary";
            this.rbLegendary.UseVisualStyleBackColor = true;
            this.rbLegendary.CheckedChanged += new System.EventHandler(this.rbEasy_CheckedChanged);
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.Location = new System.Drawing.Point(3, 62);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(48, 17);
            this.rbHard.TabIndex = 12;
            this.rbHard.TabStop = true;
            this.rbHard.Text = "Hard";
            this.rbHard.UseVisualStyleBackColor = true;
            this.rbHard.CheckedChanged += new System.EventHandler(this.rbEasy_CheckedChanged);
            // 
            // rbModerate
            // 
            this.rbModerate.AutoSize = true;
            this.rbModerate.Location = new System.Drawing.Point(3, 39);
            this.rbModerate.Name = "rbModerate";
            this.rbModerate.Size = new System.Drawing.Size(70, 17);
            this.rbModerate.TabIndex = 1;
            this.rbModerate.TabStop = true;
            this.rbModerate.Text = "Moderate";
            this.rbModerate.UseVisualStyleBackColor = true;
            this.rbModerate.CheckedChanged += new System.EventHandler(this.rbEasy_CheckedChanged);
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Location = new System.Drawing.Point(3, 16);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(48, 17);
            this.rbEasy.TabIndex = 0;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = true;
            this.rbEasy.CheckedChanged += new System.EventHandler(this.rbEasy_CheckedChanged);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(291, 19);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(65, 13);
            this.lbl2.TabIndex = 9;
            this.lbl2.Text = "# of Missiles";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 19);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(88, 13);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "Explosion Radius";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblScore);
            this.groupBox4.Controls.Add(this.lblKillRatio);
            this.groupBox4.Controls.Add(this.lblLaunched);
            this.groupBox4.Controls.Add(this.lblDestroyed);
            this.groupBox4.Controls.Add(this.lblTotalIncoming);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(38, 301);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(174, 117);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stats:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(135, 97);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(13, 13);
            this.lblScore.TabIndex = 13;
            this.lblScore.Text = "0";
            // 
            // lblKillRatio
            // 
            this.lblKillRatio.AutoSize = true;
            this.lblKillRatio.Location = new System.Drawing.Point(135, 77);
            this.lblKillRatio.Name = "lblKillRatio";
            this.lblKillRatio.Size = new System.Drawing.Size(13, 13);
            this.lblKillRatio.TabIndex = 12;
            this.lblKillRatio.Text = "0";
            // 
            // lblLaunched
            // 
            this.lblLaunched.AutoSize = true;
            this.lblLaunched.Location = new System.Drawing.Point(135, 58);
            this.lblLaunched.Name = "lblLaunched";
            this.lblLaunched.Size = new System.Drawing.Size(13, 13);
            this.lblLaunched.TabIndex = 11;
            this.lblLaunched.Text = "0";
            // 
            // lblDestroyed
            // 
            this.lblDestroyed.AutoSize = true;
            this.lblDestroyed.Location = new System.Drawing.Point(135, 39);
            this.lblDestroyed.Name = "lblDestroyed";
            this.lblDestroyed.Size = new System.Drawing.Size(13, 13);
            this.lblDestroyed.TabIndex = 10;
            this.lblDestroyed.Text = "0";
            // 
            // lblTotalIncoming
            // 
            this.lblTotalIncoming.AutoSize = true;
            this.lblTotalIncoming.Location = new System.Drawing.Point(135, 21);
            this.lblTotalIncoming.Name = "lblTotalIncoming";
            this.lblTotalIncoming.Size = new System.Drawing.Size(13, 13);
            this.lblTotalIncoming.TabIndex = 9;
            this.lblTotalIncoming.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Current Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kill Ratio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Missiles Launched:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destroyed Incoming:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Incoming:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbl05);
            this.groupBox5.Controls.Add(this.lbl04);
            this.groupBox5.Controls.Add(this.lbl03);
            this.groupBox5.Controls.Add(this.lbl02);
            this.groupBox5.Controls.Add(this.lbl01);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(245, 301);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(174, 117);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "High Scores:";
            // 
            // lbl05
            // 
            this.lbl05.AutoSize = true;
            this.lbl05.Location = new System.Drawing.Point(68, 97);
            this.lbl05.Name = "lbl05";
            this.lbl05.Size = new System.Drawing.Size(67, 13);
            this.lbl05.TabIndex = 18;
            this.lbl05.Text = "--------------------";
            // 
            // lbl04
            // 
            this.lbl04.AutoSize = true;
            this.lbl04.Location = new System.Drawing.Point(68, 77);
            this.lbl04.Name = "lbl04";
            this.lbl04.Size = new System.Drawing.Size(67, 13);
            this.lbl04.TabIndex = 17;
            this.lbl04.Text = "--------------------";
            // 
            // lbl03
            // 
            this.lbl03.AutoSize = true;
            this.lbl03.Location = new System.Drawing.Point(68, 58);
            this.lbl03.Name = "lbl03";
            this.lbl03.Size = new System.Drawing.Size(67, 13);
            this.lbl03.TabIndex = 16;
            this.lbl03.Text = "--------------------";
            // 
            // lbl02
            // 
            this.lbl02.AutoSize = true;
            this.lbl02.Location = new System.Drawing.Point(68, 39);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(67, 13);
            this.lbl02.TabIndex = 15;
            this.lbl02.Text = "--------------------";
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.Location = new System.Drawing.Point(68, 21);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(67, 13);
            this.lbl01.TabIndex = 14;
            this.lbl01.Text = "--------------------";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 430);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Missile Command";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbExplosionRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIncomingMissiles)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TrackBar tbExplosionRadius;
        private System.Windows.Forms.TrackBar tbIncomingMissiles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNumMissiles;
        private System.Windows.Forms.Label lblExplosionRadius;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbLegendary;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.RadioButton rbModerate;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblKillRatio;
        private System.Windows.Forms.Label lblLaunched;
        private System.Windows.Forms.Label lblDestroyed;
        private System.Windows.Forms.Label lblTotalIncoming;
        private System.Windows.Forms.Label lbl05;
        private System.Windows.Forms.Label lbl04;
        private System.Windows.Forms.Label lbl03;
        private System.Windows.Forms.Label lbl02;
        private System.Windows.Forms.Label lbl01;
    }
}

