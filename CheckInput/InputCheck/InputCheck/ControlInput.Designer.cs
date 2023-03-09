namespace InputCheck
{
    partial class ControlInput
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
            this.labelNom = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelMontant = new System.Windows.Forms.Label();
            this.labelCodePostale = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxMontant = new System.Windows.Forms.TextBox();
            this.textBoxCodePostale = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonEffacer = new System.Windows.Forms.Button();
            this.labelInfoDateExample = new System.Windows.Forms.Label();
            this.textBoxDateTime = new System.Windows.Forms.TextBox();
            this.errorProviderTextBoxName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTextBoxDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTextBoxMontant = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCodePostale = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTextBoxName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTextBoxDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTextBoxMontant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodePostale)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(75, 75);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(34, 15);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(75, 125);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(31, 15);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date";
            // 
            // labelMontant
            // 
            this.labelMontant.AutoSize = true;
            this.labelMontant.Location = new System.Drawing.Point(75, 175);
            this.labelMontant.Name = "labelMontant";
            this.labelMontant.Size = new System.Drawing.Size(53, 15);
            this.labelMontant.TabIndex = 2;
            this.labelMontant.Text = "Montant";
            // 
            // labelCodePostale
            // 
            this.labelCodePostale.AutoSize = true;
            this.labelCodePostale.Location = new System.Drawing.Point(75, 225);
            this.labelCodePostale.Name = "labelCodePostale";
            this.labelCodePostale.Size = new System.Drawing.Size(76, 15);
            this.labelCodePostale.TabIndex = 3;
            this.labelCodePostale.Text = "Code Postale";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(229, 72);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(205, 23);
            this.textBoxNom.TabIndex = 1;
            this.textBoxNom.TextChanged += new System.EventHandler(this.TextBoxNom_TextChanged);
            this.textBoxNom.Leave += new System.EventHandler(this.TextBoxNom_TextChanged);
            // 
            // textBoxMontant
            // 
            this.textBoxMontant.Location = new System.Drawing.Point(229, 172);
            this.textBoxMontant.Name = "textBoxMontant";
            this.textBoxMontant.Size = new System.Drawing.Size(205, 23);
            this.textBoxMontant.TabIndex = 3;
            this.textBoxMontant.TextChanged += new System.EventHandler(this.TextBoxMontant_TextChanged);
            this.textBoxMontant.Leave += new System.EventHandler(this.TextBoxMontant_TextChanged);
            // 
            // textBoxCodePostale
            // 
            this.textBoxCodePostale.Location = new System.Drawing.Point(229, 222);
            this.textBoxCodePostale.Name = "textBoxCodePostale";
            this.textBoxCodePostale.Size = new System.Drawing.Size(205, 23);
            this.textBoxCodePostale.TabIndex = 4;
            this.textBoxCodePostale.TextChanged += new System.EventHandler(this.TextBoxCodePostale_TextChanged);
            this.textBoxCodePostale.Leave += new System.EventHandler(this.TextBoxCodePostale_TextChanged);
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(713, 415);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 8;
            this.buttonValider.TabStop = false;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonEffacer
            // 
            this.buttonEffacer.Location = new System.Drawing.Point(613, 415);
            this.buttonEffacer.Name = "buttonEffacer";
            this.buttonEffacer.Size = new System.Drawing.Size(75, 23);
            this.buttonEffacer.TabIndex = 9;
            this.buttonEffacer.Text = "Effacer";
            this.buttonEffacer.UseVisualStyleBackColor = true;
            this.buttonEffacer.Click += new System.EventHandler(this.ClearAllText);
            // 
            // labelInfoDateExample
            // 
            this.labelInfoDateExample.AutoSize = true;
            this.labelInfoDateExample.Location = new System.Drawing.Point(464, 125);
            this.labelInfoDateExample.Name = "labelInfoDateExample";
            this.labelInfoDateExample.Size = new System.Drawing.Size(142, 15);
            this.labelInfoDateExample.TabIndex = 11;
            this.labelInfoDateExample.Text = "Example: JJ / MM / AAAA";
            // 
            // textBoxDateTime
            // 
            this.textBoxDateTime.Location = new System.Drawing.Point(229, 122);
            this.textBoxDateTime.Name = "textBoxDateTime";
            this.textBoxDateTime.Size = new System.Drawing.Size(205, 23);
            this.textBoxDateTime.TabIndex = 2;
            this.textBoxDateTime.TextChanged += new System.EventHandler(this.TextBoxDate_TextChanged);
            // 
            // errorProviderTextBoxName
            // 
            this.errorProviderTextBoxName.ContainerControl = this;
            // 
            // errorProviderTextBoxDate
            // 
            this.errorProviderTextBoxDate.ContainerControl = this;
            // 
            // errorProviderTextBoxMontant
            // 
            this.errorProviderTextBoxMontant.ContainerControl = this;
            // 
            // errorProviderCodePostale
            // 
            this.errorProviderCodePostale.ContainerControl = this;
            // 
            // ControlInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxDateTime);
            this.Controls.Add(this.labelInfoDateExample);
            this.Controls.Add(this.buttonEffacer);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBoxCodePostale);
            this.Controls.Add(this.textBoxMontant);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelCodePostale);
            this.Controls.Add(this.labelMontant);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelNom);
            this.Name = "ControlInput";
            this.Text = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseApp);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTextBoxName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTextBoxDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTextBoxMontant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodePostale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNom;
        private Label labelDate;
        private Label labelMontant;
        private Label labelCodePostale;
        private TextBox textBoxNom;
        private TextBox textBoxMontant;
        private TextBox textBoxCodePostale;
        private Button buttonValider;
        private Button buttonEffacer;
        private Label labelInfoDateExample;
        private TextBox textBoxDateTime;
        private ErrorProvider errorProviderTextBoxName;
        private ErrorProvider errorProviderTextBoxDate;
        private ErrorProvider errorProviderTextBoxMontant;
        private ErrorProvider errorProviderCodePostale;
    }
}