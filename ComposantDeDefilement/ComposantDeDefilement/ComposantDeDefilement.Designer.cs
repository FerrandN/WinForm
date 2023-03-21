namespace ComposantDeDefilement
{
    partial class ComposantDeDefilement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hScrollBarRed = new System.Windows.Forms.HScrollBar();
            this.hScrollBarGreen = new System.Windows.Forms.HScrollBar();
            this.hScrollBarBlue = new System.Windows.Forms.HScrollBar();
            this.labelRedText = new System.Windows.Forms.Label();
            this.labelGreenText = new System.Windows.Forms.Label();
            this.labelBlueText = new System.Windows.Forms.Label();
            this.labelRedColor = new System.Windows.Forms.Label();
            this.labelGreenColor = new System.Windows.Forms.Label();
            this.labelBlueColor = new System.Windows.Forms.Label();
            this.labelFinalColor = new System.Windows.Forms.Label();
            this.numericUpDownRed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGreen = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBlue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // hScrollBarRed
            // 
            this.hScrollBarRed.Location = new System.Drawing.Point(191, 88);
            this.hScrollBarRed.Maximum = 255;
            this.hScrollBarRed.Name = "hScrollBarRed";
            this.hScrollBarRed.Size = new System.Drawing.Size(122, 22);
            this.hScrollBarRed.TabIndex = 0;
            this.hScrollBarRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarRed_Scroll);
            // 
            // hScrollBarGreen
            // 
            this.hScrollBarGreen.Location = new System.Drawing.Point(191, 139);
            this.hScrollBarGreen.Maximum = 255;
            this.hScrollBarGreen.Name = "hScrollBarGreen";
            this.hScrollBarGreen.Size = new System.Drawing.Size(122, 17);
            this.hScrollBarGreen.TabIndex = 1;
            this.hScrollBarGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarGreen_Scroll);
            // 
            // hScrollBarBlue
            // 
            this.hScrollBarBlue.Location = new System.Drawing.Point(191, 185);
            this.hScrollBarBlue.Maximum = 255;
            this.hScrollBarBlue.Name = "hScrollBarBlue";
            this.hScrollBarBlue.Size = new System.Drawing.Size(122, 17);
            this.hScrollBarBlue.TabIndex = 2;
            this.hScrollBarBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarBlue_Scroll);
            // 
            // labelRedText
            // 
            this.labelRedText.AutoSize = true;
            this.labelRedText.Location = new System.Drawing.Point(88, 89);
            this.labelRedText.Name = "labelRedText";
            this.labelRedText.Size = new System.Drawing.Size(41, 15);
            this.labelRedText.TabIndex = 6;
            this.labelRedText.Text = "Rouge";
            // 
            // labelGreenText
            // 
            this.labelGreenText.AutoSize = true;
            this.labelGreenText.Location = new System.Drawing.Point(88, 135);
            this.labelGreenText.Name = "labelGreenText";
            this.labelGreenText.Size = new System.Drawing.Size(27, 15);
            this.labelGreenText.TabIndex = 7;
            this.labelGreenText.Text = "Vert";
            // 
            // labelBlueText
            // 
            this.labelBlueText.AutoSize = true;
            this.labelBlueText.Location = new System.Drawing.Point(88, 187);
            this.labelBlueText.Name = "labelBlueText";
            this.labelBlueText.Size = new System.Drawing.Size(30, 15);
            this.labelBlueText.TabIndex = 8;
            this.labelBlueText.Text = "Bleu";
            // 
            // labelRedColor
            // 
            this.labelRedColor.AutoSize = true;
            this.labelRedColor.Location = new System.Drawing.Point(502, 91);
            this.labelRedColor.MinimumSize = new System.Drawing.Size(50, 15);
            this.labelRedColor.Name = "labelRedColor";
            this.labelRedColor.Size = new System.Drawing.Size(50, 15);
            this.labelRedColor.TabIndex = 9;
            // 
            // labelGreenColor
            // 
            this.labelGreenColor.AutoSize = true;
            this.labelGreenColor.Location = new System.Drawing.Point(502, 141);
            this.labelGreenColor.MinimumSize = new System.Drawing.Size(50, 15);
            this.labelGreenColor.Name = "labelGreenColor";
            this.labelGreenColor.Size = new System.Drawing.Size(50, 15);
            this.labelGreenColor.TabIndex = 10;
            // 
            // labelBlueColor
            // 
            this.labelBlueColor.AutoSize = true;
            this.labelBlueColor.Location = new System.Drawing.Point(502, 187);
            this.labelBlueColor.MinimumSize = new System.Drawing.Size(50, 15);
            this.labelBlueColor.Name = "labelBlueColor";
            this.labelBlueColor.Size = new System.Drawing.Size(50, 15);
            this.labelBlueColor.TabIndex = 11;
            // 
            // labelFinalColor
            // 
            this.labelFinalColor.AutoSize = true;
            this.labelFinalColor.Location = new System.Drawing.Point(191, 258);
            this.labelFinalColor.MinimumSize = new System.Drawing.Size(250, 50);
            this.labelFinalColor.Name = "labelFinalColor";
            this.labelFinalColor.Size = new System.Drawing.Size(250, 50);
            this.labelFinalColor.TabIndex = 12;
            // 
            // numericUpDownRed
            // 
            this.numericUpDownRed.Location = new System.Drawing.Point(343, 89);
            this.numericUpDownRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRed.Name = "numericUpDownRed";
            this.numericUpDownRed.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownRed.TabIndex = 13;
            this.numericUpDownRed.ValueChanged += new System.EventHandler(this.numericUpDownRed_ValueChanged);
            // 
            // numericUpDownGreen
            // 
            this.numericUpDownGreen.Location = new System.Drawing.Point(343, 139);
            this.numericUpDownGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownGreen.Name = "numericUpDownGreen";
            this.numericUpDownGreen.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownGreen.TabIndex = 14;
            this.numericUpDownGreen.ValueChanged += new System.EventHandler(this.numericUpDownGreen_ValueChanged);
            // 
            // numericUpDownBlue
            // 
            this.numericUpDownBlue.Location = new System.Drawing.Point(343, 185);
            this.numericUpDownBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBlue.Name = "numericUpDownBlue";
            this.numericUpDownBlue.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownBlue.TabIndex = 15;
            this.numericUpDownBlue.ValueChanged += new System.EventHandler(this.numericUpDownBlue_ValueChanged);
            // 
            // ComposantDeDefilement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 345);
            this.Controls.Add(this.numericUpDownBlue);
            this.Controls.Add(this.numericUpDownGreen);
            this.Controls.Add(this.numericUpDownRed);
            this.Controls.Add(this.labelFinalColor);
            this.Controls.Add(this.labelBlueColor);
            this.Controls.Add(this.labelGreenColor);
            this.Controls.Add(this.labelRedColor);
            this.Controls.Add(this.labelBlueText);
            this.Controls.Add(this.labelGreenText);
            this.Controls.Add(this.labelRedText);
            this.Controls.Add(this.hScrollBarBlue);
            this.Controls.Add(this.hScrollBarGreen);
            this.Controls.Add(this.hScrollBarRed);
            this.Name = "ComposantDeDefilement";
            this.Text = "ComposantDeDefilement";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HScrollBar hScrollBarRed;
        private HScrollBar hScrollBarGreen;
        private HScrollBar hScrollBarBlue;
        private Label labelRedText;
        private Label labelGreenText;
        private Label labelBlueText;
        private Label labelRedColor;
        private Label labelGreenColor;
        private Label labelBlueColor;
        private Label labelFinalColor;
        private NumericUpDown numericUpDownRed;
        private NumericUpDown numericUpDownGreen;
        private NumericUpDown numericUpDownBlue;
    }
}