namespace ECF_SPA
{
    partial class FormChat
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
            this.labelPuce = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelRace = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxPuce = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxRace = new System.Windows.Forms.ComboBox();
            this.buttonModify = new System.Windows.Forms.Button();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPuce
            // 
            this.labelPuce.AutoSize = true;
            this.labelPuce.Location = new System.Drawing.Point(39, 38);
            this.labelPuce.Name = "labelPuce";
            this.labelPuce.Size = new System.Drawing.Size(33, 15);
            this.labelPuce.TabIndex = 0;
            this.labelPuce.Text = "Puce";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(39, 96);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(34, 15);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Nom";
            // 
            // labelRace
            // 
            this.labelRace.AutoSize = true;
            this.labelRace.Location = new System.Drawing.Point(39, 159);
            this.labelRace.Name = "labelRace";
            this.labelRace.Size = new System.Drawing.Size(32, 15);
            this.labelRace.TabIndex = 2;
            this.labelRace.Text = "Race";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(244, 96);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(28, 15);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "Age";
            // 
            // textBoxPuce
            // 
            this.textBoxPuce.Enabled = false;
            this.textBoxPuce.Location = new System.Drawing.Point(103, 35);
            this.textBoxPuce.Name = "textBoxPuce";
            this.textBoxPuce.Size = new System.Drawing.Size(303, 23);
            this.textBoxPuce.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(103, 93);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 23);
            this.textBoxName.TabIndex = 5;
            // 
            // comboBoxRace
            // 
            this.comboBoxRace.FormattingEnabled = true;
            this.comboBoxRace.Location = new System.Drawing.Point(103, 151);
            this.comboBoxRace.Name = "comboBoxRace";
            this.comboBoxRace.Size = new System.Drawing.Size(121, 23);
            this.comboBoxRace.TabIndex = 7;
            // 
            // buttonModify
            // 
            this.buttonModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModify.Location = new System.Drawing.Point(331, 161);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 23);
            this.buttonModify.TabIndex = 8;
            this.buttonModify.Text = "Modifier";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(286, 93);
            this.numericUpDownAge.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownAge.TabIndex = 9;
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 216);
            this.Controls.Add(this.numericUpDownAge);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.comboBoxRace);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPuce);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelRace);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelPuce);
            this.Name = "FormChat";
            this.Text = "ECF_SPA";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelPuce;
        private Label labelName;
        private Label labelRace;
        private Label labelAge;
        private TextBox textBoxPuce;
        private TextBox textBoxName;
        private ComboBox comboBoxRace;
        private Button buttonModify;
        private NumericUpDown numericUpDownAge;
    }
}