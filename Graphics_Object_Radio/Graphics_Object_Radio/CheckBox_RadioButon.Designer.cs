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
            labelChoix = new Label();
            labelTapezVotreTexte = new Label();
            textBoxTypeText = new TextBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            radioButtonMajuscules = new RadioButton();
            radioButtonMinuscules = new RadioButton();
            label = new Label();
            label2 = new Label();
            labelCasse = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            radioButtonBleu = new RadioButton();
            radioButtonVert = new RadioButton();
            radioButtonFondRouge = new RadioButton();
            flowLayoutPanel2 = new FlowLayoutPanel();
            radioButtonNoir = new RadioButton();
            radioButtonBlanc = new RadioButton();
            radioButtonChoixRouge = new RadioButton();
            flowLayoutPanel4 = new FlowLayoutPanel();
            checkBoxCasse = new CheckBox();
            checkBoxCouleurDesCaracteres = new CheckBox();
            checkBoxCouleurDuFond = new CheckBox();
            labelToCopyTo = new Label();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // labelChoix
            // 
            labelChoix.AutoSize = true;
            labelChoix.ForeColor = Color.CornflowerBlue;
            labelChoix.Location = new Point(600, 40);
            labelChoix.Name = "labelChoix";
            labelChoix.Size = new Size(38, 15);
            labelChoix.TabIndex = 1;
            labelChoix.Text = "Choix";
            // 
            // labelTapezVotreTexte
            // 
            labelTapezVotreTexte.AutoSize = true;
            labelTapezVotreTexte.Location = new Point(37, 39);
            labelTapezVotreTexte.Name = "labelTapezVotreTexte";
            labelTapezVotreTexte.Size = new Size(95, 15);
            labelTapezVotreTexte.TabIndex = 2;
            labelTapezVotreTexte.Text = "Tapez votre texte";
            // 
            // textBoxTypeText
            // 
            textBoxTypeText.Location = new Point(37, 67);
            textBoxTypeText.Name = "textBoxTypeText";
            textBoxTypeText.Size = new Size(318, 23);
            textBoxTypeText.TabIndex = 3;
            textBoxTypeText.TextChanged += textBoxTypeText_TextChanged;
            textBoxTypeText.Leave += textBoxTextTyped_TextChanged;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel3.Controls.Add(radioButtonMajuscules);
            flowLayoutPanel3.Controls.Add(radioButtonMinuscules);
            flowLayoutPanel3.Enabled = false;
            flowLayoutPanel3.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel3.Location = new Point(336, 335);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(131, 65);
            flowLayoutPanel3.TabIndex = 6;
            // 
            // radioButtonMajuscules
            // 
            radioButtonMajuscules.AutoSize = true;
            radioButtonMajuscules.Location = new Point(3, 43);
            radioButtonMajuscules.Name = "radioButtonMajuscules";
            radioButtonMajuscules.Size = new Size(84, 19);
            radioButtonMajuscules.TabIndex = 0;
            radioButtonMajuscules.TabStop = true;
            radioButtonMajuscules.Text = "Majuscules";
            radioButtonMajuscules.UseVisualStyleBackColor = true;
            radioButtonMajuscules.CheckedChanged += radioButtonMajuscules_CheckedChanged;
            // 
            // radioButtonMinuscules
            // 
            radioButtonMinuscules.AutoSize = true;
            radioButtonMinuscules.Location = new Point(3, 18);
            radioButtonMinuscules.Name = "radioButtonMinuscules";
            radioButtonMinuscules.Size = new Size(85, 19);
            radioButtonMinuscules.TabIndex = 1;
            radioButtonMinuscules.TabStop = true;
            radioButtonMinuscules.Text = "Minuscules";
            radioButtonMinuscules.UseVisualStyleBackColor = true;
            radioButtonMinuscules.CheckedChanged += radioButtonMinuscules_CheckedChanged;
            // 
            // label
            // 
            label.AutoSize = true;
            label.ForeColor = Color.CornflowerBlue;
            label.Location = new Point(60, 304);
            label.Name = "label";
            label.Size = new Size(34, 15);
            label.TabIndex = 7;
            label.Text = "Fond";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(206, 304);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 8;
            label2.Text = "Caractères";
            // 
            // labelCasse
            // 
            labelCasse.AutoSize = true;
            labelCasse.ForeColor = Color.CornflowerBlue;
            labelCasse.Location = new Point(355, 327);
            labelCasse.Name = "labelCasse";
            labelCasse.Size = new Size(37, 15);
            labelCasse.TabIndex = 9;
            labelCasse.Text = "Casse";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(radioButtonBleu);
            flowLayoutPanel1.Controls.Add(radioButtonVert);
            flowLayoutPanel1.Controls.Add(radioButtonFondRouge);
            flowLayoutPanel1.Enabled = false;
            flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel1.Location = new Point(37, 312);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(131, 88);
            flowLayoutPanel1.TabIndex = 5;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // radioButtonBleu
            // 
            radioButtonBleu.AutoSize = true;
            radioButtonBleu.Location = new Point(3, 66);
            radioButtonBleu.Name = "radioButtonBleu";
            radioButtonBleu.Size = new Size(48, 19);
            radioButtonBleu.TabIndex = 0;
            radioButtonBleu.TabStop = true;
            radioButtonBleu.Text = "Bleu";
            radioButtonBleu.UseVisualStyleBackColor = true;
            radioButtonBleu.CheckedChanged += radioButtonBleu_CheckedChanged;
            // 
            // radioButtonVert
            // 
            radioButtonVert.AutoSize = true;
            radioButtonVert.Location = new Point(3, 41);
            radioButtonVert.Name = "radioButtonVert";
            radioButtonVert.Size = new Size(45, 19);
            radioButtonVert.TabIndex = 1;
            radioButtonVert.TabStop = true;
            radioButtonVert.Text = "Vert";
            radioButtonVert.UseVisualStyleBackColor = true;
            radioButtonVert.CheckedChanged += radioButtonVert_CheckedChanged;
            // 
            // radioButtonFondRouge
            // 
            radioButtonFondRouge.AutoSize = true;
            radioButtonFondRouge.Location = new Point(3, 16);
            radioButtonFondRouge.Name = "radioButtonFondRouge";
            radioButtonFondRouge.Size = new Size(59, 19);
            radioButtonFondRouge.TabIndex = 2;
            radioButtonFondRouge.TabStop = true;
            radioButtonFondRouge.Text = "Rouge";
            radioButtonFondRouge.UseVisualStyleBackColor = true;
            radioButtonFondRouge.CheckedChanged += radioButtonFondRouge_CheckedChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel2.Controls.Add(radioButtonNoir);
            flowLayoutPanel2.Controls.Add(radioButtonBlanc);
            flowLayoutPanel2.Controls.Add(radioButtonChoixRouge);
            flowLayoutPanel2.Enabled = false;
            flowLayoutPanel2.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel2.Location = new Point(187, 312);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(131, 88);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // radioButtonNoir
            // 
            radioButtonNoir.AutoSize = true;
            radioButtonNoir.Location = new Point(3, 66);
            radioButtonNoir.Name = "radioButtonNoir";
            radioButtonNoir.Size = new Size(48, 19);
            radioButtonNoir.TabIndex = 3;
            radioButtonNoir.TabStop = true;
            radioButtonNoir.Text = "Noir";
            radioButtonNoir.UseVisualStyleBackColor = true;
            radioButtonNoir.CheckedChanged += radioButtonNoir_CheckedChanged;
            // 
            // radioButtonBlanc
            // 
            radioButtonBlanc.AutoSize = true;
            radioButtonBlanc.Location = new Point(3, 41);
            radioButtonBlanc.Name = "radioButtonBlanc";
            radioButtonBlanc.Size = new Size(54, 19);
            radioButtonBlanc.TabIndex = 4;
            radioButtonBlanc.TabStop = true;
            radioButtonBlanc.Text = "Blanc";
            radioButtonBlanc.UseVisualStyleBackColor = true;
            radioButtonBlanc.CheckedChanged += radioButtonBlanc_CheckedChanged;
            // 
            // radioButtonChoixRouge
            // 
            radioButtonChoixRouge.AutoSize = true;
            radioButtonChoixRouge.Location = new Point(3, 16);
            radioButtonChoixRouge.Name = "radioButtonChoixRouge";
            radioButtonChoixRouge.Size = new Size(59, 19);
            radioButtonChoixRouge.TabIndex = 5;
            radioButtonChoixRouge.TabStop = true;
            radioButtonChoixRouge.Text = "Rouge";
            radioButtonChoixRouge.UseVisualStyleBackColor = true;
            radioButtonChoixRouge.CheckedChanged += radioButtonChoixRouge_CheckedChanged;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(checkBoxCasse);
            flowLayoutPanel4.Controls.Add(checkBoxCouleurDesCaracteres);
            flowLayoutPanel4.Controls.Add(checkBoxCouleurDuFond);
            flowLayoutPanel4.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel4.Location = new Point(580, 48);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(157, 85);
            flowLayoutPanel4.TabIndex = 10;
            // 
            // checkBoxCasse
            // 
            checkBoxCasse.AutoSize = true;
            checkBoxCasse.Location = new Point(3, 63);
            checkBoxCasse.Name = "checkBoxCasse";
            checkBoxCasse.Size = new Size(56, 19);
            checkBoxCasse.TabIndex = 0;
            checkBoxCasse.Text = "Casse";
            checkBoxCasse.UseVisualStyleBackColor = true;
            checkBoxCasse.CheckedChanged += checkBoxCasse_CheckedChanged;
            // 
            // checkBoxCouleurDesCaracteres
            // 
            checkBoxCouleurDesCaracteres.AutoSize = true;
            checkBoxCouleurDesCaracteres.Location = new Point(3, 38);
            checkBoxCouleurDesCaracteres.Name = "checkBoxCouleurDesCaracteres";
            checkBoxCouleurDesCaracteres.Size = new Size(145, 19);
            checkBoxCouleurDesCaracteres.TabIndex = 1;
            checkBoxCouleurDesCaracteres.Text = "Couleur des caractères";
            checkBoxCouleurDesCaracteres.UseVisualStyleBackColor = true;
            checkBoxCouleurDesCaracteres.CheckedChanged += checkBoxCouleurDesCaractères_CheckedChanged;
            // 
            // checkBoxCouleurDuFond
            // 
            checkBoxCouleurDuFond.AutoSize = true;
            checkBoxCouleurDuFond.Location = new Point(3, 13);
            checkBoxCouleurDuFond.Name = "checkBoxCouleurDuFond";
            checkBoxCouleurDuFond.Size = new Size(113, 19);
            checkBoxCouleurDuFond.TabIndex = 2;
            checkBoxCouleurDuFond.Text = "Couleur du fond";
            checkBoxCouleurDuFond.UseVisualStyleBackColor = true;
            checkBoxCouleurDuFond.CheckedChanged += checkBoxCouleurDuFond_CheckedChanged;
            // 
            // labelToCopyTo
            // 
            labelToCopyTo.AutoSize = true;
            labelToCopyTo.Location = new Point(40, 118);
            labelToCopyTo.MaximumSize = new Size(250, 150);
            labelToCopyTo.Name = "labelToCopyTo";
            labelToCopyTo.Size = new Size(0, 15);
            labelToCopyTo.TabIndex = 11;
            // 
            // CheckBox_RadioButon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelToCopyTo);
            Controls.Add(labelCasse);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(label);
            Controls.Add(textBoxTypeText);
            Controls.Add(labelTapezVotreTexte);
            Controls.Add(labelChoix);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel4);
            Name = "CheckBox_RadioButon";
            Text = "CheckBox_RadioButon";
            Load += CheckBox_RadioButon_Load;
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelChoix;
        private Label labelTapezVotreTexte;
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
        public TextBox textBoxTypeText;
    }
}