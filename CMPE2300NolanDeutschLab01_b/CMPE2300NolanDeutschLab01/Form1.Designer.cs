namespace CMPE2300NolanDeutschLab01
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbLoadImage = new System.Windows.Forms.ToolStripButton();
            this.tsbEncode = new System.Windows.Forms.ToolStripButton();
            this.tsbDecode = new System.Windows.Forms.ToolStripButton();
            this.tsbDecodeImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.ofdLoad = new System.Windows.Forms.OpenFileDialog();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLoadImage,
            this.tsbEncode,
            this.tsbDecode,
            this.tsbDecodeImage,
            this.toolStripComboBox});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(553, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbLoadImage
            // 
            this.tsbLoadImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLoadImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadImage.Name = "tsbLoadImage";
            this.tsbLoadImage.Size = new System.Drawing.Size(73, 22);
            this.tsbLoadImage.Text = "Load Image";
            this.tsbLoadImage.Click += new System.EventHandler(this.tsbLoadImage_Click);
            // 
            // tsbEncode
            // 
            this.tsbEncode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEncode.Image = ((System.Drawing.Image)(resources.GetObject("tsbEncode.Image")));
            this.tsbEncode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEncode.Name = "tsbEncode";
            this.tsbEncode.Size = new System.Drawing.Size(50, 22);
            this.tsbEncode.Text = "Encode";
            this.tsbEncode.Click += new System.EventHandler(this.tsbEncode_Click);
            // 
            // tsbDecode
            // 
            this.tsbDecode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDecode.Image = ((System.Drawing.Image)(resources.GetObject("tsbDecode.Image")));
            this.tsbDecode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDecode.Name = "tsbDecode";
            this.tsbDecode.Size = new System.Drawing.Size(51, 22);
            this.tsbDecode.Text = "Decode";
            // 
            // tsbDecodeImage
            // 
            this.tsbDecodeImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDecodeImage.Image = ((System.Drawing.Image)(resources.GetObject("tsbDecodeImage.Image")));
            this.tsbDecodeImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDecodeImage.Name = "tsbDecodeImage";
            this.tsbDecodeImage.Size = new System.Drawing.Size(87, 22);
            this.tsbDecodeImage.Text = "Decode Image";
            this.tsbDecodeImage.Click += new System.EventHandler(this.tsbDecodeImage_Click);
            // 
            // toolStripComboBox
            // 
            this.toolStripComboBox.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "All"});
            this.toolStripComboBox.Name = "toolStripComboBox";
            this.toolStripComboBox.Size = new System.Drawing.Size(92, 25);
            this.toolStripComboBox.Text = "All";
            // 
            // ofdLoad
            // 
            this.ofdLoad.FileName = "openFileDialog1";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(9, 25);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(535, 446);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 519);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.toolStrip);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "Image Secrets";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbLoadImage;
        private System.Windows.Forms.ToolStripButton tsbEncode;
        private System.Windows.Forms.ToolStripButton tsbDecode;
        private System.Windows.Forms.ToolStripButton tsbDecodeImage;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox;
        private System.Windows.Forms.OpenFileDialog ofdLoad;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

