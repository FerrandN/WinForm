namespace ToutEmbal
{
    partial class FormToutEmbal
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
            this.tabControlType = new System.Windows.Forms.TabControl();
            this.tabPageTypeA = new System.Windows.Forms.TabPage();
            this.textBoxTypeADefectiveTotal = new System.Windows.Forms.TextBox();
            this.textBoxTypeADefectivePerHour = new System.Windows.Forms.TextBox();
            this.textBoxTypeANbCrate = new System.Windows.Forms.TextBox();
            this.labelTypeANbDefectiveTotal = new System.Windows.Forms.Label();
            this.labelTypeANbDefectivePerHour = new System.Windows.Forms.Label();
            this.labelTypeANbCrate = new System.Windows.Forms.Label();
            this.tabPageTypeB = new System.Windows.Forms.TabPage();
            this.textBoxTypeBDefectiveTotal = new System.Windows.Forms.TextBox();
            this.labelTypeBNbDefectiveTotal = new System.Windows.Forms.Label();
            this.textBoxTypeBDefectivePerHour = new System.Windows.Forms.TextBox();
            this.labelTypeBNbDefectivePerHour = new System.Windows.Forms.Label();
            this.textBoxTypeBNbCrate = new System.Windows.Forms.TextBox();
            this.labelTypeBNbCrate = new System.Windows.Forms.Label();
            this.tabPageTypeC = new System.Windows.Forms.TabPage();
            this.textBoxTypeCDefectiveTotal = new System.Windows.Forms.TextBox();
            this.labelTypeCNbDefectiveTotal = new System.Windows.Forms.Label();
            this.textBoxTypeCDefectivePerHour = new System.Windows.Forms.TextBox();
            this.labelTypeCNbDefectivePerHour = new System.Windows.Forms.Label();
            this.textBoxTypeCNbCrate = new System.Windows.Forms.TextBox();
            this.labelTypeCNbCrate = new System.Windows.Forms.Label();
            this.labelProductionA = new System.Windows.Forms.Label();
            this.labelProductionB = new System.Windows.Forms.Label();
            this.labelProductionC = new System.Windows.Forms.Label();
            this.progressBarTypeA = new System.Windows.Forms.ProgressBar();
            this.progressBarTypeB = new System.Windows.Forms.ProgressBar();
            this.progressBarTypeC = new System.Windows.Forms.ProgressBar();
            this.toolStripMenuItemFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemProduction = new System.Windows.Forms.ToolStripMenuItem();
            this.demarrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_demarrer_a = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_demarrer_b = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_demarrer_c = new System.Windows.Forms.ToolStripMenuItem();
            this.arreterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_arreter_a = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_arreter_b = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_arreter_c = new System.Windows.Forms.ToolStripMenuItem();
            this.continuerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_continuer_a = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_continuer_b = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_continuer_c = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.timerProduction = new System.Windows.Forms.Timer(this.components);
            this.tabControlType.SuspendLayout();
            this.tabPageTypeA.SuspendLayout();
            this.tabPageTypeB.SuspendLayout();
            this.tabPageTypeC.SuspendLayout();
            this.menuStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlType
            // 
            this.tabControlType.Controls.Add(this.tabPageTypeA);
            this.tabControlType.Controls.Add(this.tabPageTypeB);
            this.tabControlType.Controls.Add(this.tabPageTypeC);
            this.tabControlType.Location = new System.Drawing.Point(233, 54);
            this.tabControlType.Name = "tabControlType";
            this.tabControlType.SelectedIndex = 0;
            this.tabControlType.Size = new System.Drawing.Size(486, 203);
            this.tabControlType.TabIndex = 1;
            // 
            // tabPageTypeA
            // 
            this.tabPageTypeA.Controls.Add(this.textBoxTypeADefectiveTotal);
            this.tabPageTypeA.Controls.Add(this.textBoxTypeADefectivePerHour);
            this.tabPageTypeA.Controls.Add(this.textBoxTypeANbCrate);
            this.tabPageTypeA.Controls.Add(this.labelTypeANbDefectiveTotal);
            this.tabPageTypeA.Controls.Add(this.labelTypeANbDefectivePerHour);
            this.tabPageTypeA.Controls.Add(this.labelTypeANbCrate);
            this.tabPageTypeA.Location = new System.Drawing.Point(4, 24);
            this.tabPageTypeA.Name = "tabPageTypeA";
            this.tabPageTypeA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTypeA.Size = new System.Drawing.Size(478, 175);
            this.tabPageTypeA.TabIndex = 0;
            this.tabPageTypeA.Text = "TypeA";
            this.tabPageTypeA.UseVisualStyleBackColor = true;
            // 
            // textBoxTypeADefectiveTotal
            // 
            this.textBoxTypeADefectiveTotal.Enabled = false;
            this.textBoxTypeADefectiveTotal.Location = new System.Drawing.Point(320, 119);
            this.textBoxTypeADefectiveTotal.Name = "textBoxTypeADefectiveTotal";
            this.textBoxTypeADefectiveTotal.Size = new System.Drawing.Size(100, 23);
            this.textBoxTypeADefectiveTotal.TabIndex = 5;
            // 
            // textBoxTypeADefectivePerHour
            // 
            this.textBoxTypeADefectivePerHour.Enabled = false;
            this.textBoxTypeADefectivePerHour.Location = new System.Drawing.Point(320, 76);
            this.textBoxTypeADefectivePerHour.Name = "textBoxTypeADefectivePerHour";
            this.textBoxTypeADefectivePerHour.Size = new System.Drawing.Size(100, 23);
            this.textBoxTypeADefectivePerHour.TabIndex = 4;
            // 
            // textBoxTypeANbCrate
            // 
            this.textBoxTypeANbCrate.Enabled = false;
            this.textBoxTypeANbCrate.Location = new System.Drawing.Point(320, 34);
            this.textBoxTypeANbCrate.Name = "textBoxTypeANbCrate";
            this.textBoxTypeANbCrate.Size = new System.Drawing.Size(100, 23);
            this.textBoxTypeANbCrate.TabIndex = 3;
            // 
            // labelTypeANbDefectiveTotal
            // 
            this.labelTypeANbDefectiveTotal.AutoSize = true;
            this.labelTypeANbDefectiveTotal.Location = new System.Drawing.Point(20, 122);
            this.labelTypeANbDefectiveTotal.Name = "labelTypeANbDefectiveTotal";
            this.labelTypeANbDefectiveTotal.Size = new System.Drawing.Size(166, 15);
            this.labelTypeANbDefectiveTotal.TabIndex = 2;
            this.labelTypeANbDefectiveTotal.Text = "Taux défaut depuis démarrage";
            // 
            // labelTypeANbDefectivePerHour
            // 
            this.labelTypeANbDefectivePerHour.AutoSize = true;
            this.labelTypeANbDefectivePerHour.Location = new System.Drawing.Point(20, 79);
            this.labelTypeANbDefectivePerHour.Name = "labelTypeANbDefectivePerHour";
            this.labelTypeANbDefectivePerHour.Size = new System.Drawing.Size(102, 15);
            this.labelTypeANbDefectivePerHour.TabIndex = 1;
            this.labelTypeANbDefectivePerHour.Text = "Taux Défaut heure";
            // 
            // labelTypeANbCrate
            // 
            this.labelTypeANbCrate.AutoSize = true;
            this.labelTypeANbCrate.Location = new System.Drawing.Point(20, 37);
            this.labelTypeANbCrate.Name = "labelTypeANbCrate";
            this.labelTypeANbCrate.Size = new System.Drawing.Size(212, 15);
            this.labelTypeANbCrate.TabIndex = 0;
            this.labelTypeANbCrate.Text = "Nombre de caisses depuis le démarage";
            // 
            // tabPageTypeB
            // 
            this.tabPageTypeB.Controls.Add(this.textBoxTypeBDefectiveTotal);
            this.tabPageTypeB.Controls.Add(this.labelTypeBNbDefectiveTotal);
            this.tabPageTypeB.Controls.Add(this.textBoxTypeBDefectivePerHour);
            this.tabPageTypeB.Controls.Add(this.labelTypeBNbDefectivePerHour);
            this.tabPageTypeB.Controls.Add(this.textBoxTypeBNbCrate);
            this.tabPageTypeB.Controls.Add(this.labelTypeBNbCrate);
            this.tabPageTypeB.Location = new System.Drawing.Point(4, 24);
            this.tabPageTypeB.Name = "tabPageTypeB";
            this.tabPageTypeB.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTypeB.Size = new System.Drawing.Size(478, 175);
            this.tabPageTypeB.TabIndex = 1;
            this.tabPageTypeB.Text = "TypeB";
            this.tabPageTypeB.UseVisualStyleBackColor = true;
            // 
            // textBoxTypeBDefectiveTotal
            // 
            this.textBoxTypeBDefectiveTotal.Enabled = false;
            this.textBoxTypeBDefectiveTotal.Location = new System.Drawing.Point(320, 119);
            this.textBoxTypeBDefectiveTotal.Name = "textBoxTypeBDefectiveTotal";
            this.textBoxTypeBDefectiveTotal.Size = new System.Drawing.Size(100, 23);
            this.textBoxTypeBDefectiveTotal.TabIndex = 10;
            // 
            // labelTypeBNbDefectiveTotal
            // 
            this.labelTypeBNbDefectiveTotal.AutoSize = true;
            this.labelTypeBNbDefectiveTotal.Location = new System.Drawing.Point(20, 122);
            this.labelTypeBNbDefectiveTotal.Name = "labelTypeBNbDefectiveTotal";
            this.labelTypeBNbDefectiveTotal.Size = new System.Drawing.Size(166, 15);
            this.labelTypeBNbDefectiveTotal.TabIndex = 5;
            this.labelTypeBNbDefectiveTotal.Text = "Taux défaut depuis démarrage";
            // 
            // textBoxTypeBDefectivePerHour
            // 
            this.textBoxTypeBDefectivePerHour.Enabled = false;
            this.textBoxTypeBDefectivePerHour.Location = new System.Drawing.Point(320, 76);
            this.textBoxTypeBDefectivePerHour.Name = "textBoxTypeBDefectivePerHour";
            this.textBoxTypeBDefectivePerHour.Size = new System.Drawing.Size(100, 23);
            this.textBoxTypeBDefectivePerHour.TabIndex = 9;
            // 
            // labelTypeBNbDefectivePerHour
            // 
            this.labelTypeBNbDefectivePerHour.AutoSize = true;
            this.labelTypeBNbDefectivePerHour.Location = new System.Drawing.Point(20, 79);
            this.labelTypeBNbDefectivePerHour.Name = "labelTypeBNbDefectivePerHour";
            this.labelTypeBNbDefectivePerHour.Size = new System.Drawing.Size(102, 15);
            this.labelTypeBNbDefectivePerHour.TabIndex = 4;
            this.labelTypeBNbDefectivePerHour.Text = "Taux Défaut heure";
            // 
            // textBoxTypeBNbCrate
            // 
            this.textBoxTypeBNbCrate.Enabled = false;
            this.textBoxTypeBNbCrate.Location = new System.Drawing.Point(320, 34);
            this.textBoxTypeBNbCrate.Name = "textBoxTypeBNbCrate";
            this.textBoxTypeBNbCrate.Size = new System.Drawing.Size(100, 23);
            this.textBoxTypeBNbCrate.TabIndex = 8;
            // 
            // labelTypeBNbCrate
            // 
            this.labelTypeBNbCrate.AutoSize = true;
            this.labelTypeBNbCrate.Location = new System.Drawing.Point(20, 37);
            this.labelTypeBNbCrate.Name = "labelTypeBNbCrate";
            this.labelTypeBNbCrate.Size = new System.Drawing.Size(212, 15);
            this.labelTypeBNbCrate.TabIndex = 3;
            this.labelTypeBNbCrate.Text = "Nombre de caisses depuis le démarage";
            // 
            // tabPageTypeC
            // 
            this.tabPageTypeC.Controls.Add(this.textBoxTypeCDefectiveTotal);
            this.tabPageTypeC.Controls.Add(this.labelTypeCNbDefectiveTotal);
            this.tabPageTypeC.Controls.Add(this.textBoxTypeCDefectivePerHour);
            this.tabPageTypeC.Controls.Add(this.labelTypeCNbDefectivePerHour);
            this.tabPageTypeC.Controls.Add(this.textBoxTypeCNbCrate);
            this.tabPageTypeC.Controls.Add(this.labelTypeCNbCrate);
            this.tabPageTypeC.Location = new System.Drawing.Point(4, 24);
            this.tabPageTypeC.Name = "tabPageTypeC";
            this.tabPageTypeC.Size = new System.Drawing.Size(478, 175);
            this.tabPageTypeC.TabIndex = 2;
            this.tabPageTypeC.Text = "TypeC";
            this.tabPageTypeC.UseVisualStyleBackColor = true;
            // 
            // textBoxTypeCDefectiveTotal
            // 
            this.textBoxTypeCDefectiveTotal.Enabled = false;
            this.textBoxTypeCDefectiveTotal.Location = new System.Drawing.Point(320, 119);
            this.textBoxTypeCDefectiveTotal.Name = "textBoxTypeCDefectiveTotal";
            this.textBoxTypeCDefectiveTotal.Size = new System.Drawing.Size(100, 23);
            this.textBoxTypeCDefectiveTotal.TabIndex = 13;
            // 
            // labelTypeCNbDefectiveTotal
            // 
            this.labelTypeCNbDefectiveTotal.AutoSize = true;
            this.labelTypeCNbDefectiveTotal.Location = new System.Drawing.Point(20, 122);
            this.labelTypeCNbDefectiveTotal.Name = "labelTypeCNbDefectiveTotal";
            this.labelTypeCNbDefectiveTotal.Size = new System.Drawing.Size(166, 15);
            this.labelTypeCNbDefectiveTotal.TabIndex = 8;
            this.labelTypeCNbDefectiveTotal.Text = "Taux défaut depuis démarrage";
            // 
            // textBoxTypeCDefectivePerHour
            // 
            this.textBoxTypeCDefectivePerHour.Enabled = false;
            this.textBoxTypeCDefectivePerHour.Location = new System.Drawing.Point(320, 76);
            this.textBoxTypeCDefectivePerHour.Name = "textBoxTypeCDefectivePerHour";
            this.textBoxTypeCDefectivePerHour.Size = new System.Drawing.Size(100, 23);
            this.textBoxTypeCDefectivePerHour.TabIndex = 12;
            // 
            // labelTypeCNbDefectivePerHour
            // 
            this.labelTypeCNbDefectivePerHour.AutoSize = true;
            this.labelTypeCNbDefectivePerHour.Location = new System.Drawing.Point(20, 79);
            this.labelTypeCNbDefectivePerHour.Name = "labelTypeCNbDefectivePerHour";
            this.labelTypeCNbDefectivePerHour.Size = new System.Drawing.Size(102, 15);
            this.labelTypeCNbDefectivePerHour.TabIndex = 7;
            this.labelTypeCNbDefectivePerHour.Text = "Taux Défaut heure";
            // 
            // textBoxTypeCNbCrate
            // 
            this.textBoxTypeCNbCrate.Enabled = false;
            this.textBoxTypeCNbCrate.Location = new System.Drawing.Point(320, 34);
            this.textBoxTypeCNbCrate.Name = "textBoxTypeCNbCrate";
            this.textBoxTypeCNbCrate.Size = new System.Drawing.Size(100, 23);
            this.textBoxTypeCNbCrate.TabIndex = 11;
            // 
            // labelTypeCNbCrate
            // 
            this.labelTypeCNbCrate.AutoSize = true;
            this.labelTypeCNbCrate.Location = new System.Drawing.Point(20, 37);
            this.labelTypeCNbCrate.Name = "labelTypeCNbCrate";
            this.labelTypeCNbCrate.Size = new System.Drawing.Size(212, 15);
            this.labelTypeCNbCrate.TabIndex = 6;
            this.labelTypeCNbCrate.Text = "Nombre de caisses depuis le démarage";
            // 
            // labelProductionA
            // 
            this.labelProductionA.AutoSize = true;
            this.labelProductionA.Location = new System.Drawing.Point(57, 338);
            this.labelProductionA.Name = "labelProductionA";
            this.labelProductionA.Size = new System.Drawing.Size(77, 15);
            this.labelProductionA.TabIndex = 2;
            this.labelProductionA.Text = "Production A";
            // 
            // labelProductionB
            // 
            this.labelProductionB.AutoSize = true;
            this.labelProductionB.Location = new System.Drawing.Point(57, 365);
            this.labelProductionB.Name = "labelProductionB";
            this.labelProductionB.Size = new System.Drawing.Size(76, 15);
            this.labelProductionB.TabIndex = 3;
            this.labelProductionB.Text = "Production B";
            // 
            // labelProductionC
            // 
            this.labelProductionC.AutoSize = true;
            this.labelProductionC.Location = new System.Drawing.Point(57, 392);
            this.labelProductionC.Name = "labelProductionC";
            this.labelProductionC.Size = new System.Drawing.Size(77, 15);
            this.labelProductionC.TabIndex = 4;
            this.labelProductionC.Text = "Production C";
            // 
            // progressBarTypeA
            // 
            this.progressBarTypeA.Location = new System.Drawing.Point(233, 334);
            this.progressBarTypeA.Name = "progressBarTypeA";
            this.progressBarTypeA.Size = new System.Drawing.Size(482, 23);
            this.progressBarTypeA.Step = 1;
            this.progressBarTypeA.TabIndex = 5;
            // 
            // progressBarTypeB
            // 
            this.progressBarTypeB.Location = new System.Drawing.Point(233, 363);
            this.progressBarTypeB.Name = "progressBarTypeB";
            this.progressBarTypeB.Size = new System.Drawing.Size(482, 23);
            this.progressBarTypeB.TabIndex = 6;
            // 
            // progressBarTypeC
            // 
            this.progressBarTypeC.Location = new System.Drawing.Point(233, 392);
            this.progressBarTypeC.Name = "progressBarTypeC";
            this.progressBarTypeC.Size = new System.Drawing.Size(482, 23);
            this.progressBarTypeC.TabIndex = 7;
            // 
            // toolStripMenuItemFichier
            // 
            this.toolStripMenuItemFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.toolStripMenuItemFichier.Name = "toolStripMenuItemFichier";
            this.toolStripMenuItemFichier.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItemFichier.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // toolStripMenuItemProduction
            // 
            this.toolStripMenuItemProduction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demarrerToolStripMenuItem,
            this.arreterToolStripMenuItem,
            this.continuerToolStripMenuItem});
            this.toolStripMenuItemProduction.Name = "toolStripMenuItemProduction";
            this.toolStripMenuItemProduction.Size = new System.Drawing.Size(78, 20);
            this.toolStripMenuItemProduction.Text = "Production";
            // 
            // demarrerToolStripMenuItem
            // 
            this.demarrerToolStripMenuItem.AutoToolTip = true;
            this.demarrerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip_demarrer_a,
            this.toolstrip_demarrer_b,
            this.toolstrip_demarrer_c});
            this.demarrerToolStripMenuItem.Name = "demarrerToolStripMenuItem";
            this.demarrerToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.demarrerToolStripMenuItem.Text = "Démarrer";
            // 
            // toolstrip_demarrer_a
            // 
            this.toolstrip_demarrer_a.Name = "toolstrip_demarrer_a";
            this.toolstrip_demarrer_a.Size = new System.Drawing.Size(82, 22);
            this.toolstrip_demarrer_a.Text = "A";
            this.toolstrip_demarrer_a.Click += new System.EventHandler(this.toolstrip_demarrer_a_Click);
            // 
            // toolstrip_demarrer_b
            // 
            this.toolstrip_demarrer_b.AutoToolTip = true;
            this.toolstrip_demarrer_b.Name = "toolstrip_demarrer_b";
            this.toolstrip_demarrer_b.Size = new System.Drawing.Size(82, 22);
            this.toolstrip_demarrer_b.Text = "B";
            this.toolstrip_demarrer_b.Click += new System.EventHandler(this.toolstrip_demarrer_b_Click);
            // 
            // toolstrip_demarrer_c
            // 
            this.toolstrip_demarrer_c.AutoToolTip = true;
            this.toolstrip_demarrer_c.Name = "toolstrip_demarrer_c";
            this.toolstrip_demarrer_c.Size = new System.Drawing.Size(82, 22);
            this.toolstrip_demarrer_c.Text = "C";
            this.toolstrip_demarrer_c.Click += new System.EventHandler(this.toolstrip_demarrer_c_Click);
            // 
            // arreterToolStripMenuItem
            // 
            this.arreterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip_arreter_a,
            this.toolstrip_arreter_b,
            this.toolstrip_arreter_c});
            this.arreterToolStripMenuItem.Name = "arreterToolStripMenuItem";
            this.arreterToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.arreterToolStripMenuItem.Text = "Arrêter";
            // 
            // toolstrip_arreter_a
            // 
            this.toolstrip_arreter_a.Enabled = false;
            this.toolstrip_arreter_a.Name = "toolstrip_arreter_a";
            this.toolstrip_arreter_a.Size = new System.Drawing.Size(82, 22);
            this.toolstrip_arreter_a.Text = "A";
            this.toolstrip_arreter_a.Click += new System.EventHandler(this.toolstrip_arreter_a_Click);
            // 
            // toolstrip_arreter_b
            // 
            this.toolstrip_arreter_b.Enabled = false;
            this.toolstrip_arreter_b.Name = "toolstrip_arreter_b";
            this.toolstrip_arreter_b.Size = new System.Drawing.Size(82, 22);
            this.toolstrip_arreter_b.Text = "B";
            this.toolstrip_arreter_b.Click += new System.EventHandler(this.toolstrip_arreter_b_Click);
            // 
            // toolstrip_arreter_c
            // 
            this.toolstrip_arreter_c.Enabled = false;
            this.toolstrip_arreter_c.Name = "toolstrip_arreter_c";
            this.toolstrip_arreter_c.Size = new System.Drawing.Size(82, 22);
            this.toolstrip_arreter_c.Text = "C";
            this.toolstrip_arreter_c.Click += new System.EventHandler(this.toolstrip_arreter_c_Click);
            // 
            // continuerToolStripMenuItem
            // 
            this.continuerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip_continuer_a,
            this.toolstrip_continuer_b,
            this.toolstrip_continuer_c});
            this.continuerToolStripMenuItem.Name = "continuerToolStripMenuItem";
            this.continuerToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.continuerToolStripMenuItem.Text = "Continuer";
            // 
            // toolstrip_continuer_a
            // 
            this.toolstrip_continuer_a.Enabled = false;
            this.toolstrip_continuer_a.Name = "toolstrip_continuer_a";
            this.toolstrip_continuer_a.Size = new System.Drawing.Size(82, 22);
            this.toolstrip_continuer_a.Text = "A";
            this.toolstrip_continuer_a.Click += new System.EventHandler(this.toolstrip_continuer_a_Click);
            // 
            // toolstrip_continuer_b
            // 
            this.toolstrip_continuer_b.Enabled = false;
            this.toolstrip_continuer_b.Name = "toolstrip_continuer_b";
            this.toolstrip_continuer_b.Size = new System.Drawing.Size(82, 22);
            this.toolstrip_continuer_b.Text = "B";
            this.toolstrip_continuer_b.Click += new System.EventHandler(this.toolstrip_continuer_b_Click);
            // 
            // toolstrip_continuer_c
            // 
            this.toolstrip_continuer_c.Enabled = false;
            this.toolstrip_continuer_c.Name = "toolstrip_continuer_c";
            this.toolstrip_continuer_c.Size = new System.Drawing.Size(82, 22);
            this.toolstrip_continuer_c.Text = "C";
            this.toolstrip_continuer_c.Click += new System.EventHandler(this.toolstrip_continuer_c_Click);
            // 
            // menuStripTop
            // 
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFichier,
            this.toolStripMenuItemProduction});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(800, 24);
            this.menuStripTop.TabIndex = 0;
            this.menuStripTop.Text = "menuStripTop";
            // 
            // timerProduction
            // 
            this.timerProduction.Enabled = true;
            this.timerProduction.Interval = 10;
            this.timerProduction.Tick += new System.EventHandler(this.timerProduction_Tick);
            // 
            // FormToutEmbal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.progressBarTypeC);
            this.Controls.Add(this.progressBarTypeB);
            this.Controls.Add(this.progressBarTypeA);
            this.Controls.Add(this.labelProductionC);
            this.Controls.Add(this.labelProductionB);
            this.Controls.Add(this.labelProductionA);
            this.Controls.Add(this.tabControlType);
            this.Controls.Add(this.menuStripTop);
            this.MainMenuStrip = this.menuStripTop;
            this.Name = "FormToutEmbal";
            this.Text = "PRODUCTION DES CAISSES";
            this.tabControlType.ResumeLayout(false);
            this.tabPageTypeA.ResumeLayout(false);
            this.tabPageTypeA.PerformLayout();
            this.tabPageTypeB.ResumeLayout(false);
            this.tabPageTypeB.PerformLayout();
            this.tabPageTypeC.ResumeLayout(false);
            this.tabPageTypeC.PerformLayout();
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TabControl tabControlType;
        private TabPage tabPageTypeA;
        private TabPage tabPageTypeB;
        private TabPage tabPageTypeC;
        private Label labelProductionA;
        private Label labelProductionB;
        private Label labelProductionC;
        private ProgressBar progressBarTypeA;
        private ProgressBar progressBarTypeB;
        private ProgressBar progressBarTypeC;
        private Label labelTypeANbDefectiveTotal;
        private Label labelTypeANbDefectivePerHour;
        private Label labelTypeANbCrate;
        private Label labelTypeBNbDefectiveTotal;
        private Label labelTypeBNbDefectivePerHour;
        private Label labelTypeBNbCrate;
        private Label labelTypeCNbDefectiveTotal;
        private Label labelTypeCNbDefectivePerHour;
        private Label labelTypeCNbCrate;
        private TextBox textBoxTypeADefectiveTotal;
        private TextBox textBoxTypeADefectivePerHour;
        private TextBox textBoxTypeANbCrate;
        private TextBox textBoxTypeBDefectiveTotal;
        private TextBox textBoxTypeBDefectivePerHour;
        private TextBox textBoxTypeBNbCrate;
        private TextBox textBoxTypeCDefectiveTotal;
        private TextBox textBoxTypeCDefectivePerHour;
        private TextBox textBoxTypeCNbCrate;
        private ToolStripMenuItem toolStripMenuItemFichier;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemProduction;
        private ToolStripMenuItem demarrerToolStripMenuItem;
        private ToolStripMenuItem toolstrip_demarrer_a;
        private ToolStripMenuItem toolstrip_demarrer_b;
        private ToolStripMenuItem toolstrip_demarrer_c;
        private ToolStripMenuItem arreterToolStripMenuItem;
        private ToolStripMenuItem toolstrip_arreter_a;
        private ToolStripMenuItem toolstrip_arreter_b;
        private ToolStripMenuItem toolstrip_arreter_c;
        private ToolStripMenuItem continuerToolStripMenuItem;
        private ToolStripMenuItem toolstrip_continuer_a;
        private ToolStripMenuItem toolstrip_continuer_b;
        private ToolStripMenuItem toolstrip_continuer_c;
        private MenuStrip menuStripTop;
        private System.Windows.Forms.Timer timerProduction;
    }
}