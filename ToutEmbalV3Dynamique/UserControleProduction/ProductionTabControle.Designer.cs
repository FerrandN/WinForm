namespace UserControleProduction
{
    partial class ProductionTabControle
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCrateProduced = new System.Windows.Forms.Label();
            this.textBoxCrateProduced = new System.Windows.Forms.TextBox();
            this.textBoxDefectivePerhour = new System.Windows.Forms.TextBox();
            this.labelDefectivePerHour = new System.Windows.Forms.Label();
            this.textBoxDefectiveTotal = new System.Windows.Forms.TextBox();
            this.labelTotalDefective = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCrateProduced
            // 
            this.labelCrateProduced.AutoSize = true;
            this.labelCrateProduced.Location = new System.Drawing.Point(9, 19);
            this.labelCrateProduced.Name = "labelCrateProduced";
            this.labelCrateProduced.Size = new System.Drawing.Size(211, 15);
            this.labelCrateProduced.TabIndex = 0;
            this.labelCrateProduced.Text = "Nombre de caisse depuis le démarrage";
            // 
            // textBoxCrateProduced
            // 
            this.textBoxCrateProduced.Location = new System.Drawing.Point(225, 16);
            this.textBoxCrateProduced.Name = "textBoxCrateProduced";
            this.textBoxCrateProduced.Size = new System.Drawing.Size(100, 23);
            this.textBoxCrateProduced.TabIndex = 1;
            // 
            // textBoxDefectivePerhour
            // 
            this.textBoxDefectivePerhour.Location = new System.Drawing.Point(225, 61);
            this.textBoxDefectivePerhour.Name = "textBoxDefectivePerhour";
            this.textBoxDefectivePerhour.Size = new System.Drawing.Size(100, 23);
            this.textBoxDefectivePerhour.TabIndex = 3;
            // 
            // labelDefectivePerHour
            // 
            this.labelDefectivePerHour.AutoSize = true;
            this.labelDefectivePerHour.Location = new System.Drawing.Point(9, 65);
            this.labelDefectivePerHour.Name = "labelDefectivePerHour";
            this.labelDefectivePerHour.Size = new System.Drawing.Size(102, 15);
            this.labelDefectivePerHour.TabIndex = 2;
            this.labelDefectivePerHour.Text = "Taux Défaut heure";
            // 
            // textBoxDefectiveTotal
            // 
            this.textBoxDefectiveTotal.Location = new System.Drawing.Point(225, 112);
            this.textBoxDefectiveTotal.Name = "textBoxDefectiveTotal";
            this.textBoxDefectiveTotal.Size = new System.Drawing.Size(100, 23);
            this.textBoxDefectiveTotal.TabIndex = 5;
            // 
            // labelTotalDefective
            // 
            this.labelTotalDefective.AutoSize = true;
            this.labelTotalDefective.Location = new System.Drawing.Point(9, 114);
            this.labelTotalDefective.Name = "labelTotalDefective";
            this.labelTotalDefective.Size = new System.Drawing.Size(178, 15);
            this.labelTotalDefective.TabIndex = 4;
            this.labelTotalDefective.Text = "Taux défaut depuis le démarrage";
            // 
            // ProductionTabControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxDefectiveTotal);
            this.Controls.Add(this.labelTotalDefective);
            this.Controls.Add(this.textBoxDefectivePerhour);
            this.Controls.Add(this.labelDefectivePerHour);
            this.Controls.Add(this.textBoxCrateProduced);
            this.Controls.Add(this.labelCrateProduced);
            this.Name = "ProductionTabControle";
            this.Size = new System.Drawing.Size(332, 154);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelCrateProduced;
        private TextBox textBoxCrateProduced;
        private TextBox textBoxDefectivePerhour;
        private Label labelDefectivePerHour;
        private TextBox textBoxDefectiveTotal;
        private Label labelTotalDefective;
    }
}
