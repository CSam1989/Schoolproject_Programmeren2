namespace CeustermansSamOO
{
    partial class formBank
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
            this.labelRekeningnummer = new System.Windows.Forms.Label();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.labelVariabelLimRente = new System.Windows.Forms.Label();
            this.textBoxRekeningnummer = new System.Windows.Forms.TextBox();
            this.textBoxSaldo = new System.Windows.Forms.TextBox();
            this.textBoxVariabelLimRente = new System.Windows.Forms.TextBox();
            this.buttonNieuw = new System.Windows.Forms.Button();
            this.buttonVariabelLimRente = new System.Windows.Forms.Button();
            this.labelOverzicht = new System.Windows.Forms.Label();
            this.labelBedrag = new System.Windows.Forms.Label();
            this.textBoxBedrag = new System.Windows.Forms.TextBox();
            this.buttonAfhalen = new System.Windows.Forms.Button();
            this.buttonStorten = new System.Windows.Forms.Button();
            this.panelToonVerberg = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRekeningen = new System.Windows.Forms.ComboBox();
            this.buttonOverzicht = new System.Windows.Forms.Button();
            this.buttonSluiten = new System.Windows.Forms.Button();
            this.grbSoortRekening = new System.Windows.Forms.GroupBox();
            this.rdbZichtrekening = new System.Windows.Forms.RadioButton();
            this.rdbSpaarrekening = new System.Windows.Forms.RadioButton();
            this.panelToonVerberg.SuspendLayout();
            this.grbSoortRekening.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRekeningnummer
            // 
            this.labelRekeningnummer.AutoSize = true;
            this.labelRekeningnummer.Location = new System.Drawing.Point(16, 13);
            this.labelRekeningnummer.Name = "labelRekeningnummer";
            this.labelRekeningnummer.Size = new System.Drawing.Size(142, 13);
            this.labelRekeningnummer.TabIndex = 0;
            this.labelRekeningnummer.Text = "Rekeningnummer (verplicht):";
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Location = new System.Drawing.Point(16, 81);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(89, 13);
            this.labelSaldo.TabIndex = 1;
            this.labelSaldo.Text = "Saldo (optioneel):";
            // 
            // labelVariabelLimRente
            // 
            this.labelVariabelLimRente.AutoSize = true;
            this.labelVariabelLimRente.Location = new System.Drawing.Point(3, 13);
            this.labelVariabelLimRente.Name = "labelVariabelLimRente";
            this.labelVariabelLimRente.Size = new System.Drawing.Size(92, 13);
            this.labelVariabelLimRente.TabIndex = 2;
            this.labelVariabelLimRente.Text = "Limiet (optioneel): ";
            // 
            // textBoxRekeningnummer
            // 
            this.textBoxRekeningnummer.Location = new System.Drawing.Point(170, 10);
            this.textBoxRekeningnummer.Name = "textBoxRekeningnummer";
            this.textBoxRekeningnummer.Size = new System.Drawing.Size(233, 20);
            this.textBoxRekeningnummer.TabIndex = 3;
            // 
            // textBoxSaldo
            // 
            this.textBoxSaldo.Location = new System.Drawing.Point(170, 78);
            this.textBoxSaldo.Name = "textBoxSaldo";
            this.textBoxSaldo.Size = new System.Drawing.Size(233, 20);
            this.textBoxSaldo.TabIndex = 4;
            // 
            // textBoxVariabelLimRente
            // 
            this.textBoxVariabelLimRente.Location = new System.Drawing.Point(151, 10);
            this.textBoxVariabelLimRente.Name = "textBoxVariabelLimRente";
            this.textBoxVariabelLimRente.Size = new System.Drawing.Size(146, 20);
            this.textBoxVariabelLimRente.TabIndex = 5;
            // 
            // buttonNieuw
            // 
            this.buttonNieuw.Location = new System.Drawing.Point(19, 104);
            this.buttonNieuw.Name = "buttonNieuw";
            this.buttonNieuw.Size = new System.Drawing.Size(384, 23);
            this.buttonNieuw.TabIndex = 6;
            this.buttonNieuw.Text = "Maak een nieuwe rekening";
            this.buttonNieuw.UseVisualStyleBackColor = true;
            this.buttonNieuw.Click += new System.EventHandler(this.buttonNieuw_Click);
            // 
            // buttonVariabelLimRente
            // 
            this.buttonVariabelLimRente.Location = new System.Drawing.Point(303, 8);
            this.buttonVariabelLimRente.Name = "buttonVariabelLimRente";
            this.buttonVariabelLimRente.Size = new System.Drawing.Size(87, 23);
            this.buttonVariabelLimRente.TabIndex = 7;
            this.buttonVariabelLimRente.Text = "Limiet instellen";
            this.buttonVariabelLimRente.UseVisualStyleBackColor = true;
            this.buttonVariabelLimRente.Click += new System.EventHandler(this.buttonVariabelLimRente_Click);
            // 
            // labelOverzicht
            // 
            this.labelOverzicht.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOverzicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOverzicht.Location = new System.Drawing.Point(6, 51);
            this.labelOverzicht.Name = "labelOverzicht";
            this.labelOverzicht.Size = new System.Drawing.Size(384, 160);
            this.labelOverzicht.TabIndex = 8;
            // 
            // labelBedrag
            // 
            this.labelBedrag.AutoSize = true;
            this.labelBedrag.Location = new System.Drawing.Point(6, 231);
            this.labelBedrag.Name = "labelBedrag";
            this.labelBedrag.Size = new System.Drawing.Size(88, 13);
            this.labelBedrag.TabIndex = 9;
            this.labelBedrag.Text = "Storten/Afhalen?";
            // 
            // textBoxBedrag
            // 
            this.textBoxBedrag.Location = new System.Drawing.Point(153, 228);
            this.textBoxBedrag.Name = "textBoxBedrag";
            this.textBoxBedrag.Size = new System.Drawing.Size(239, 20);
            this.textBoxBedrag.TabIndex = 10;
            // 
            // buttonAfhalen
            // 
            this.buttonAfhalen.Location = new System.Drawing.Point(9, 260);
            this.buttonAfhalen.Name = "buttonAfhalen";
            this.buttonAfhalen.Size = new System.Drawing.Size(180, 23);
            this.buttonAfhalen.TabIndex = 11;
            this.buttonAfhalen.Text = "Afhalen";
            this.buttonAfhalen.UseVisualStyleBackColor = true;
            this.buttonAfhalen.Click += new System.EventHandler(this.buttonAfhalen_Click);
            // 
            // buttonStorten
            // 
            this.buttonStorten.Location = new System.Drawing.Point(212, 259);
            this.buttonStorten.Name = "buttonStorten";
            this.buttonStorten.Size = new System.Drawing.Size(180, 23);
            this.buttonStorten.TabIndex = 12;
            this.buttonStorten.Text = "Storten";
            this.buttonStorten.UseVisualStyleBackColor = true;
            this.buttonStorten.Click += new System.EventHandler(this.buttonStorten_Click);
            // 
            // panelToonVerberg
            // 
            this.panelToonVerberg.Controls.Add(this.labelVariabelLimRente);
            this.panelToonVerberg.Controls.Add(this.buttonStorten);
            this.panelToonVerberg.Controls.Add(this.textBoxVariabelLimRente);
            this.panelToonVerberg.Controls.Add(this.buttonAfhalen);
            this.panelToonVerberg.Controls.Add(this.buttonVariabelLimRente);
            this.panelToonVerberg.Controls.Add(this.textBoxBedrag);
            this.panelToonVerberg.Controls.Add(this.labelOverzicht);
            this.panelToonVerberg.Controls.Add(this.labelBedrag);
            this.panelToonVerberg.Location = new System.Drawing.Point(12, 221);
            this.panelToonVerberg.Name = "panelToonVerberg";
            this.panelToonVerberg.Size = new System.Drawing.Size(403, 298);
            this.panelToonVerberg.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kies een bestaande rekening:";
            // 
            // comboBoxRekeningen
            // 
            this.comboBoxRekeningen.FormattingEnabled = true;
            this.comboBoxRekeningen.Location = new System.Drawing.Point(170, 133);
            this.comboBoxRekeningen.Name = "comboBoxRekeningen";
            this.comboBoxRekeningen.Size = new System.Drawing.Size(232, 21);
            this.comboBoxRekeningen.TabIndex = 15;
            this.comboBoxRekeningen.SelectedIndexChanged += new System.EventHandler(this.comboBoxRekeningen_SelectedIndexChanged);
            // 
            // buttonOverzicht
            // 
            this.buttonOverzicht.Location = new System.Drawing.Point(21, 160);
            this.buttonOverzicht.Name = "buttonOverzicht";
            this.buttonOverzicht.Size = new System.Drawing.Size(383, 23);
            this.buttonOverzicht.TabIndex = 16;
            this.buttonOverzicht.Text = "Overzicht van alle rekeningen";
            this.buttonOverzicht.UseVisualStyleBackColor = true;
            this.buttonOverzicht.Click += new System.EventHandler(this.buttonOverzicht_Click);
            // 
            // buttonSluiten
            // 
            this.buttonSluiten.Location = new System.Drawing.Point(21, 189);
            this.buttonSluiten.Name = "buttonSluiten";
            this.buttonSluiten.Size = new System.Drawing.Size(383, 23);
            this.buttonSluiten.TabIndex = 17;
            this.buttonSluiten.Text = "Schrijf weg en Sluit af";
            this.buttonSluiten.UseVisualStyleBackColor = true;
            this.buttonSluiten.Click += new System.EventHandler(this.buttonSluiten_Click);
            // 
            // grbSoortRekening
            // 
            this.grbSoortRekening.Controls.Add(this.rdbZichtrekening);
            this.grbSoortRekening.Controls.Add(this.rdbSpaarrekening);
            this.grbSoortRekening.Location = new System.Drawing.Point(18, 36);
            this.grbSoortRekening.Name = "grbSoortRekening";
            this.grbSoortRekening.Size = new System.Drawing.Size(386, 36);
            this.grbSoortRekening.TabIndex = 18;
            this.grbSoortRekening.TabStop = false;
            this.grbSoortRekening.Text = "Soort van rekening";
            // 
            // rdbZichtrekening
            // 
            this.rdbZichtrekening.AutoSize = true;
            this.rdbZichtrekening.Checked = true;
            this.rdbZichtrekening.Location = new System.Drawing.Point(55, 13);
            this.rdbZichtrekening.Name = "rdbZichtrekening";
            this.rdbZichtrekening.Size = new System.Drawing.Size(90, 17);
            this.rdbZichtrekening.TabIndex = 19;
            this.rdbZichtrekening.TabStop = true;
            this.rdbZichtrekening.Text = "Zichtrekening";
            this.rdbZichtrekening.UseVisualStyleBackColor = true;
            // 
            // rdbSpaarrekening
            // 
            this.rdbSpaarrekening.AutoSize = true;
            this.rdbSpaarrekening.Location = new System.Drawing.Point(206, 13);
            this.rdbSpaarrekening.Name = "rdbSpaarrekening";
            this.rdbSpaarrekening.Size = new System.Drawing.Size(94, 17);
            this.rdbSpaarrekening.TabIndex = 0;
            this.rdbSpaarrekening.Text = "Spaarrekening";
            this.rdbSpaarrekening.UseVisualStyleBackColor = true;
            // 
            // formBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 535);
            this.Controls.Add(this.grbSoortRekening);
            this.Controls.Add(this.buttonSluiten);
            this.Controls.Add(this.buttonOverzicht);
            this.Controls.Add(this.comboBoxRekeningen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelToonVerberg);
            this.Controls.Add(this.buttonNieuw);
            this.Controls.Add(this.textBoxSaldo);
            this.Controls.Add(this.textBoxRekeningnummer);
            this.Controls.Add(this.labelSaldo);
            this.Controls.Add(this.labelRekeningnummer);
            this.Name = "formBank";
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.formBank_Load);
            this.panelToonVerberg.ResumeLayout(false);
            this.panelToonVerberg.PerformLayout();
            this.grbSoortRekening.ResumeLayout(false);
            this.grbSoortRekening.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRekeningnummer;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Label labelVariabelLimRente;
        private System.Windows.Forms.TextBox textBoxRekeningnummer;
        private System.Windows.Forms.TextBox textBoxSaldo;
        private System.Windows.Forms.TextBox textBoxVariabelLimRente;
        private System.Windows.Forms.Button buttonNieuw;
        private System.Windows.Forms.Button buttonVariabelLimRente;
        private System.Windows.Forms.Label labelOverzicht;
        private System.Windows.Forms.Label labelBedrag;
        private System.Windows.Forms.TextBox textBoxBedrag;
        private System.Windows.Forms.Button buttonAfhalen;
        private System.Windows.Forms.Button buttonStorten;
        private System.Windows.Forms.Panel panelToonVerberg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRekeningen;
        private System.Windows.Forms.Button buttonOverzicht;
        private System.Windows.Forms.Button buttonSluiten;
        private System.Windows.Forms.GroupBox grbSoortRekening;
        private System.Windows.Forms.RadioButton rdbZichtrekening;
        private System.Windows.Forms.RadioButton rdbSpaarrekening;
    }
}

