namespace Menu
{
    partial class frmMenu
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
            menuStripConnection = new MenuStrip();
            toolStripMenuItemConnection = new ToolStripMenuItem();
            sIdentifierToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            phase1ToolStripMenuItem = new ToolStripMenuItem();
            additionneurToolStripMenuItem = new ToolStripMenuItem();
            phase2ToolStripMenuItem = new ToolStripMenuItem();
            saisieToolStripMenuItem = new ToolStripMenuItem();
            phase3ToolStripMenuItem = new ToolStripMenuItem();
            checkBoxRadioToolStripMenuItem = new ToolStripMenuItem();
            listBoxToolStripMenuItem = new ToolStripMenuItem();
            comboBoxToolStripMenuItem = new ToolStripMenuItem();
            defilementToolStripMenuItem = new ToolStripMenuItem();
            empruntToolStripMenuItem = new ToolStripMenuItem();
            fenetresToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItemCascade = new ToolStripMenuItem();
            toolStripMenuItemHorizontal = new ToolStripMenuItem();
            Defilement = new ToolStripMenuItem();
            toolStripMainMenu = new ToolStrip();
            toolStripLabelDate = new ToolStripLabel();
            toolStripLabelIdentification = new ToolStripLabel();
            menuStripConnection.SuspendLayout();
            toolStripMainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripConnection
            // 
            menuStripConnection.Items.AddRange(new ToolStripItem[] { toolStripMenuItemConnection, phase1ToolStripMenuItem, phase2ToolStripMenuItem, phase3ToolStripMenuItem, fenetresToolStripMenuItem });
            menuStripConnection.Location = new Point(0, 0);
            menuStripConnection.Name = "menuStripConnection";
            menuStripConnection.Size = new Size(800, 24);
            menuStripConnection.TabIndex = 0;
            menuStripConnection.Text = "menuStrip1";
            // 
            // toolStripMenuItemConnection
            // 
            toolStripMenuItemConnection.DropDownItems.AddRange(new ToolStripItem[] { sIdentifierToolStripMenuItem, quitterToolStripMenuItem });
            toolStripMenuItemConnection.Name = "toolStripMenuItemConnection";
            toolStripMenuItemConnection.Size = new Size(81, 20);
            toolStripMenuItemConnection.Text = "Connection";
            // 
            // sIdentifierToolStripMenuItem
            // 
            sIdentifierToolStripMenuItem.Name = "sIdentifierToolStripMenuItem";
            sIdentifierToolStripMenuItem.Size = new Size(130, 22);
            sIdentifierToolStripMenuItem.Text = "S'Identifier";
            sIdentifierToolStripMenuItem.Click += sIdentifierToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(130, 22);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // phase1ToolStripMenuItem
            // 
            phase1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { additionneurToolStripMenuItem });
            phase1ToolStripMenuItem.Enabled = false;
            phase1ToolStripMenuItem.Name = "phase1ToolStripMenuItem";
            phase1ToolStripMenuItem.Size = new Size(56, 20);
            phase1ToolStripMenuItem.Text = "Phase1";
            // 
            // additionneurToolStripMenuItem
            // 
            additionneurToolStripMenuItem.Name = "additionneurToolStripMenuItem";
            additionneurToolStripMenuItem.Size = new Size(144, 22);
            additionneurToolStripMenuItem.Text = "Additionneur";
            additionneurToolStripMenuItem.Click += additionneurToolStripMenuItem_Click;
            // 
            // phase2ToolStripMenuItem
            // 
            phase2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saisieToolStripMenuItem });
            phase2ToolStripMenuItem.Enabled = false;
            phase2ToolStripMenuItem.Name = "phase2ToolStripMenuItem";
            phase2ToolStripMenuItem.Size = new Size(56, 20);
            phase2ToolStripMenuItem.Text = "Phase2";
            // 
            // saisieToolStripMenuItem
            // 
            saisieToolStripMenuItem.Name = "saisieToolStripMenuItem";
            saisieToolStripMenuItem.Size = new Size(103, 22);
            saisieToolStripMenuItem.Text = "Saisie";
            saisieToolStripMenuItem.Click += saisieToolStripMenuItem_Click;
            // 
            // phase3ToolStripMenuItem
            // 
            phase3ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { checkBoxRadioToolStripMenuItem, listBoxToolStripMenuItem, comboBoxToolStripMenuItem, defilementToolStripMenuItem, empruntToolStripMenuItem });
            phase3ToolStripMenuItem.Enabled = false;
            phase3ToolStripMenuItem.Name = "phase3ToolStripMenuItem";
            phase3ToolStripMenuItem.Size = new Size(56, 20);
            phase3ToolStripMenuItem.Text = "Phase3";
            // 
            // checkBoxRadioToolStripMenuItem
            // 
            checkBoxRadioToolStripMenuItem.Name = "checkBoxRadioToolStripMenuItem";
            checkBoxRadioToolStripMenuItem.Size = new Size(157, 22);
            checkBoxRadioToolStripMenuItem.Text = "CheckBoxRadio";
            checkBoxRadioToolStripMenuItem.Click += checkBoxRadioToolStripMenuItem_Click;
            // 
            // listBoxToolStripMenuItem
            // 
            listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            listBoxToolStripMenuItem.Size = new Size(157, 22);
            listBoxToolStripMenuItem.Text = "ListBox";
            listBoxToolStripMenuItem.Click += listBoxToolStripMenuItem_Click;
            // 
            // comboBoxToolStripMenuItem
            // 
            comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            comboBoxToolStripMenuItem.Size = new Size(157, 22);
            comboBoxToolStripMenuItem.Text = "ComboBox";
            comboBoxToolStripMenuItem.Click += comboBoxToolStripMenuItem_Click;
            // 
            // defilementToolStripMenuItem
            // 
            defilementToolStripMenuItem.Name = "defilementToolStripMenuItem";
            defilementToolStripMenuItem.Size = new Size(157, 22);
            defilementToolStripMenuItem.Text = "Defilement";
            defilementToolStripMenuItem.Click += defilementToolStripMenuItem_Click;
            // 
            // empruntToolStripMenuItem
            // 
            empruntToolStripMenuItem.Name = "empruntToolStripMenuItem";
            empruntToolStripMenuItem.Size = new Size(157, 22);
            empruntToolStripMenuItem.Text = "Emprunt";
            empruntToolStripMenuItem.Click += empruntToolStripMenuItem_Click;
            // 
            // fenetresToolStripMenuItem
            // 
            fenetresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemCascade, toolStripMenuItemHorizontal, Defilement });
            fenetresToolStripMenuItem.Name = "fenetresToolStripMenuItem";
            fenetresToolStripMenuItem.Size = new Size(63, 20);
            fenetresToolStripMenuItem.Text = "Fenêtres";
            // 
            // toolStripMenuItemCascade
            // 
            toolStripMenuItemCascade.Name = "toolStripMenuItemCascade";
            toolStripMenuItemCascade.Size = new Size(132, 22);
            toolStripMenuItemCascade.Text = "Cascade";
            // 
            // toolStripMenuItemHorizontal
            // 
            toolStripMenuItemHorizontal.Name = "toolStripMenuItemHorizontal";
            toolStripMenuItemHorizontal.Size = new Size(132, 22);
            toolStripMenuItemHorizontal.Text = "Horizontal";
            // 
            // Defilement
            // 
            Defilement.Name = "Defilement";
            Defilement.Size = new Size(132, 22);
            Defilement.Text = "Défilement";
            // 
            // toolStripMainMenu
            // 
            toolStripMainMenu.Dock = DockStyle.Bottom;
            toolStripMainMenu.Items.AddRange(new ToolStripItem[] { toolStripLabelDate, toolStripLabelIdentification });
            toolStripMainMenu.Location = new Point(0, 425);
            toolStripMainMenu.Name = "toolStripMainMenu";
            toolStripMainMenu.Size = new Size(800, 25);
            toolStripMainMenu.TabIndex = 2;
            toolStripMainMenu.Text = "toolStripMainMenu";
            // 
            // toolStripLabelDate
            // 
            toolStripLabelDate.Name = "toolStripLabelDate";
            toolStripLabelDate.Size = new Size(0, 22);
            // 
            // toolStripLabelIdentification
            // 
            toolStripLabelIdentification.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            toolStripLabelIdentification.Name = "toolStripLabelIdentification";
            toolStripLabelIdentification.Size = new Size(76, 22);
            toolStripLabelIdentification.Text = "Identification";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStripMainMenu);
            Controls.Add(menuStripConnection);
            IsMdiContainer = true;
            MainMenuStrip = menuStripConnection;
            Name = "frmMenu";
            Text = "Créer des formulaires";
            menuStripConnection.ResumeLayout(false);
            menuStripConnection.PerformLayout();
            toolStripMainMenu.ResumeLayout(false);
            toolStripMainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripConnection;
        private ToolStripMenuItem toolStripMenuItemConnection;
        private ToolStripMenuItem sIdentifierToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem phase1ToolStripMenuItem;
        private ToolStripMenuItem phase2ToolStripMenuItem;
        private ToolStripMenuItem phase3ToolStripMenuItem;
        private ToolStripMenuItem fenetresToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemCascade;
        private ToolStripMenuItem toolStripMenuItemHorizontal;
        private ToolStripMenuItem Defilement;
        private ToolStripMenuItem additionneurToolStripMenuItem;
        private ToolStripMenuItem saisieToolStripMenuItem;
        private ToolStripMenuItem checkBoxRadioToolStripMenuItem;
        private ToolStripMenuItem listBoxToolStripMenuItem;
        private ToolStripMenuItem comboBoxToolStripMenuItem;
        private ToolStripMenuItem defilementToolStripMenuItem;
        private ToolStripMenuItem empruntToolStripMenuItem;
        private ToolStrip toolStripMainMenu;
        private ToolStripLabel toolStripLabelDate;
        private ToolStripLabel toolStripLabelIdentification;
    }
}