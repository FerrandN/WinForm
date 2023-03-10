namespace ListBoxOperation
{
    partial class ListBoxOperation
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
            this.components = new System.ComponentModel.Container();
            this.labelNouvelElement = new System.Windows.Forms.Label();
            this.labelIndexElement = new System.Windows.Forms.Label();
            this.labelLstListe = new System.Windows.Forms.Label();
            this.labelProprietes = new System.Windows.Forms.Label();
            this.labelItemsCount = new System.Windows.Forms.Label();
            this.labelSelectedIndex = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonAjoutListe = new System.Windows.Forms.Button();
            this.buttonViderlaListe = new System.Windows.Forms.Button();
            this.buttonSelectionner = new System.Windows.Forms.Button();
            this.textBoxNouvelElement = new System.Windows.Forms.TextBox();
            this.textBoxItemsCount = new System.Windows.Forms.TextBox();
            this.textBoxSelectedIndex = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.textBoxIndexElement = new System.Windows.Forms.TextBox();
            this.listBoxLstListe = new System.Windows.Forms.ListBox();
            this.IndexElementDigitError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IndexElementDigitError)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNouvelElement
            // 
            this.labelNouvelElement.AutoSize = true;
            this.labelNouvelElement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNouvelElement.Location = new System.Drawing.Point(27, 29);
            this.labelNouvelElement.Name = "labelNouvelElement";
            this.labelNouvelElement.Size = new System.Drawing.Size(96, 15);
            this.labelNouvelElement.TabIndex = 0;
            this.labelNouvelElement.Text = "Nouvel Elément";
            // 
            // labelIndexElement
            // 
            this.labelIndexElement.AutoSize = true;
            this.labelIndexElement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIndexElement.Location = new System.Drawing.Point(197, 29);
            this.labelIndexElement.Name = "labelIndexElement";
            this.labelIndexElement.Size = new System.Drawing.Size(88, 15);
            this.labelIndexElement.TabIndex = 1;
            this.labelIndexElement.Text = "Index Elément";
            // 
            // labelLstListe
            // 
            this.labelLstListe.AutoSize = true;
            this.labelLstListe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLstListe.Location = new System.Drawing.Point(27, 173);
            this.labelLstListe.Name = "labelLstListe";
            this.labelLstListe.Size = new System.Drawing.Size(49, 15);
            this.labelLstListe.TabIndex = 2;
            this.labelLstListe.Text = "LstListe";
            // 
            // labelProprietes
            // 
            this.labelProprietes.AutoSize = true;
            this.labelProprietes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProprietes.Location = new System.Drawing.Point(197, 173);
            this.labelProprietes.Name = "labelProprietes";
            this.labelProprietes.Size = new System.Drawing.Size(65, 15);
            this.labelProprietes.TabIndex = 3;
            this.labelProprietes.Text = "Propriétés";
            // 
            // labelItemsCount
            // 
            this.labelItemsCount.AutoSize = true;
            this.labelItemsCount.Location = new System.Drawing.Point(197, 207);
            this.labelItemsCount.Name = "labelItemsCount";
            this.labelItemsCount.Size = new System.Drawing.Size(72, 15);
            this.labelItemsCount.TabIndex = 4;
            this.labelItemsCount.Text = "Items.Count";
            // 
            // labelSelectedIndex
            // 
            this.labelSelectedIndex.AutoSize = true;
            this.labelSelectedIndex.Location = new System.Drawing.Point(197, 256);
            this.labelSelectedIndex.Name = "labelSelectedIndex";
            this.labelSelectedIndex.Size = new System.Drawing.Size(80, 15);
            this.labelSelectedIndex.TabIndex = 5;
            this.labelSelectedIndex.Text = "SelectedIndex";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(197, 301);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(28, 15);
            this.labelText.TabIndex = 6;
            this.labelText.Text = "Text";
            // 
            // buttonAjoutListe
            // 
            this.buttonAjoutListe.Location = new System.Drawing.Point(27, 87);
            this.buttonAjoutListe.Name = "buttonAjoutListe";
            this.buttonAjoutListe.Size = new System.Drawing.Size(100, 23);
            this.buttonAjoutListe.TabIndex = 3;
            this.buttonAjoutListe.Text = "Ajout Liste";
            this.buttonAjoutListe.UseVisualStyleBackColor = true;
            this.buttonAjoutListe.Click += new System.EventHandler(this.buttonAjoutListe_Click);
            // 
            // buttonViderlaListe
            // 
            this.buttonViderlaListe.Location = new System.Drawing.Point(303, 87);
            this.buttonViderlaListe.Name = "buttonViderlaListe";
            this.buttonViderlaListe.Size = new System.Drawing.Size(94, 23);
            this.buttonViderlaListe.TabIndex = 5;
            this.buttonViderlaListe.Text = "Vider la Liste";
            this.buttonViderlaListe.UseVisualStyleBackColor = true;
            this.buttonViderlaListe.Click += new System.EventHandler(this.buttonViderlaListe_Click);
            // 
            // buttonSelectionner
            // 
            this.buttonSelectionner.Location = new System.Drawing.Point(303, 58);
            this.buttonSelectionner.Name = "buttonSelectionner";
            this.buttonSelectionner.Size = new System.Drawing.Size(94, 23);
            this.buttonSelectionner.TabIndex = 4;
            this.buttonSelectionner.Text = "Sélectionner";
            this.buttonSelectionner.UseVisualStyleBackColor = true;
            this.buttonSelectionner.Click += new System.EventHandler(this.buttonSelectionner_Click);
            // 
            // textBoxNouvelElement
            // 
            this.textBoxNouvelElement.Location = new System.Drawing.Point(27, 58);
            this.textBoxNouvelElement.Name = "textBoxNouvelElement";
            this.textBoxNouvelElement.Size = new System.Drawing.Size(100, 23);
            this.textBoxNouvelElement.TabIndex = 1;
            this.textBoxNouvelElement.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNouvelElement_KeyDown);
            // 
            // textBoxItemsCount
            // 
            this.textBoxItemsCount.Location = new System.Drawing.Point(297, 204);
            this.textBoxItemsCount.Name = "textBoxItemsCount";
            this.textBoxItemsCount.ReadOnly = true;
            this.textBoxItemsCount.Size = new System.Drawing.Size(100, 23);
            this.textBoxItemsCount.TabIndex = 11;
            this.textBoxItemsCount.TabStop = false;
            // 
            // textBoxSelectedIndex
            // 
            this.textBoxSelectedIndex.Location = new System.Drawing.Point(297, 253);
            this.textBoxSelectedIndex.Name = "textBoxSelectedIndex";
            this.textBoxSelectedIndex.ReadOnly = true;
            this.textBoxSelectedIndex.Size = new System.Drawing.Size(100, 23);
            this.textBoxSelectedIndex.TabIndex = 12;
            this.textBoxSelectedIndex.TabStop = false;
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(297, 298);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.ReadOnly = true;
            this.textBoxText.Size = new System.Drawing.Size(100, 23);
            this.textBoxText.TabIndex = 13;
            this.textBoxText.TabStop = false;
            // 
            // textBoxIndexElement
            // 
            this.textBoxIndexElement.Location = new System.Drawing.Point(197, 58);
            this.textBoxIndexElement.Name = "textBoxIndexElement";
            this.textBoxIndexElement.Size = new System.Drawing.Size(88, 23);
            this.textBoxIndexElement.TabIndex = 2;
            this.textBoxIndexElement.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxIndexElement_KeyDown);
            // 
            // listBoxLstListe
            // 
            this.listBoxLstListe.FormattingEnabled = true;
            this.listBoxLstListe.ItemHeight = 15;
            this.listBoxLstListe.Location = new System.Drawing.Point(27, 204);
            this.listBoxLstListe.Name = "listBoxLstListe";
            this.listBoxLstListe.Size = new System.Drawing.Size(120, 124);
            this.listBoxLstListe.TabIndex = 6;
            this.listBoxLstListe.SelectedIndexChanged += new System.EventHandler(this.listBoxLstListe_SelectedIndexChanged);
            // 
            // IndexElementDigitError
            // 
            this.IndexElementDigitError.ContainerControl = this;
            // 
            // ListBoxOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxLstListe);
            this.Controls.Add(this.textBoxIndexElement);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.textBoxSelectedIndex);
            this.Controls.Add(this.textBoxItemsCount);
            this.Controls.Add(this.textBoxNouvelElement);
            this.Controls.Add(this.buttonSelectionner);
            this.Controls.Add(this.buttonViderlaListe);
            this.Controls.Add(this.buttonAjoutListe);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelSelectedIndex);
            this.Controls.Add(this.labelItemsCount);
            this.Controls.Add(this.labelProprietes);
            this.Controls.Add(this.labelLstListe);
            this.Controls.Add(this.labelIndexElement);
            this.Controls.Add(this.labelNouvelElement);
            this.Name = "ListBoxOperation";
            this.Text = "ListBoxOperation";
            ((System.ComponentModel.ISupportInitialize)(this.IndexElementDigitError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNouvelElement;
        private Label labelIndexElement;
        private Label labelLstListe;
        private Label labelProprietes;
        private Label labelItemsCount;
        private Label labelSelectedIndex;
        private Label labelText;
        private Button buttonAjoutListe;
        private Button buttonViderlaListe;
        private Button buttonSelectionner;
        private TextBox textBoxNouvelElement;
        private TextBox textBoxItemsCount;
        private TextBox textBoxSelectedIndex;
        private TextBox textBoxText;
        private TextBox textBoxIndexElement;
        private ListBox listBoxLstListe;
        private ErrorProvider IndexElementDigitError;
    }
}