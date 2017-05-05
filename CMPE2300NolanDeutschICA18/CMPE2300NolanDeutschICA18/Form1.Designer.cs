namespace CMPE2300NolanDeutschICA18
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
            this.tbScale = new System.Windows.Forms.TrackBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tbNumSteps = new System.Windows.Forms.TrackBar();
            this.lblScale = new System.Windows.Forms.Label();
            this.lblNumSteps = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumSteps)).BeginInit();
            this.SuspendLayout();
            // 
            // tbScale
            // 
            this.tbScale.Location = new System.Drawing.Point(12, 29);
            this.tbScale.Minimum = 1;
            this.tbScale.Name = "tbScale";
            this.tbScale.Size = new System.Drawing.Size(444, 56);
            this.tbScale.TabIndex = 0;
            this.tbScale.Value = 1;
            this.tbScale.Scroll += new System.EventHandler(this.tbScale_Scroll);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tbNumSteps
            // 
            this.tbNumSteps.Location = new System.Drawing.Point(12, 150);
            this.tbNumSteps.Maximum = 100000;
            this.tbNumSteps.Minimum = 1;
            this.tbNumSteps.Name = "tbNumSteps";
            this.tbNumSteps.Size = new System.Drawing.Size(444, 56);
            this.tbNumSteps.TabIndex = 1;
            this.tbNumSteps.TickFrequency = 5000;
            this.tbNumSteps.Value = 1;
            this.tbNumSteps.Scroll += new System.EventHandler(this.tbNumSteps_Scroll);
            // 
            // lblScale
            // 
            this.lblScale.AutoSize = true;
            this.lblScale.Location = new System.Drawing.Point(227, 88);
            this.lblScale.Name = "lblScale";
            this.lblScale.Size = new System.Drawing.Size(16, 17);
            this.lblScale.TabIndex = 2;
            this.lblScale.Text = "1";
            // 
            // lblNumSteps
            // 
            this.lblNumSteps.AutoSize = true;
            this.lblNumSteps.Location = new System.Drawing.Point(227, 209);
            this.lblNumSteps.Name = "lblNumSteps";
            this.lblNumSteps.Size = new System.Drawing.Size(16, 17);
            this.lblNumSteps.TabIndex = 3;
            this.lblNumSteps.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of Steps";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Scale";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 245);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumSteps);
            this.Controls.Add(this.lblScale);
            this.Controls.Add(this.tbNumSteps);
            this.Controls.Add(this.tbScale);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumSteps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbScale;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TrackBar tbNumSteps;
        private System.Windows.Forms.Label lblScale;
        private System.Windows.Forms.Label lblNumSteps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

