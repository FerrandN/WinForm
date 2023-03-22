namespace IdentificationWindow
{
    partial class IdentificationWindow
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
            labelLogin = new Label();
            labelPassWord = new Label();
            textBoxLogin = new TextBox();
            textBoxPassWord = new TextBox();
            buttonClear = new Button();
            buttonOk = new Button();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(49, 39);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(37, 15);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Login";
            // 
            // labelPassWord
            // 
            labelPassWord.AutoSize = true;
            labelPassWord.Location = new Point(49, 89);
            labelPassWord.Name = "labelPassWord";
            labelPassWord.Size = new Size(59, 15);
            labelPassWord.TabIndex = 1;
            labelPassWord.Text = "PassWord";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(118, 36);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(100, 23);
            textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassWord
            // 
            textBoxPassWord.Location = new Point(118, 86);
            textBoxPassWord.Name = "textBoxPassWord";
            textBoxPassWord.Size = new Size(100, 23);
            textBoxPassWord.TabIndex = 3;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(299, 124);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Annuler";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(299, 163);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 5;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // IdentificationWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 200);
            Controls.Add(buttonOk);
            Controls.Add(buttonClear);
            Controls.Add(textBoxPassWord);
            Controls.Add(textBoxLogin);
            Controls.Add(labelPassWord);
            Controls.Add(labelLogin);
            Name = "IdentificationWindow";
            Text = "S'Identifier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private Label labelPassWord;
        private TextBox textBoxLogin;
        private TextBox textBoxPassWord;
        private Button buttonClear;
        private Button buttonOk;
    }
}