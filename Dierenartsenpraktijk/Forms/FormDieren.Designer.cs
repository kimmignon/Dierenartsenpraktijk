namespace Dierenartsenpraktijk.Forms
{
    partial class FormDieren
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.tabControlDieren = new System.Windows.Forms.TabControl();
            this.tabPageOverzicht = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSelectedDier = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonVerwijder = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.listBoxBaasje = new System.Windows.Forms.ListBox();
            this.labelBaasje = new System.Windows.Forms.Label();
            this.textBoxDatum = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxKleur = new System.Windows.Forms.TextBox();
            this.textBoxRas = new System.Windows.Forms.TextBox();
            this.textBoxSoort = new System.Windows.Forms.TextBox();
            this.textBoxNaam = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelKleur = new System.Windows.Forms.Label();
            this.labelRas = new System.Windows.Forms.Label();
            this.labelSoort = new System.Windows.Forms.Label();
            this.labelNaam = new System.Windows.Forms.Label();
            this.buttonSelecteer = new System.Windows.Forms.Button();
            this.listBoxDieren = new System.Windows.Forms.ListBox();
            this.textBoxGeefNaam = new System.Windows.Forms.TextBox();
            this.buttonGeefOpNaam = new System.Windows.Forms.Button();
            this.buttonToonAlle = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonAlleKlanten = new System.Windows.Forms.Button();
            this.tabControlDieren.SuspendLayout();
            this.tabPageOverzicht.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(893, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(38, 29);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // tabControlDieren
            // 
            this.tabControlDieren.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlDieren.Controls.Add(this.tabPageOverzicht);
            this.tabControlDieren.Controls.Add(this.tabPage2);
            this.tabControlDieren.Location = new System.Drawing.Point(-1, 22);
            this.tabControlDieren.Name = "tabControlDieren";
            this.tabControlDieren.SelectedIndex = 0;
            this.tabControlDieren.Size = new System.Drawing.Size(943, 564);
            this.tabControlDieren.TabIndex = 2;
            // 
            // tabPageOverzicht
            // 
            this.tabPageOverzicht.Controls.Add(this.panel1);
            this.tabPageOverzicht.Controls.Add(this.buttonSelecteer);
            this.tabPageOverzicht.Controls.Add(this.listBoxDieren);
            this.tabPageOverzicht.Controls.Add(this.textBoxGeefNaam);
            this.tabPageOverzicht.Controls.Add(this.buttonGeefOpNaam);
            this.tabPageOverzicht.Controls.Add(this.buttonToonAlle);
            this.tabPageOverzicht.Location = new System.Drawing.Point(4, 29);
            this.tabPageOverzicht.Name = "tabPageOverzicht";
            this.tabPageOverzicht.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOverzicht.Size = new System.Drawing.Size(935, 531);
            this.tabPageOverzicht.TabIndex = 0;
            this.tabPageOverzicht.Text = "Overzicht";
            this.tabPageOverzicht.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.labelSelectedDier);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonVerwijder);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.listBoxBaasje);
            this.panel1.Controls.Add(this.labelBaasje);
            this.panel1.Controls.Add(this.textBoxDatum);
            this.panel1.Controls.Add(this.textBoxStatus);
            this.panel1.Controls.Add(this.textBoxKleur);
            this.panel1.Controls.Add(this.textBoxRas);
            this.panel1.Controls.Add(this.textBoxSoort);
            this.panel1.Controls.Add(this.textBoxNaam);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.labelDatum);
            this.panel1.Controls.Add(this.labelKleur);
            this.panel1.Controls.Add(this.labelRas);
            this.panel1.Controls.Add(this.labelSoort);
            this.panel1.Controls.Add(this.labelNaam);
            this.panel1.Location = new System.Drawing.Point(3, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 270);
            this.panel1.TabIndex = 5;
            // 
            // labelSelectedDier
            // 
            this.labelSelectedDier.AutoSize = true;
            this.labelSelectedDier.ForeColor = System.Drawing.Color.Navy;
            this.labelSelectedDier.Location = new System.Drawing.Point(17, 0);
            this.labelSelectedDier.Name = "labelSelectedDier";
            this.labelSelectedDier.Size = new System.Drawing.Size(40, 20);
            this.labelSelectedDier.TabIndex = 0;
            this.labelSelectedDier.Text = "Dier:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.buttonAlleKlanten);
            this.panel2.Location = new System.Drawing.Point(354, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 168);
            this.panel2.TabIndex = 16;
            // 
            // buttonVerwijder
            // 
            this.buttonVerwijder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVerwijder.Location = new System.Drawing.Point(740, 70);
            this.buttonVerwijder.Name = "buttonVerwijder";
            this.buttonVerwijder.Size = new System.Drawing.Size(167, 29);
            this.buttonVerwijder.TabIndex = 15;
            this.buttonVerwijder.Text = "Verwijder dier";
            this.buttonVerwijder.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.Location = new System.Drawing.Point(740, 26);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(167, 31);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "Update gegevens";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // listBoxBaasje
            // 
            this.listBoxBaasje.FormattingEnabled = true;
            this.listBoxBaasje.ItemHeight = 20;
            this.listBoxBaasje.Location = new System.Drawing.Point(412, 70);
            this.listBoxBaasje.Name = "listBoxBaasje";
            this.listBoxBaasje.Size = new System.Drawing.Size(262, 24);
            this.listBoxBaasje.TabIndex = 13;
            // 
            // labelBaasje
            // 
            this.labelBaasje.AutoSize = true;
            this.labelBaasje.Location = new System.Drawing.Point(354, 70);
            this.labelBaasje.Name = "labelBaasje";
            this.labelBaasje.Size = new System.Drawing.Size(52, 20);
            this.labelBaasje.TabIndex = 12;
            this.labelBaasje.Text = "Baasje";
            // 
            // textBoxDatum
            // 
            this.textBoxDatum.Location = new System.Drawing.Point(487, 27);
            this.textBoxDatum.Name = "textBoxDatum";
            this.textBoxDatum.Size = new System.Drawing.Size(187, 27);
            this.textBoxDatum.TabIndex = 11;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxStatus.Location = new System.Drawing.Point(42, 188);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(276, 27);
            this.textBoxStatus.TabIndex = 10;
            // 
            // textBoxKleur
            // 
            this.textBoxKleur.Location = new System.Drawing.Point(131, 128);
            this.textBoxKleur.Name = "textBoxKleur";
            this.textBoxKleur.Size = new System.Drawing.Size(187, 27);
            this.textBoxKleur.TabIndex = 9;
            // 
            // textBoxRas
            // 
            this.textBoxRas.Location = new System.Drawing.Point(131, 95);
            this.textBoxRas.Name = "textBoxRas";
            this.textBoxRas.Size = new System.Drawing.Size(187, 27);
            this.textBoxRas.TabIndex = 8;
            // 
            // textBoxSoort
            // 
            this.textBoxSoort.Location = new System.Drawing.Point(131, 63);
            this.textBoxSoort.Name = "textBoxSoort";
            this.textBoxSoort.Size = new System.Drawing.Size(187, 27);
            this.textBoxSoort.TabIndex = 7;
            // 
            // textBoxNaam
            // 
            this.textBoxNaam.Location = new System.Drawing.Point(131, 30);
            this.textBoxNaam.Name = "textBoxNaam";
            this.textBoxNaam.Size = new System.Drawing.Size(187, 27);
            this.textBoxNaam.TabIndex = 6;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(42, 165);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(136, 20);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Gezondheidsstatus:";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(354, 34);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(115, 20);
            this.labelDatum.TabIndex = 4;
            this.labelDatum.Text = "Geboortedatum";
            // 
            // labelKleur
            // 
            this.labelKleur.AutoSize = true;
            this.labelKleur.Location = new System.Drawing.Point(42, 128);
            this.labelKleur.Name = "labelKleur";
            this.labelKleur.Size = new System.Drawing.Size(43, 20);
            this.labelKleur.TabIndex = 3;
            this.labelKleur.Text = "Kleur";
            // 
            // labelRas
            // 
            this.labelRas.AutoSize = true;
            this.labelRas.Location = new System.Drawing.Point(42, 98);
            this.labelRas.Name = "labelRas";
            this.labelRas.Size = new System.Drawing.Size(32, 20);
            this.labelRas.TabIndex = 2;
            this.labelRas.Text = "Ras";
            // 
            // labelSoort
            // 
            this.labelSoort.AutoSize = true;
            this.labelSoort.Location = new System.Drawing.Point(42, 63);
            this.labelSoort.Name = "labelSoort";
            this.labelSoort.Size = new System.Drawing.Size(45, 20);
            this.labelSoort.TabIndex = 1;
            this.labelSoort.Text = "Soort";
            // 
            // labelNaam
            // 
            this.labelNaam.AutoSize = true;
            this.labelNaam.Location = new System.Drawing.Point(42, 30);
            this.labelNaam.Name = "labelNaam";
            this.labelNaam.Size = new System.Drawing.Size(49, 20);
            this.labelNaam.TabIndex = 0;
            this.labelNaam.Text = "Naam";
            // 
            // buttonSelecteer
            // 
            this.buttonSelecteer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelecteer.Location = new System.Drawing.Point(767, 224);
            this.buttonSelecteer.Name = "buttonSelecteer";
            this.buttonSelecteer.Size = new System.Drawing.Size(128, 28);
            this.buttonSelecteer.TabIndex = 4;
            this.buttonSelecteer.Text = "Selecteer dier";
            this.buttonSelecteer.UseVisualStyleBackColor = true;
            this.buttonSelecteer.Click += new System.EventHandler(this.buttonSelecteer_Click);
            // 
            // listBoxDieren
            // 
            this.listBoxDieren.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxDieren.FormattingEnabled = true;
            this.listBoxDieren.ItemHeight = 20;
            this.listBoxDieren.Location = new System.Drawing.Point(45, 54);
            this.listBoxDieren.Name = "listBoxDieren";
            this.listBoxDieren.Size = new System.Drawing.Size(850, 164);
            this.listBoxDieren.TabIndex = 3;
            // 
            // textBoxGeefNaam
            // 
            this.textBoxGeefNaam.Location = new System.Drawing.Point(520, 21);
            this.textBoxGeefNaam.Name = "textBoxGeefNaam";
            this.textBoxGeefNaam.Size = new System.Drawing.Size(198, 27);
            this.textBoxGeefNaam.TabIndex = 2;
            this.textBoxGeefNaam.Text = "Geef naam in";
            // 
            // buttonGeefOpNaam
            // 
            this.buttonGeefOpNaam.Location = new System.Drawing.Point(283, 19);
            this.buttonGeefOpNaam.Name = "buttonGeefOpNaam";
            this.buttonGeefOpNaam.Size = new System.Drawing.Size(211, 29);
            this.buttonGeefOpNaam.TabIndex = 1;
            this.buttonGeefOpNaam.Text = "Zoek op naam";
            this.buttonGeefOpNaam.UseVisualStyleBackColor = true;
            this.buttonGeefOpNaam.Click += new System.EventHandler(this.buttonGeefOpNaam_Click);
            // 
            // buttonToonAlle
            // 
            this.buttonToonAlle.Location = new System.Drawing.Point(45, 19);
            this.buttonToonAlle.Name = "buttonToonAlle";
            this.buttonToonAlle.Size = new System.Drawing.Size(211, 29);
            this.buttonToonAlle.TabIndex = 0;
            this.buttonToonAlle.Text = "Toon alle dieren";
            this.buttonToonAlle.UseVisualStyleBackColor = true;
            this.buttonToonAlle.Click += new System.EventHandler(this.buttonToonAlle_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(935, 531);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonAlleKlanten
            // 
            this.buttonAlleKlanten.Location = new System.Drawing.Point(6, 14);
            this.buttonAlleKlanten.Name = "buttonAlleKlanten";
            this.buttonAlleKlanten.Size = new System.Drawing.Size(131, 29);
            this.buttonAlleKlanten.TabIndex = 0;
            this.buttonAlleKlanten.Text = "Toon klanten";
            this.buttonAlleKlanten.UseVisualStyleBackColor = true;
            // 
            // FormDieren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 585);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.tabControlDieren);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDieren";
            this.Text = "FormDieren";
            this.tabControlDieren.ResumeLayout(false);
            this.tabPageOverzicht.ResumeLayout(false);
            this.tabPageOverzicht.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TabControl tabControlDieren;
        private System.Windows.Forms.TabPage tabPageOverzicht;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonToonAlle;
        private System.Windows.Forms.TextBox textBoxGeefNaam;
        private System.Windows.Forms.Button buttonGeefOpNaam;
        private System.Windows.Forms.ListBox listBoxDieren;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSelecteer;
        private System.Windows.Forms.Label labelSoort;
        private System.Windows.Forms.Label labelNaam;
        private System.Windows.Forms.Label labelRas;
        private System.Windows.Forms.Label labelKleur;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxKleur;
        private System.Windows.Forms.TextBox textBoxRas;
        private System.Windows.Forms.TextBox textBoxSoort;
        private System.Windows.Forms.TextBox textBoxNaam;
        private System.Windows.Forms.ListBox listBoxBaasje;
        private System.Windows.Forms.Label labelBaasje;
        private System.Windows.Forms.TextBox textBoxDatum;
        private System.Windows.Forms.Button buttonVerwijder;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelSelectedDier;
        private System.Windows.Forms.Button buttonAlleKlanten;
    }
}