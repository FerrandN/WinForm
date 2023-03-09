namespace InputCheck
{
    partial class ValidationWindow
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
            this.labelNom = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelMontant = new System.Windows.Forms.Label();
            this.labelCodePostale = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(37, 23);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(43, 15);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom : ";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(37, 73);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(40, 15);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date : ";
            // 
            // labelMontant
            // 
            this.labelMontant.AutoSize = true;
            this.labelMontant.Location = new System.Drawing.Point(37, 123);
            this.labelMontant.Name = "labelMontant";
            this.labelMontant.Size = new System.Drawing.Size(62, 15);
            this.labelMontant.TabIndex = 2;
            this.labelMontant.Text = "Montant : ";
            // 
            // labelCodePostale
            // 
            this.labelCodePostale.AutoSize = true;
            this.labelCodePostale.Location = new System.Drawing.Point(37, 173);
            this.labelCodePostale.Name = "labelCodePostale";
            this.labelCodePostale.Size = new System.Drawing.Size(85, 15);
            this.labelCodePostale.TabIndex = 3;
            this.labelCodePostale.Text = "Code Postale : ";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(103, 260);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // ValidationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 295);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelCodePostale);
            this.Controls.Add(this.labelMontant);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelNom);
            this.Name = "ValidationWindow";
            this.Text = "ValidationWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNom;
        private Label labelDate;
        private Label labelMontant;
        private Label labelCodePostale;
        private Button buttonOK;
    }
}