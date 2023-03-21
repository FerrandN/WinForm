namespace Emprunt
{
    partial class Emprunt
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
            this.labelNom = new System.Windows.Forms.Label();
            this.labelCapitalEmprunte = new System.Windows.Forms.Label();
            this.labelDureeEnMoisDuRemboursement = new System.Windows.Forms.Label();
            this.labelTauxDInteret = new System.Windows.Forms.Label();
            this.labelRefundPeriode = new System.Windows.Forms.Label();
            this.labelRefund = new System.Windows.Forms.Label();
            this.labelNumberOfMonth = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.radioButtonSeven = new System.Windows.Forms.RadioButton();
            this.radioButtonEight = new System.Windows.Forms.RadioButton();
            this.radioButtonNine = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanelRadioButtonPercent = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelMonthDuration = new System.Windows.Forms.Label();
            this.hScrollBarLoanDuration = new System.Windows.Forms.HScrollBar();
            this.listBoxMonthlyType = new System.Windows.Forms.ListBox();
            this.numericUpDownLoanValue = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanelRadioButtonPercent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoanValue)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(50, 44);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(34, 15);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // labelCapitalEmprunte
            // 
            this.labelCapitalEmprunte.AutoSize = true;
            this.labelCapitalEmprunte.Location = new System.Drawing.Point(50, 78);
            this.labelCapitalEmprunte.Name = "labelCapitalEmprunte";
            this.labelCapitalEmprunte.Size = new System.Drawing.Size(99, 15);
            this.labelCapitalEmprunte.TabIndex = 1;
            this.labelCapitalEmprunte.Text = "Capital Emprunté";
            // 
            // labelDureeEnMoisDuRemboursement
            // 
            this.labelDureeEnMoisDuRemboursement.AutoSize = true;
            this.labelDureeEnMoisDuRemboursement.Location = new System.Drawing.Point(50, 121);
            this.labelDureeEnMoisDuRemboursement.Name = "labelDureeEnMoisDuRemboursement";
            this.labelDureeEnMoisDuRemboursement.Size = new System.Drawing.Size(188, 15);
            this.labelDureeEnMoisDuRemboursement.TabIndex = 2;
            this.labelDureeEnMoisDuRemboursement.Text = "Durée en mois du remboursement";
            // 
            // labelTauxDInteret
            // 
            this.labelTauxDInteret.AutoSize = true;
            this.labelTauxDInteret.Location = new System.Drawing.Point(459, 44);
            this.labelTauxDInteret.Name = "labelTauxDInteret";
            this.labelTauxDInteret.Size = new System.Drawing.Size(79, 15);
            this.labelTauxDInteret.TabIndex = 4;
            this.labelTauxDInteret.Text = "Taux D\'intérêt";
            // 
            // labelRefundPeriode
            // 
            this.labelRefundPeriode.AutoSize = true;
            this.labelRefundPeriode.Location = new System.Drawing.Point(50, 194);
            this.labelRefundPeriode.Name = "labelRefundPeriode";
            this.labelRefundPeriode.Size = new System.Drawing.Size(167, 15);
            this.labelRefundPeriode.TabIndex = 5;
            this.labelRefundPeriode.Text = "Périodicité de remboursement";
            // 
            // labelRefund
            // 
            this.labelRefund.AutoSize = true;
            this.labelRefund.Location = new System.Drawing.Point(516, 194);
            this.labelRefund.Name = "labelRefund";
            this.labelRefund.Size = new System.Drawing.Size(100, 15);
            this.labelRefund.TabIndex = 6;
            this.labelRefund.Text = "Remboursements";
            // 
            // labelNumberOfMonth
            // 
            this.labelNumberOfMonth.AutoSize = true;
            this.labelNumberOfMonth.ForeColor = System.Drawing.Color.Red;
            this.labelNumberOfMonth.Location = new System.Drawing.Point(516, 221);
            this.labelNumberOfMonth.Name = "labelNumberOfMonth";
            this.labelNumberOfMonth.Size = new System.Drawing.Size(13, 15);
            this.labelNumberOfMonth.TabIndex = 8;
            this.labelNumberOfMonth.Text = "0";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.ForeColor = System.Drawing.Color.Red;
            this.labelValue.Location = new System.Drawing.Point(516, 263);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(13, 15);
            this.labelValue.TabIndex = 9;
            this.labelValue.Text = "0";
            // 
            // radioButtonSeven
            // 
            this.radioButtonSeven.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonSeven.AutoSize = true;
            this.radioButtonSeven.Checked = true;
            this.radioButtonSeven.Location = new System.Drawing.Point(3, 13);
            this.radioButtonSeven.Name = "radioButtonSeven";
            this.radioButtonSeven.Size = new System.Drawing.Size(41, 19);
            this.radioButtonSeven.TabIndex = 10;
            this.radioButtonSeven.TabStop = true;
            this.radioButtonSeven.Text = "7%";
            this.radioButtonSeven.UseVisualStyleBackColor = true;
            this.radioButtonSeven.CheckedChanged += new System.EventHandler(this.radioButtonSeven_CheckedChanged);
            // 
            // radioButtonEight
            // 
            this.radioButtonEight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonEight.AutoSize = true;
            this.radioButtonEight.Location = new System.Drawing.Point(3, 38);
            this.radioButtonEight.Name = "radioButtonEight";
            this.radioButtonEight.Size = new System.Drawing.Size(41, 19);
            this.radioButtonEight.TabIndex = 11;
            this.radioButtonEight.Text = "8%";
            this.radioButtonEight.UseVisualStyleBackColor = true;
            this.radioButtonEight.CheckedChanged += new System.EventHandler(this.radioButtonEight_CheckedChanged);
            // 
            // radioButtonNine
            // 
            this.radioButtonNine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonNine.AutoSize = true;
            this.radioButtonNine.Location = new System.Drawing.Point(3, 63);
            this.radioButtonNine.Name = "radioButtonNine";
            this.radioButtonNine.Size = new System.Drawing.Size(41, 19);
            this.radioButtonNine.TabIndex = 12;
            this.radioButtonNine.Text = "9%";
            this.radioButtonNine.UseVisualStyleBackColor = true;
            this.radioButtonNine.CheckedChanged += new System.EventHandler(this.radioButtonNine_CheckedChanged);
            // 
            // flowLayoutPanelRadioButtonPercent
            // 
            this.flowLayoutPanelRadioButtonPercent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanelRadioButtonPercent.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelRadioButtonPercent.Controls.Add(this.radioButtonNine);
            this.flowLayoutPanelRadioButtonPercent.Controls.Add(this.radioButtonEight);
            this.flowLayoutPanelRadioButtonPercent.Controls.Add(this.radioButtonSeven);
            this.flowLayoutPanelRadioButtonPercent.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanelRadioButtonPercent.Location = new System.Drawing.Point(450, 53);
            this.flowLayoutPanelRadioButtonPercent.Name = "flowLayoutPanelRadioButtonPercent";
            this.flowLayoutPanelRadioButtonPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanelRadioButtonPercent.Size = new System.Drawing.Size(106, 85);
            this.flowLayoutPanelRadioButtonPercent.TabIndex = 13;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(163, 41);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(144, 23);
            this.textBoxName.TabIndex = 1;
            // 
            // labelMonthDuration
            // 
            this.labelMonthDuration.AutoSize = true;
            this.labelMonthDuration.Location = new System.Drawing.Point(250, 121);
            this.labelMonthDuration.Name = "labelMonthDuration";
            this.labelMonthDuration.Size = new System.Drawing.Size(13, 15);
            this.labelMonthDuration.TabIndex = 16;
            this.labelMonthDuration.Text = "1";
            // 
            // hScrollBarLoanDuration
            // 
            this.hScrollBarLoanDuration.LargeChange = 12;
            this.hScrollBarLoanDuration.Location = new System.Drawing.Point(305, 121);
            this.hScrollBarLoanDuration.Maximum = 161;
            this.hScrollBarLoanDuration.Minimum = 1;
            this.hScrollBarLoanDuration.Name = "hScrollBarLoanDuration";
            this.hScrollBarLoanDuration.Size = new System.Drawing.Size(123, 17);
            this.hScrollBarLoanDuration.TabIndex = 17;
            this.hScrollBarLoanDuration.Value = 1;
            this.hScrollBarLoanDuration.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarLoanDuration_Scroll);
            // 
            // listBoxMonthlyType
            // 
            this.listBoxMonthlyType.FormattingEnabled = true;
            this.listBoxMonthlyType.ItemHeight = 15;
            this.listBoxMonthlyType.Items.AddRange(new object[] {
            "Mensuelle",
            "Bimestrielle",
            "Trimestrielle",
            "Semestrielle",
            "Annuelle"});
            this.listBoxMonthlyType.Location = new System.Drawing.Point(50, 221);
            this.listBoxMonthlyType.Name = "listBoxMonthlyType";
            this.listBoxMonthlyType.Size = new System.Drawing.Size(167, 79);
            this.listBoxMonthlyType.TabIndex = 20;
            this.listBoxMonthlyType.SelectedIndexChanged += new System.EventHandler(this.listBoxMonthlyType_SelectedIndexChanged);
            // 
            // numericUpDownLoanValue
            // 
            this.numericUpDownLoanValue.Location = new System.Drawing.Point(163, 76);
            this.numericUpDownLoanValue.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownLoanValue.Name = "numericUpDownLoanValue";
            this.numericUpDownLoanValue.Size = new System.Drawing.Size(144, 23);
            this.numericUpDownLoanValue.TabIndex = 21;
            this.numericUpDownLoanValue.ValueChanged += new System.EventHandler(this.numericUpDownLoanValue_ValueChanged);
            // 
            // Emprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 352);
            this.Controls.Add(this.numericUpDownLoanValue);
            this.Controls.Add(this.listBoxMonthlyType);
            this.Controls.Add(this.hScrollBarLoanDuration);
            this.Controls.Add(this.labelMonthDuration);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.labelNumberOfMonth);
            this.Controls.Add(this.labelRefund);
            this.Controls.Add(this.labelRefundPeriode);
            this.Controls.Add(this.labelTauxDInteret);
            this.Controls.Add(this.labelDureeEnMoisDuRemboursement);
            this.Controls.Add(this.labelCapitalEmprunte);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.flowLayoutPanelRadioButtonPercent);
            this.Name = "Emprunt";
            this.Text = "Emprunt";
            this.flowLayoutPanelRadioButtonPercent.ResumeLayout(false);
            this.flowLayoutPanelRadioButtonPercent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoanValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNom;
        private Label labelCapitalEmprunte;
        private Label labelDureeEnMoisDuRemboursement;
        private Label labelTauxDInteret;
        private Label labelRefundPeriode;
        private Label labelRefund;
        private Label labelNumberOfMonth;
        private Label labelValue;
        private RadioButton radioButtonSeven;
        private RadioButton radioButtonEight;
        private RadioButton radioButtonNine;
        private FlowLayoutPanel flowLayoutPanelRadioButtonPercent;
        private TextBox textBoxName;
        private Label labelMonthDuration;
        private HScrollBar hScrollBarLoanDuration;
        private ListBox listBoxMonthlyType;
        private NumericUpDown numericUpDownLoanValue;
    }
}