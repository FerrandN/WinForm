namespace ListBoxEtComboBox
{
    partial class ListBoxComboBox
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxCountries = new System.Windows.Forms.ComboBox();
            this.labelSource = new System.Windows.Forms.Label();
            this.buttonToRight = new System.Windows.Forms.Button();
            this.buttonAllToRight = new System.Windows.Forms.Button();
            this.buttonToLeft = new System.Windows.Forms.Button();
            this.buttonAllToLeft = new System.Windows.Forms.Button();
            this.buttonNextUp = new System.Windows.Forms.Button();
            this.buttonNextDown = new System.Windows.Forms.Button();
            this.labelCible = new System.Windows.Forms.Label();
            this.listBoxSelectedCountries = new System.Windows.Forms.ListBox();
            this.errorProviderBadStringFormat = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBadStringFormat)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCountries
            // 
            this.comboBoxCountries.FormattingEnabled = true;
            this.comboBoxCountries.Location = new System.Drawing.Point(12, 53);
            this.comboBoxCountries.Name = "comboBoxCountries";
            this.comboBoxCountries.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCountries.TabIndex = 0;
            this.comboBoxCountries.DropDown += new System.EventHandler(this.comboBoxCountries_DropDown);
            this.comboBoxCountries.TextChanged += new System.EventHandler(this.comboBoxCountries_TextChanged);
            this.comboBoxCountries.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxCountries_KeyDown);
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(35, 24);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(43, 15);
            this.labelSource.TabIndex = 1;
            this.labelSource.Text = "Source";
            // 
            // buttonToRight
            // 
            this.buttonToRight.Enabled = false;
            this.buttonToRight.Location = new System.Drawing.Point(147, 52);
            this.buttonToRight.Name = "buttonToRight";
            this.buttonToRight.Size = new System.Drawing.Size(75, 23);
            this.buttonToRight.TabIndex = 2;
            this.buttonToRight.Text = ">";
            this.buttonToRight.UseVisualStyleBackColor = true;
            this.buttonToRight.Click += new System.EventHandler(this.buttonToRight_Click);
            // 
            // buttonAllToRight
            // 
            this.buttonAllToRight.Location = new System.Drawing.Point(147, 81);
            this.buttonAllToRight.Name = "buttonAllToRight";
            this.buttonAllToRight.Size = new System.Drawing.Size(75, 23);
            this.buttonAllToRight.TabIndex = 3;
            this.buttonAllToRight.Text = ">>";
            this.buttonAllToRight.UseVisualStyleBackColor = true;
            this.buttonAllToRight.Click += new System.EventHandler(this.buttonAllToRight_Click);
            // 
            // buttonToLeft
            // 
            this.buttonToLeft.Enabled = false;
            this.buttonToLeft.Location = new System.Drawing.Point(147, 213);
            this.buttonToLeft.Name = "buttonToLeft";
            this.buttonToLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonToLeft.TabIndex = 4;
            this.buttonToLeft.Text = "<";
            this.buttonToLeft.UseVisualStyleBackColor = true;
            this.buttonToLeft.Click += new System.EventHandler(this.buttonToLeft_Click);
            // 
            // buttonAllToLeft
            // 
            this.buttonAllToLeft.Enabled = false;
            this.buttonAllToLeft.Location = new System.Drawing.Point(147, 242);
            this.buttonAllToLeft.Name = "buttonAllToLeft";
            this.buttonAllToLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonAllToLeft.TabIndex = 5;
            this.buttonAllToLeft.Text = "<<";
            this.buttonAllToLeft.UseVisualStyleBackColor = true;
            this.buttonAllToLeft.Click += new System.EventHandler(this.buttonAllToLeft_Click);
            // 
            // buttonNextUp
            // 
            this.buttonNextUp.Enabled = false;
            this.buttonNextUp.Location = new System.Drawing.Point(238, 299);
            this.buttonNextUp.Name = "buttonNextUp";
            this.buttonNextUp.Size = new System.Drawing.Size(37, 23);
            this.buttonNextUp.TabIndex = 6;
            this.buttonNextUp.Text = "↑";
            this.buttonNextUp.UseVisualStyleBackColor = true;
            this.buttonNextUp.Click += new System.EventHandler(this.buttonNextUp_Click);
            // 
            // buttonNextDown
            // 
            this.buttonNextDown.Enabled = false;
            this.buttonNextDown.Location = new System.Drawing.Point(292, 299);
            this.buttonNextDown.Name = "buttonNextDown";
            this.buttonNextDown.Size = new System.Drawing.Size(37, 23);
            this.buttonNextDown.TabIndex = 7;
            this.buttonNextDown.Text = "↓";
            this.buttonNextDown.UseVisualStyleBackColor = true;
            this.buttonNextDown.Click += new System.EventHandler(this.buttonNextDown_Click);
            // 
            // labelCible
            // 
            this.labelCible.AutoSize = true;
            this.labelCible.Location = new System.Drawing.Point(238, 17);
            this.labelCible.Name = "labelCible";
            this.labelCible.Size = new System.Drawing.Size(34, 15);
            this.labelCible.TabIndex = 8;
            this.labelCible.Text = "Cible";
            // 
            // listBoxSelectedCountries
            // 
            this.listBoxSelectedCountries.FormattingEnabled = true;
            this.listBoxSelectedCountries.ItemHeight = 15;
            this.listBoxSelectedCountries.Location = new System.Drawing.Point(238, 53);
            this.listBoxSelectedCountries.Name = "listBoxSelectedCountries";
            this.listBoxSelectedCountries.Size = new System.Drawing.Size(218, 214);
            this.listBoxSelectedCountries.TabIndex = 9;
            this.listBoxSelectedCountries.SelectedIndexChanged += new System.EventHandler(this.listBoxSelectedCountries_SelectedIndexChanged);
            this.listBoxSelectedCountries.SelectedValueChanged += new System.EventHandler(this.listBoxSelectedCountries_SelectedValueChanged);
            // 
            // errorProviderBadStringFormat
            // 
            this.errorProviderBadStringFormat.ContainerControl = this;
            // 
            // ListBoxComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 359);
            this.Controls.Add(this.listBoxSelectedCountries);
            this.Controls.Add(this.labelCible);
            this.Controls.Add(this.buttonNextDown);
            this.Controls.Add(this.buttonNextUp);
            this.Controls.Add(this.buttonAllToLeft);
            this.Controls.Add(this.buttonToLeft);
            this.Controls.Add(this.buttonAllToRight);
            this.Controls.Add(this.buttonToRight);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.comboBoxCountries);
            this.Name = "ListBoxComboBox";
            this.Text = "ListBoxComboBox";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBadStringFormat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxCountries;
        private Label labelSource;
        private Button buttonToRight;
        private Button buttonAllToRight;
        private Button buttonToLeft;
        private Button buttonAllToLeft;
        private Button buttonNextUp;
        private Button buttonNextDown;
        private Label labelCible;
        private ListBox listBoxSelectedCountries;
        private ErrorProvider errorProviderBadStringFormat;
    }
}