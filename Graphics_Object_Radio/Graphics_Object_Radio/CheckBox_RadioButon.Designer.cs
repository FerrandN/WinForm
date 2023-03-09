namespace Graphics_Object_Radio
{
    partial class CheckBox_RadioButon
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
            this.labelChoix = new System.Windows.Forms.Label();
            this.labelTapezVotreTexte = new System.Windows.Forms.Label();
            this.textBoxTypeText = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonMajuscules = new System.Windows.Forms.RadioButton();
            this.radioButtonMinuscules = new System.Windows.Forms.RadioButton();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCasse = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonBleu = new System.Windows.Forms.RadioButton();
            this.radioButtonVert = new System.Windows.Forms.RadioButton();
            this.radioButtonFondRouge = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonNoir = new System.Windows.Forms.RadioButton();
            this.radioButtonBlanc = new System.Windows.Forms.RadioButton();
            this.radioButtonChoixRouge = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxCasse = new System.Windows.Forms.CheckBox();
            this.checkBoxCouleurDesCaracteres = new System.Windows.Forms.CheckBox();
            this.checkBoxCouleurDuFond = new System.Windows.Forms.CheckBox();
            this.labelToCopyTo = new System.Windows.Forms.Label();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelChoix
            // 
            this.labelChoix.AutoSize = true;
            this.labelChoix.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelChoix.Location = new System.Drawing.Point(600, 40);
            this.labelChoix.Name = "labelChoix";
            this.labelChoix.Size = new System.Drawing.Size(38, 15);
            this.labelChoix.TabIndex = 1;
            this.labelChoix.Text = "Choix";
            // 
            // labelTapezVotreTexte
            // 
            this.labelTapezVotreTexte.AutoSize = true;
            this.labelTapezVotreTexte.Location = new System.Drawing.Point(37, 39);
            this.labelTapezVotreTexte.Name = "labelTapezVotreTexte";
            this.labelTapezVotreTexte.Size = new System.Drawing.Size(95, 15);
            this.labelTapezVotreTexte.TabIndex = 2;
            this.labelTapezVotreTexte.Text = "Tapez votre texte";
            // 
            // textBoxTypeText
            // 
            this.textBoxTypeText.Location = new System.Drawing.Point(37, 67);
            this.textBoxTypeText.Name = "textBoxTypeText";
            this.textBoxTypeText.Size = new System.Drawing.Size(318, 23);
            this.textBoxTypeText.TabIndex = 3;
            this.textBoxTypeText.TextChanged += new System.EventHandler(this.textBoxTypeText_TextChanged);
            this.textBoxTypeText.Leave += new System.EventHandler(this.textBoxTextTyped_TextChanged);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel3.Controls.Add(this.radioButtonMajuscules);
            this.flowLayoutPanel3.Controls.Add(this.radioButtonMinuscules);
            this.flowLayoutPanel3.Enabled = false;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(336, 335);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(131, 65);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // radioButtonMajuscules
            // 
            this.radioButtonMajuscules.AutoSize = true;
            this.radioButtonMajuscules.Location = new System.Drawing.Point(3, 43);
            this.radioButtonMajuscules.Name = "radioButtonMajuscules";
            this.radioButtonMajuscules.Size = new System.Drawing.Size(84, 19);
            this.radioButtonMajuscules.TabIndex = 0;
            this.radioButtonMajuscules.TabStop = true;
            this.radioButtonMajuscules.Text = "Majuscules";
            this.radioButtonMajuscules.UseVisualStyleBackColor = true;
            this.radioButtonMajuscules.CheckedChanged += new System.EventHandler(this.radioButtonMajuscules_CheckedChanged);
            // 
            // radioButtonMinuscules
            // 
            this.radioButtonMinuscules.AutoSize = true;
            this.radioButtonMinuscules.Location = new System.Drawing.Point(3, 18);
            this.radioButtonMinuscules.Name = "radioButtonMinuscules";
            this.radioButtonMinuscules.Size = new System.Drawing.Size(85, 19);
            this.radioButtonMinuscules.TabIndex = 1;
            this.radioButtonMinuscules.TabStop = true;
            this.radioButtonMinuscules.Text = "Minuscules";
            this.radioButtonMinuscules.UseVisualStyleBackColor = true;
            this.radioButtonMinuscules.CheckedChanged += new System.EventHandler(this.radioButtonMinuscules_CheckedChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label.Location = new System.Drawing.Point(60, 304);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(34, 15);
            this.label.TabIndex = 7;
            this.label.Text = "Fond";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(206, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Caractères";
            // 
            // labelCasse
            // 
            this.labelCasse.AutoSize = true;
            this.labelCasse.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelCasse.Location = new System.Drawing.Point(355, 327);
            this.labelCasse.Name = "labelCasse";
            this.labelCasse.Size = new System.Drawing.Size(37, 15);
            this.labelCasse.TabIndex = 9;
            this.labelCasse.Text = "Casse";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radioButtonBleu);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonVert);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonFondRouge);
            this.flowLayoutPanel1.Enabled = false;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(37, 312);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(131, 88);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // radioButtonBleu
            // 
            this.radioButtonBleu.AutoSize = true;
            this.radioButtonBleu.Location = new System.Drawing.Point(3, 66);
            this.radioButtonBleu.Name = "radioButtonBleu";
            this.radioButtonBleu.Size = new System.Drawing.Size(48, 19);
            this.radioButtonBleu.TabIndex = 0;
            this.radioButtonBleu.TabStop = true;
            this.radioButtonBleu.Text = "Bleu";
            this.radioButtonBleu.UseVisualStyleBackColor = true;
            this.radioButtonBleu.CheckedChanged += new System.EventHandler(this.radioButtonBleu_CheckedChanged);
            // 
            // radioButtonVert
            // 
            this.radioButtonVert.AutoSize = true;
            this.radioButtonVert.Location = new System.Drawing.Point(3, 41);
            this.radioButtonVert.Name = "radioButtonVert";
            this.radioButtonVert.Size = new System.Drawing.Size(45, 19);
            this.radioButtonVert.TabIndex = 1;
            this.radioButtonVert.TabStop = true;
            this.radioButtonVert.Text = "Vert";
            this.radioButtonVert.UseVisualStyleBackColor = true;
            this.radioButtonVert.CheckedChanged += new System.EventHandler(this.radioButtonVert_CheckedChanged);
            // 
            // radioButtonFondRouge
            // 
            this.radioButtonFondRouge.AutoSize = true;
            this.radioButtonFondRouge.Location = new System.Drawing.Point(3, 16);
            this.radioButtonFondRouge.Name = "radioButtonFondRouge";
            this.radioButtonFondRouge.Size = new System.Drawing.Size(59, 19);
            this.radioButtonFondRouge.TabIndex = 2;
            this.radioButtonFondRouge.TabStop = true;
            this.radioButtonFondRouge.Text = "Rouge";
            this.radioButtonFondRouge.UseVisualStyleBackColor = true;
            this.radioButtonFondRouge.CheckedChanged += new System.EventHandler(this.radioButtonFondRouge_CheckedChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel2.Controls.Add(this.radioButtonNoir);
            this.flowLayoutPanel2.Controls.Add(this.radioButtonBlanc);
            this.flowLayoutPanel2.Controls.Add(this.radioButtonChoixRouge);
            this.flowLayoutPanel2.Enabled = false;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(187, 312);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(131, 88);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // radioButtonNoir
            // 
            this.radioButtonNoir.AutoSize = true;
            this.radioButtonNoir.Location = new System.Drawing.Point(3, 66);
            this.radioButtonNoir.Name = "radioButtonNoir";
            this.radioButtonNoir.Size = new System.Drawing.Size(48, 19);
            this.radioButtonNoir.TabIndex = 3;
            this.radioButtonNoir.TabStop = true;
            this.radioButtonNoir.Text = "Noir";
            this.radioButtonNoir.UseVisualStyleBackColor = true;
            this.radioButtonNoir.CheckedChanged += new System.EventHandler(this.radioButtonNoir_CheckedChanged);
            // 
            // radioButtonBlanc
            // 
            this.radioButtonBlanc.AutoSize = true;
            this.radioButtonBlanc.Location = new System.Drawing.Point(3, 41);
            this.radioButtonBlanc.Name = "radioButtonBlanc";
            this.radioButtonBlanc.Size = new System.Drawing.Size(54, 19);
            this.radioButtonBlanc.TabIndex = 4;
            this.radioButtonBlanc.TabStop = true;
            this.radioButtonBlanc.Text = "Blanc";
            this.radioButtonBlanc.UseVisualStyleBackColor = true;
            this.radioButtonBlanc.CheckedChanged += new System.EventHandler(this.radioButtonBlanc_CheckedChanged);
            // 
            // radioButtonChoixRouge
            // 
            this.radioButtonChoixRouge.AutoSize = true;
            this.radioButtonChoixRouge.Location = new System.Drawing.Point(3, 16);
            this.radioButtonChoixRouge.Name = "radioButtonChoixRouge";
            this.radioButtonChoixRouge.Size = new System.Drawing.Size(59, 19);
            this.radioButtonChoixRouge.TabIndex = 5;
            this.radioButtonChoixRouge.TabStop = true;
            this.radioButtonChoixRouge.Text = "Rouge";
            this.radioButtonChoixRouge.UseVisualStyleBackColor = true;
            this.radioButtonChoixRouge.CheckedChanged += new System.EventHandler(this.radioButtonChoixRouge_CheckedChanged);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.checkBoxCasse);
            this.flowLayoutPanel4.Controls.Add(this.checkBoxCouleurDesCaracteres);
            this.flowLayoutPanel4.Controls.Add(this.checkBoxCouleurDuFond);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(580, 48);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(157, 85);
            this.flowLayoutPanel4.TabIndex = 10;
            // 
            // checkBoxCasse
            // 
            this.checkBoxCasse.AutoSize = true;
            this.checkBoxCasse.Location = new System.Drawing.Point(3, 63);
            this.checkBoxCasse.Name = "checkBoxCasse";
            this.checkBoxCasse.Size = new System.Drawing.Size(56, 19);
            this.checkBoxCasse.TabIndex = 0;
            this.checkBoxCasse.Text = "Casse";
            this.checkBoxCasse.UseVisualStyleBackColor = true;
            this.checkBoxCasse.CheckedChanged += new System.EventHandler(this.checkBoxCasse_CheckedChanged);
            // 
            // checkBoxCouleurDesCaracteres
            // 
            this.checkBoxCouleurDesCaracteres.AutoSize = true;
            this.checkBoxCouleurDesCaracteres.Location = new System.Drawing.Point(3, 38);
            this.checkBoxCouleurDesCaracteres.Name = "checkBoxCouleurDesCaracteres";
            this.checkBoxCouleurDesCaracteres.Size = new System.Drawing.Size(145, 19);
            this.checkBoxCouleurDesCaracteres.TabIndex = 1;
            this.checkBoxCouleurDesCaracteres.Text = "Couleur des caractères";
            this.checkBoxCouleurDesCaracteres.UseVisualStyleBackColor = true;
            this.checkBoxCouleurDesCaracteres.CheckedChanged += new System.EventHandler(this.checkBoxCouleurDesCaractères_CheckedChanged);
            // 
            // checkBoxCouleurDuFond
            // 
            this.checkBoxCouleurDuFond.AutoSize = true;
            this.checkBoxCouleurDuFond.Location = new System.Drawing.Point(3, 13);
            this.checkBoxCouleurDuFond.Name = "checkBoxCouleurDuFond";
            this.checkBoxCouleurDuFond.Size = new System.Drawing.Size(113, 19);
            this.checkBoxCouleurDuFond.TabIndex = 2;
            this.checkBoxCouleurDuFond.Text = "Couleur du fond";
            this.checkBoxCouleurDuFond.UseVisualStyleBackColor = true;
            this.checkBoxCouleurDuFond.CheckedChanged += new System.EventHandler(this.checkBoxCouleurDuFond_CheckedChanged);
            // 
            // labelToCopyTo
            // 
            this.labelToCopyTo.AutoSize = true;
            this.labelToCopyTo.Location = new System.Drawing.Point(40, 118);
            this.labelToCopyTo.MaximumSize = new System.Drawing.Size(250, 150);
            this.labelToCopyTo.Name = "labelToCopyTo";
            this.labelToCopyTo.Size = new System.Drawing.Size(0, 15);
            this.labelToCopyTo.TabIndex = 11;
            // 
            // CheckBox_RadioButon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelToCopyTo);
            this.Controls.Add(this.labelCasse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxTypeText);
            this.Controls.Add(this.labelTapezVotreTexte);
            this.Controls.Add(this.labelChoix);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Name = "CheckBox_RadioButon";
            this.Text = "CheckBox_RadioButon";
            this.Load += new System.EventHandler(this.CheckBox_RadioButon_Load);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelChoix;
        private Label labelTapezVotreTexte;
        private TextBox textBoxTypeText;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label;
        private Label label2;
        private Label labelCasse;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private RadioButton radioButtonMajuscules;
        private RadioButton radioButtonMinuscules;
        private RadioButton radioButtonBleu;
        private RadioButton radioButtonVert;
        private RadioButton radioButtonFondRouge;
        private RadioButton radioButtonNoir;
        private RadioButton radioButtonBlanc;
        private RadioButton radioButtonChoixRouge;
        private FlowLayoutPanel flowLayoutPanel4;
        private CheckBox checkBoxCasse;
        private CheckBox checkBoxCouleurDesCaracteres;
        private CheckBox checkBoxCouleurDuFond;
        private Label labelToCopyTo;
    }
}