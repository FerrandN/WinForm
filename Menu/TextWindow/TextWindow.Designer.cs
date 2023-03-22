namespace TextWindow
{
    partial class TextWindow
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
            labelTextWindowTypeText = new Label();
            buttonTextWindowValidate = new Button();
            textBox = new TextBox();
            SuspendLayout();
            // 
            // labelTextWindowTypeText
            // 
            labelTextWindowTypeText.AutoSize = true;
            labelTextWindowTypeText.Location = new Point(12, 9);
            labelTextWindowTypeText.Name = "labelTextWindowTypeText";
            labelTextWindowTypeText.Size = new Size(96, 15);
            labelTextWindowTypeText.TabIndex = 0;
            labelTextWindowTypeText.Text = "Tapez Votre Texte";
            // 
            // buttonTextWindowValidate
            // 
            buttonTextWindowValidate.Location = new Point(392, 25);
            buttonTextWindowValidate.Name = "buttonTextWindowValidate";
            buttonTextWindowValidate.Size = new Size(75, 23);
            buttonTextWindowValidate.TabIndex = 1;
            buttonTextWindowValidate.Text = "Valider";
            buttonTextWindowValidate.TextAlign = ContentAlignment.MiddleRight;
            buttonTextWindowValidate.UseCompatibleTextRendering = true;
            buttonTextWindowValidate.UseVisualStyleBackColor = true;
            buttonTextWindowValidate.Click += buttonTextWindowValidate_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(12, 27);
            textBox.Name = "textBox";
            textBox.Size = new Size(374, 23);
            textBox.TabIndex = 2;
            // 
            // TextWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 60);
            Controls.Add(textBox);
            Controls.Add(buttonTextWindowValidate);
            Controls.Add(labelTextWindowTypeText);
            Name = "TextWindow";
            Text = "Saisie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTextWindowTypeText;
        private Button buttonTextWindowValidate;
        private TextBox textBox;
    }
}