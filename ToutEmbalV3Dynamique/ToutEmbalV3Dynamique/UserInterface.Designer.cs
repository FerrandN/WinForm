namespace ToutEmbalV3Dynamique
{
    partial class ToutEmbal
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
            this.tabControlProduction = new System.Windows.Forms.TabControl();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demarrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arreterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.continuerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripProduction = new System.Windows.Forms.MenuStrip();
            this.buttonAddTypeA = new System.Windows.Forms.Button();
            this.buttonAddTypeB = new System.Windows.Forms.Button();
            this.buttonAddTypeC = new System.Windows.Forms.Button();
            this.panelDisplayProductionProgressBar = new System.Windows.Forms.Panel();
            this.flowLayoutPanelChangeState = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStripProduction.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlProduction
            // 
            this.tabControlProduction.Location = new System.Drawing.Point(441, 111);
            this.tabControlProduction.Name = "tabControlProduction";
            this.tabControlProduction.SelectedIndex = 0;
            this.tabControlProduction.Size = new System.Drawing.Size(347, 216);
            this.tabControlProduction.TabIndex = 1;
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demarrerToolStripMenuItem,
            this.arreterToolStripMenuItem,
            this.continuerToolStripMenuItem});
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.productionToolStripMenuItem.Text = "Production";
            // 
            // demarrerToolStripMenuItem
            // 
            this.demarrerToolStripMenuItem.Name = "demarrerToolStripMenuItem";
            this.demarrerToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.demarrerToolStripMenuItem.Text = "Démarrer";
            // 
            // arreterToolStripMenuItem
            // 
            this.arreterToolStripMenuItem.Name = "arreterToolStripMenuItem";
            this.arreterToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.arreterToolStripMenuItem.Text = "Arrêter";
            // 
            // continuerToolStripMenuItem
            // 
            this.continuerToolStripMenuItem.Name = "continuerToolStripMenuItem";
            this.continuerToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.continuerToolStripMenuItem.Text = "Continuer";
            // 
            // menuStripProduction
            // 
            this.menuStripProduction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.productionToolStripMenuItem});
            this.menuStripProduction.Location = new System.Drawing.Point(0, 0);
            this.menuStripProduction.Name = "menuStripProduction";
            this.menuStripProduction.Size = new System.Drawing.Size(800, 24);
            this.menuStripProduction.TabIndex = 0;
            this.menuStripProduction.Text = "menuStrip1";
            // 
            // buttonAddTypeA
            // 
            this.buttonAddTypeA.Location = new System.Drawing.Point(12, 113);
            this.buttonAddTypeA.Name = "buttonAddTypeA";
            this.buttonAddTypeA.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTypeA.TabIndex = 2;
            this.buttonAddTypeA.Text = "Type A";
            this.buttonAddTypeA.UseVisualStyleBackColor = true;
            this.buttonAddTypeA.Click += new System.EventHandler(this.buttonAddTypeA_Click);
            // 
            // buttonAddTypeB
            // 
            this.buttonAddTypeB.Location = new System.Drawing.Point(12, 153);
            this.buttonAddTypeB.Name = "buttonAddTypeB";
            this.buttonAddTypeB.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTypeB.TabIndex = 3;
            this.buttonAddTypeB.Text = "Type B";
            this.buttonAddTypeB.UseVisualStyleBackColor = true;
            this.buttonAddTypeB.Click += new System.EventHandler(this.buttonAddTypeB_Click);
            // 
            // buttonAddTypeC
            // 
            this.buttonAddTypeC.Location = new System.Drawing.Point(12, 193);
            this.buttonAddTypeC.Name = "buttonAddTypeC";
            this.buttonAddTypeC.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTypeC.TabIndex = 4;
            this.buttonAddTypeC.Text = "Type C";
            this.buttonAddTypeC.UseVisualStyleBackColor = true;
            this.buttonAddTypeC.Click += new System.EventHandler(this.buttonAddTypeC_Click);
            // 
            // panelDisplayProductionProgressBar
            // 
            this.panelDisplayProductionProgressBar.AutoScroll = true;
            this.panelDisplayProductionProgressBar.BackColor = System.Drawing.SystemColors.Control;
            this.panelDisplayProductionProgressBar.Location = new System.Drawing.Point(0, 350);
            this.panelDisplayProductionProgressBar.Name = "panelDisplayProductionProgressBar";
            this.panelDisplayProductionProgressBar.Size = new System.Drawing.Size(800, 100);
            this.panelDisplayProductionProgressBar.TabIndex = 7;
            // 
            // flowLayoutPanelChangeState
            // 
            this.flowLayoutPanelChangeState.Location = new System.Drawing.Point(12, 27);
            this.flowLayoutPanelChangeState.Name = "flowLayoutPanelChangeState";
            this.flowLayoutPanelChangeState.Size = new System.Drawing.Size(776, 80);
            this.flowLayoutPanelChangeState.TabIndex = 8;
            // 
            // ToutEmbal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanelChangeState);
            this.Controls.Add(this.panelDisplayProductionProgressBar);
            this.Controls.Add(this.buttonAddTypeC);
            this.Controls.Add(this.buttonAddTypeB);
            this.Controls.Add(this.buttonAddTypeA);
            this.Controls.Add(this.tabControlProduction);
            this.Controls.Add(this.menuStripProduction);
            this.Name = "ToutEmbal";
            this.Text = "ToutEmbal";
            this.menuStripProduction.ResumeLayout(false);
            this.menuStripProduction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControlProduction;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem productionToolStripMenuItem;
        private ToolStripMenuItem demarrerToolStripMenuItem;
        private ToolStripMenuItem arreterToolStripMenuItem;
        private ToolStripMenuItem continuerToolStripMenuItem;
        private MenuStrip menuStripProduction;
        private Button buttonAddTypeA;
        private Button buttonAddTypeB;
        private Button buttonAddTypeC;
        private Panel panelDisplayProductionProgressBar;
        private FlowLayoutPanel flowLayoutPanelChangeState;
    }
}