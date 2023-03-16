namespace ComposantsDeDefilement
{
    partial class ComposantsDeDefilementForm
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
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.hScrollBarRed = new System.Windows.Forms.HScrollBar();
            this.hScrollBarBlue = new System.Windows.Forms.HScrollBar();
            this.hScrollBarGreen = new System.Windows.Forms.HScrollBar();
            this.numericUpDownRed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGreen = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBlue = new System.Windows.Forms.NumericUpDown();
            this.labelRedColor = new System.Windows.Forms.Label();
            this.labelGreenColor = new System.Windows.Forms.Label();
            this.labelBlueColor = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Location = new System.Drawing.Point(35, 41);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(41, 15);
            this.labelRed.TabIndex = 0;
            this.labelRed.Text = "Rouge";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Location = new System.Drawing.Point(35, 78);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(27, 15);
            this.labelGreen.TabIndex = 1;
            this.labelGreen.Text = "Vert";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Location = new System.Drawing.Point(35, 117);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(30, 15);
            this.labelBlue.TabIndex = 2;
            this.labelBlue.Text = "Bleu";
            // 
            // hScrollBarRed
            // 
            this.hScrollBarRed.LargeChange = 1;
            this.hScrollBarRed.Location = new System.Drawing.Point(104, 41);
            this.hScrollBarRed.Maximum = 255;
            this.hScrollBarRed.Name = "hScrollBarRed";
            this.hScrollBarRed.Size = new System.Drawing.Size(160, 17);
            this.hScrollBarRed.TabIndex = 3;
            this.hScrollBarRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarRed_Scroll);
            this.hScrollBarRed.ValueChanged += new System.EventHandler(this.hScrollBarRed_ValueChanged);
            // 
            // hScrollBarBlue
            // 
            this.hScrollBarBlue.LargeChange = 1;
            this.hScrollBarBlue.Location = new System.Drawing.Point(104, 117);
            this.hScrollBarBlue.Maximum = 255;
            this.hScrollBarBlue.Name = "hScrollBarBlue";
            this.hScrollBarBlue.Size = new System.Drawing.Size(160, 17);
            this.hScrollBarBlue.TabIndex = 4;
            this.hScrollBarBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarBlue_Scroll);
            this.hScrollBarBlue.ValueChanged += new System.EventHandler(this.hScrollBarBlue_ValueChanged);
            // 
            // hScrollBarGreen
            // 
            this.hScrollBarGreen.LargeChange = 1;
            this.hScrollBarGreen.Location = new System.Drawing.Point(104, 78);
            this.hScrollBarGreen.Maximum = 255;
            this.hScrollBarGreen.Name = "hScrollBarGreen";
            this.hScrollBarGreen.Size = new System.Drawing.Size(160, 17);
            this.hScrollBarGreen.TabIndex = 5;
            this.hScrollBarGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarGreen_Scroll);
            this.hScrollBarGreen.ValueChanged += new System.EventHandler(this.hScrollBarGreen_ValueChanged);
            // 
            // numericUpDownRed
            // 
            this.numericUpDownRed.Location = new System.Drawing.Point(308, 41);
            this.numericUpDownRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRed.Name = "numericUpDownRed";
            this.numericUpDownRed.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownRed.TabIndex = 6;
            this.numericUpDownRed.ValueChanged += new System.EventHandler(this.numericUpDownRed_ValueChanged);
            // 
            // numericUpDownGreen
            // 
            this.numericUpDownGreen.Location = new System.Drawing.Point(308, 78);
            this.numericUpDownGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownGreen.Name = "numericUpDownGreen";
            this.numericUpDownGreen.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownGreen.TabIndex = 7;
            this.numericUpDownGreen.ValueChanged += new System.EventHandler(this.numericUpDownGreen_ValueChanged);
            // 
            // numericUpDownBlue
            // 
            this.numericUpDownBlue.Location = new System.Drawing.Point(308, 117);
            this.numericUpDownBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBlue.Name = "numericUpDownBlue";
            this.numericUpDownBlue.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownBlue.TabIndex = 8;
            this.numericUpDownBlue.ValueChanged += new System.EventHandler(this.numericUpDownBlue_ValueChanged);
            // 
            // labelRedColor
            // 
            this.labelRedColor.AutoSize = true;
            this.labelRedColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelRedColor.Location = new System.Drawing.Point(462, 41);
            this.labelRedColor.MinimumSize = new System.Drawing.Size(150, 10);
            this.labelRedColor.Name = "labelRedColor";
            this.labelRedColor.Size = new System.Drawing.Size(150, 15);
            this.labelRedColor.TabIndex = 9;
            // 
            // labelGreenColor
            // 
            this.labelGreenColor.AutoSize = true;
            this.labelGreenColor.Location = new System.Drawing.Point(462, 78);
            this.labelGreenColor.MinimumSize = new System.Drawing.Size(150, 10);
            this.labelGreenColor.Name = "labelGreenColor";
            this.labelGreenColor.Size = new System.Drawing.Size(150, 15);
            this.labelGreenColor.TabIndex = 10;
            // 
            // labelBlueColor
            // 
            this.labelBlueColor.AutoSize = true;
            this.labelBlueColor.Location = new System.Drawing.Point(462, 117);
            this.labelBlueColor.MinimumSize = new System.Drawing.Size(150, 10);
            this.labelBlueColor.Name = "labelBlueColor";
            this.labelBlueColor.Size = new System.Drawing.Size(150, 15);
            this.labelBlueColor.TabIndex = 11;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(104, 171);
            this.labelColor.MinimumSize = new System.Drawing.Size(350, 50);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(350, 50);
            this.labelColor.TabIndex = 12;
            // 
            // ComposantsDeDefilementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 247);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelBlueColor);
            this.Controls.Add(this.labelGreenColor);
            this.Controls.Add(this.labelRedColor);
            this.Controls.Add(this.numericUpDownBlue);
            this.Controls.Add(this.numericUpDownGreen);
            this.Controls.Add(this.numericUpDownRed);
            this.Controls.Add(this.hScrollBarGreen);
            this.Controls.Add(this.hScrollBarBlue);
            this.Controls.Add(this.hScrollBarRed);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelRed);
            this.Name = "ComposantsDeDefilementForm";
            this.Text = "ComposantsDeDefilementForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelRed;
        private Label labelGreen;
        private Label labelBlue;
        private HScrollBar hScrollBarRed;
        private HScrollBar hScrollBarBlue;
        private HScrollBar hScrollBarGreen;
        private NumericUpDown numericUpDownRed;
        private NumericUpDown numericUpDownGreen;
        private NumericUpDown numericUpDownBlue;
        private Label labelRedColor;
        private Label labelGreenColor;
        private Label labelBlueColor;
        private Label labelColor;
    }
}