namespace CMPE2300NolanDeutschICA07
{
    partial class frmMain
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
            this.btnPop = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnWidth = new System.Windows.Forms.Button();
            this.btnWD = new System.Windows.Forms.Button();
            this.btnWC = new System.Windows.Forms.Button();
            this.btnBright = new System.Windows.Forms.Button();
            this.btnLonger = new System.Windows.Forms.Button();
            this.tbMain = new System.Windows.Forms.TrackBar();
            this.tbMaxBlock = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(16, 15);
            this.btnPop.Margin = new System.Windows.Forms.Padding(4);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(347, 42);
            this.btnPop.TabIndex = 0;
            this.btnPop.Text = "Populate";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(16, 64);
            this.btnColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(347, 42);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Colour";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnWidth
            // 
            this.btnWidth.Location = new System.Drawing.Point(16, 113);
            this.btnWidth.Margin = new System.Windows.Forms.Padding(4);
            this.btnWidth.Name = "btnWidth";
            this.btnWidth.Size = new System.Drawing.Size(347, 42);
            this.btnWidth.TabIndex = 2;
            this.btnWidth.Text = "Width";
            this.btnWidth.UseVisualStyleBackColor = true;
            this.btnWidth.Click += new System.EventHandler(this.btnWidth_Click);
            // 
            // btnWD
            // 
            this.btnWD.Location = new System.Drawing.Point(16, 162);
            this.btnWD.Margin = new System.Windows.Forms.Padding(4);
            this.btnWD.Name = "btnWD";
            this.btnWD.Size = new System.Drawing.Size(347, 42);
            this.btnWD.TabIndex = 3;
            this.btnWD.Text = "Width Desc";
            this.btnWD.UseVisualStyleBackColor = true;
            this.btnWD.Click += new System.EventHandler(this.btnWD_Click);
            // 
            // btnWC
            // 
            this.btnWC.Location = new System.Drawing.Point(16, 212);
            this.btnWC.Margin = new System.Windows.Forms.Padding(4);
            this.btnWC.Name = "btnWC";
            this.btnWC.Size = new System.Drawing.Size(347, 42);
            this.btnWC.TabIndex = 4;
            this.btnWC.Text = "Width Colour";
            this.btnWC.UseVisualStyleBackColor = true;
            this.btnWC.Click += new System.EventHandler(this.btnWC_Click);
            // 
            // btnBright
            // 
            this.btnBright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBright.Location = new System.Drawing.Point(16, 261);
            this.btnBright.Margin = new System.Windows.Forms.Padding(4);
            this.btnBright.Name = "btnBright";
            this.btnBright.Size = new System.Drawing.Size(347, 42);
            this.btnBright.TabIndex = 5;
            this.btnBright.Text = "Bright";
            this.btnBright.UseVisualStyleBackColor = true;
            this.btnBright.Click += new System.EventHandler(this.btnBright_Click);
            // 
            // btnLonger
            // 
            this.btnLonger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLonger.Location = new System.Drawing.Point(16, 310);
            this.btnLonger.Margin = new System.Windows.Forms.Padding(4);
            this.btnLonger.Name = "btnLonger";
            this.btnLonger.Size = new System.Drawing.Size(347, 42);
            this.btnLonger.TabIndex = 6;
            this.btnLonger.Text = "Longer than 100";
            this.btnLonger.UseVisualStyleBackColor = true;
            this.btnLonger.Click += new System.EventHandler(this.btnLonger_Click);
            // 
            // tbMain
            // 
            this.tbMain.Location = new System.Drawing.Point(16, 375);
            this.tbMain.Margin = new System.Windows.Forms.Padding(4);
            this.tbMain.Maximum = 190;
            this.tbMain.Minimum = 10;
            this.tbMain.Name = "tbMain";
            this.tbMain.Size = new System.Drawing.Size(347, 56);
            this.tbMain.TabIndex = 7;
            this.tbMain.Value = 100;
            this.tbMain.Scroll += new System.EventHandler(this.tbMain_Scroll);
            // 
            // tbMaxBlock
            // 
            this.tbMaxBlock.Location = new System.Drawing.Point(16, 423);
            this.tbMaxBlock.Maximum = 200;
            this.tbMaxBlock.Name = "tbMaxBlock";
            this.tbMaxBlock.Size = new System.Drawing.Size(347, 56);
            this.tbMaxBlock.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 491);
            this.Controls.Add(this.tbMaxBlock);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.btnLonger);
            this.Controls.Add(this.btnBright);
            this.Controls.Add(this.btnWC);
            this.Controls.Add(this.btnWD);
            this.Controls.Add(this.btnWidth);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnPop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "ica07 - PrediBlocks";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.tbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxBlock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnWidth;
        private System.Windows.Forms.Button btnWD;
        private System.Windows.Forms.Button btnWC;
        private System.Windows.Forms.Button btnBright;
        private System.Windows.Forms.Button btnLonger;
        private System.Windows.Forms.TrackBar tbMain;
        private System.Windows.Forms.TrackBar tbMaxBlock;
    }
}

