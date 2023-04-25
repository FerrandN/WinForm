namespace TrainingVSCodeDB
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSup = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.textBoxDevelopperName = new System.Windows.Forms.TextBox();
            this.labelGameName = new System.Windows.Forms.Label();
            this.labelGameType = new System.Windows.Forms.Label();
            this.textBoxTypeName = new System.Windows.Forms.TextBox();
            this.labelDevelopperName = new System.Windows.Forms.Label();
            this.textBoxGameName = new System.Windows.Forms.TextBox();
            this.labelGameToChange = new System.Windows.Forms.Label();
            this.textBoxGameToChange = new System.Windows.Forms.TextBox();
            this.comboBoxDevelloperName = new System.Windows.Forms.ComboBox();
            this.comboBoxGameType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(35, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(446, 405);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(498, 24);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSup
            // 
            this.buttonSup.Enabled = false;
            this.buttonSup.Location = new System.Drawing.Point(498, 282);
            this.buttonSup.Name = "buttonSup";
            this.buttonSup.Size = new System.Drawing.Size(75, 23);
            this.buttonSup.TabIndex = 2;
            this.buttonSup.Text = "Sup";
            this.buttonSup.UseVisualStyleBackColor = true;
            this.buttonSup.Click += new System.EventHandler(this.buttonSup_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Enabled = false;
            this.buttonChange.Location = new System.Drawing.Point(618, 282);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 3;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // textBoxDevelopperName
            // 
            this.textBoxDevelopperName.Location = new System.Drawing.Point(618, 115);
            this.textBoxDevelopperName.Name = "textBoxDevelopperName";
            this.textBoxDevelopperName.Size = new System.Drawing.Size(172, 23);
            this.textBoxDevelopperName.TabIndex = 5;
            this.textBoxDevelopperName.TextChanged += new System.EventHandler(this.ChangeButtonState);
            // 
            // labelGameName
            // 
            this.labelGameName.AutoSize = true;
            this.labelGameName.Location = new System.Drawing.Point(498, 65);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(70, 15);
            this.labelGameName.TabIndex = 6;
            this.labelGameName.Text = "GameName";
            // 
            // labelGameType
            // 
            this.labelGameType.AutoSize = true;
            this.labelGameType.Location = new System.Drawing.Point(498, 179);
            this.labelGameType.Name = "labelGameType";
            this.labelGameType.Size = new System.Drawing.Size(62, 15);
            this.labelGameType.TabIndex = 7;
            this.labelGameType.Text = "GameType";
            // 
            // textBoxTypeName
            // 
            this.textBoxTypeName.Location = new System.Drawing.Point(618, 179);
            this.textBoxTypeName.Name = "textBoxTypeName";
            this.textBoxTypeName.Size = new System.Drawing.Size(172, 23);
            this.textBoxTypeName.TabIndex = 8;
            this.textBoxTypeName.TextChanged += new System.EventHandler(this.ChangeButtonState);
            // 
            // labelDevelopperName
            // 
            this.labelDevelopperName.AutoSize = true;
            this.labelDevelopperName.Location = new System.Drawing.Point(498, 118);
            this.labelDevelopperName.Name = "labelDevelopperName";
            this.labelDevelopperName.Size = new System.Drawing.Size(99, 15);
            this.labelDevelopperName.TabIndex = 9;
            this.labelDevelopperName.Text = "DevelopperName";
            // 
            // textBoxGameName
            // 
            this.textBoxGameName.Location = new System.Drawing.Point(618, 62);
            this.textBoxGameName.Name = "textBoxGameName";
            this.textBoxGameName.Size = new System.Drawing.Size(172, 23);
            this.textBoxGameName.TabIndex = 10;
            this.textBoxGameName.TextChanged += new System.EventHandler(this.ChangeButtonState);
            // 
            // labelGameToChange
            // 
            this.labelGameToChange.AutoSize = true;
            this.labelGameToChange.Location = new System.Drawing.Point(498, 246);
            this.labelGameToChange.Name = "labelGameToChange";
            this.labelGameToChange.Size = new System.Drawing.Size(94, 15);
            this.labelGameToChange.TabIndex = 11;
            this.labelGameToChange.Text = "GameNewName";
            // 
            // textBoxGameToChange
            // 
            this.textBoxGameToChange.Location = new System.Drawing.Point(618, 243);
            this.textBoxGameToChange.Name = "textBoxGameToChange";
            this.textBoxGameToChange.Size = new System.Drawing.Size(172, 23);
            this.textBoxGameToChange.TabIndex = 12;
            this.textBoxGameToChange.TextChanged += new System.EventHandler(this.ChangeButtonState);
            // 
            // comboBoxDevelloperName
            // 
            this.comboBoxDevelloperName.FormattingEnabled = true;
            this.comboBoxDevelloperName.Location = new System.Drawing.Point(618, 144);
            this.comboBoxDevelloperName.Name = "comboBoxDevelloperName";
            this.comboBoxDevelloperName.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDevelloperName.TabIndex = 13;
            // 
            // comboBoxGameType
            // 
            this.comboBoxGameType.FormattingEnabled = true;
            this.comboBoxGameType.Location = new System.Drawing.Point(618, 208);
            this.comboBoxGameType.Name = "comboBoxGameType";
            this.comboBoxGameType.Size = new System.Drawing.Size(121, 23);
            this.comboBoxGameType.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxGameType);
            this.Controls.Add(this.comboBoxDevelloperName);
            this.Controls.Add(this.textBoxGameToChange);
            this.Controls.Add(this.labelGameToChange);
            this.Controls.Add(this.textBoxGameName);
            this.Controls.Add(this.labelDevelopperName);
            this.Controls.Add(this.textBoxTypeName);
            this.Controls.Add(this.labelGameType);
            this.Controls.Add(this.labelGameName);
            this.Controls.Add(this.textBoxDevelopperName);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonSup);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonAdd;
        private Button buttonSup;
        private Button buttonChange;
        private TextBox textBoxDevelopperName;
        private Label labelGameName;
        private Label labelGameType;
        private TextBox textBoxTypeName;
        private Label labelDevelopperName;
        private TextBox textBoxGameName;
        private Label labelGameToChange;
        private TextBox textBoxGameToChange;
        private ComboBox comboBoxDevelloperName;
        private ComboBox comboBoxGameType;
    }
}