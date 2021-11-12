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
            this.dateTimePickerDier = new System.Windows.Forms.DateTimePicker();
            this.buttonVerwijder = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.listBoxBaasje = new System.Windows.Forms.ListBox();
            this.labelBaasje = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelSelectedDier = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxKleur = new System.Windows.Forms.TextBox();
            this.textBoxRas = new System.Windows.Forms.TextBox();
            this.textBoxSoort = new System.Windows.Forms.TextBox();
            this.textBoxNaam = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelKleur = new System.Windows.Forms.Label();
            this.labelRas = new System.Windows.Forms.Label();
            this.labelSoort = new System.Windows.Forms.Label();
            this.labelNaam = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSelecteerKlant = new System.Windows.Forms.Button();
            this.listBoxKlanten = new System.Windows.Forms.ListBox();
            this.textBoxNaamKlant = new System.Windows.Forms.TextBox();
            this.buttonNaamKlant = new System.Windows.Forms.Button();
            this.buttonAlleKlanten = new System.Windows.Forms.Button();
            this.buttonSelecteer = new System.Windows.Forms.Button();
            this.listBoxDieren = new System.Windows.Forms.ListBox();
            this.textBoxGeefNaam = new System.Windows.Forms.TextBox();
            this.buttonGeefOpNaam = new System.Windows.Forms.Button();
            this.buttonToonAlle = new System.Windows.Forms.Button();
            this.tabPageVoegToe = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSelKlantNieuw = new System.Windows.Forms.Button();
            this.listBoxKlantenNieuw = new System.Windows.Forms.ListBox();
            this.textBoxOpNaamNieuw = new System.Windows.Forms.TextBox();
            this.buttonOpNaamNieuw = new System.Windows.Forms.Button();
            this.buttonAlleNieuw = new System.Windows.Forms.Button();
            this.buttonVoegToe = new System.Windows.Forms.Button();
            this.dateTimePickerNieuw = new System.Windows.Forms.DateTimePicker();
            this.listBoxBaasjeNieuw = new System.Windows.Forms.ListBox();
            this.textBoxStatusNieuw = new System.Windows.Forms.TextBox();
            this.textBoxKleurNieuw = new System.Windows.Forms.TextBox();
            this.textBoxRasNieuw = new System.Windows.Forms.TextBox();
            this.textBoxSoortNieuw = new System.Windows.Forms.TextBox();
            this.textBoxNaamNieuw = new System.Windows.Forms.TextBox();
            this.labelBaasjeNieuw = new System.Windows.Forms.Label();
            this.labelDatumNieuw = new System.Windows.Forms.Label();
            this.labelStatusNieuw = new System.Windows.Forms.Label();
            this.labelKleurNieuw = new System.Windows.Forms.Label();
            this.labelSoortNieuw = new System.Windows.Forms.Label();
            this.labelRasNieuw = new System.Windows.Forms.Label();
            this.labelNaamNieuw = new System.Windows.Forms.Label();
            this.tabControlDieren.SuspendLayout();
            this.tabPageOverzicht.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPageVoegToe.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.tabControlDieren.Controls.Add(this.tabPageVoegToe);
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
            this.panel1.Controls.Add(this.dateTimePickerDier);
            this.panel1.Controls.Add(this.buttonVerwijder);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.listBoxBaasje);
            this.panel1.Controls.Add(this.labelBaasje);
            this.panel1.Controls.Add(this.labelDatum);
            this.panel1.Controls.Add(this.labelSelectedDier);
            this.panel1.Controls.Add(this.textBoxStatus);
            this.panel1.Controls.Add(this.textBoxKleur);
            this.panel1.Controls.Add(this.textBoxRas);
            this.panel1.Controls.Add(this.textBoxSoort);
            this.panel1.Controls.Add(this.textBoxNaam);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.labelKleur);
            this.panel1.Controls.Add(this.labelRas);
            this.panel1.Controls.Add(this.labelSoort);
            this.panel1.Controls.Add(this.labelNaam);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 270);
            this.panel1.TabIndex = 5;
            // 
            // dateTimePickerDier
            // 
            this.dateTimePickerDier.Location = new System.Drawing.Point(475, 30);
            this.dateTimePickerDier.Name = "dateTimePickerDier";
            this.dateTimePickerDier.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerDier.TabIndex = 6;
            this.dateTimePickerDier.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
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
            this.buttonVerwijder.Click += new System.EventHandler(this.buttonVerwijder_Click);
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
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
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
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(354, 34);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(115, 20);
            this.labelDatum.TabIndex = 4;
            this.labelDatum.Text = "Geboortedatum";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.buttonSelecteerKlant);
            this.panel2.Controls.Add(this.listBoxKlanten);
            this.panel2.Controls.Add(this.textBoxNaamKlant);
            this.panel2.Controls.Add(this.buttonNaamKlant);
            this.panel2.Controls.Add(this.buttonAlleKlanten);
            this.panel2.Location = new System.Drawing.Point(354, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 158);
            this.panel2.TabIndex = 16;
            // 
            // buttonSelecteerKlant
            // 
            this.buttonSelecteerKlant.Location = new System.Drawing.Point(374, 4);
            this.buttonSelecteerKlant.Name = "buttonSelecteerKlant";
            this.buttonSelecteerKlant.Size = new System.Drawing.Size(146, 29);
            this.buttonSelecteerKlant.TabIndex = 4;
            this.buttonSelecteerKlant.Text = "Selecteer klant";
            this.buttonSelecteerKlant.UseVisualStyleBackColor = true;
            this.buttonSelecteerKlant.Click += new System.EventHandler(this.buttonSelecteerKlant_Click);
            // 
            // listBoxKlanten
            // 
            this.listBoxKlanten.FormattingEnabled = true;
            this.listBoxKlanten.ItemHeight = 20;
            this.listBoxKlanten.Location = new System.Drawing.Point(163, 40);
            this.listBoxKlanten.Name = "listBoxKlanten";
            this.listBoxKlanten.Size = new System.Drawing.Size(375, 104);
            this.listBoxKlanten.TabIndex = 3;
            // 
            // textBoxNaamKlant
            // 
            this.textBoxNaamKlant.Location = new System.Drawing.Point(16, 106);
            this.textBoxNaamKlant.Name = "textBoxNaamKlant";
            this.textBoxNaamKlant.Size = new System.Drawing.Size(131, 27);
            this.textBoxNaamKlant.TabIndex = 2;
            this.textBoxNaamKlant.Text = "Geef naam in";
            // 
            // buttonNaamKlant
            // 
            this.buttonNaamKlant.Location = new System.Drawing.Point(16, 60);
            this.buttonNaamKlant.Name = "buttonNaamKlant";
            this.buttonNaamKlant.Size = new System.Drawing.Size(131, 29);
            this.buttonNaamKlant.TabIndex = 1;
            this.buttonNaamKlant.Text = "Zoek op naam";
            this.buttonNaamKlant.UseVisualStyleBackColor = true;
            this.buttonNaamKlant.Click += new System.EventHandler(this.buttonNaamKlant_Click);
            // 
            // buttonAlleKlanten
            // 
            this.buttonAlleKlanten.Location = new System.Drawing.Point(16, 14);
            this.buttonAlleKlanten.Name = "buttonAlleKlanten";
            this.buttonAlleKlanten.Size = new System.Drawing.Size(131, 29);
            this.buttonAlleKlanten.TabIndex = 0;
            this.buttonAlleKlanten.Text = "Toon klanten";
            this.buttonAlleKlanten.UseVisualStyleBackColor = true;
            this.buttonAlleKlanten.Click += new System.EventHandler(this.buttonAlleKlanten_Click);
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
            // tabPageVoegToe
            // 
            this.tabPageVoegToe.Controls.Add(this.panel3);
            this.tabPageVoegToe.Controls.Add(this.buttonVoegToe);
            this.tabPageVoegToe.Controls.Add(this.dateTimePickerNieuw);
            this.tabPageVoegToe.Controls.Add(this.listBoxBaasjeNieuw);
            this.tabPageVoegToe.Controls.Add(this.textBoxStatusNieuw);
            this.tabPageVoegToe.Controls.Add(this.textBoxKleurNieuw);
            this.tabPageVoegToe.Controls.Add(this.textBoxRasNieuw);
            this.tabPageVoegToe.Controls.Add(this.textBoxSoortNieuw);
            this.tabPageVoegToe.Controls.Add(this.textBoxNaamNieuw);
            this.tabPageVoegToe.Controls.Add(this.labelBaasjeNieuw);
            this.tabPageVoegToe.Controls.Add(this.labelDatumNieuw);
            this.tabPageVoegToe.Controls.Add(this.labelStatusNieuw);
            this.tabPageVoegToe.Controls.Add(this.labelKleurNieuw);
            this.tabPageVoegToe.Controls.Add(this.labelSoortNieuw);
            this.tabPageVoegToe.Controls.Add(this.labelRasNieuw);
            this.tabPageVoegToe.Controls.Add(this.labelNaamNieuw);
            this.tabPageVoegToe.Location = new System.Drawing.Point(4, 29);
            this.tabPageVoegToe.Name = "tabPageVoegToe";
            this.tabPageVoegToe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVoegToe.Size = new System.Drawing.Size(935, 531);
            this.tabPageVoegToe.TabIndex = 1;
            this.tabPageVoegToe.Text = "Nieuw dier";
            this.tabPageVoegToe.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.buttonSelKlantNieuw);
            this.panel3.Controls.Add(this.listBoxKlantenNieuw);
            this.panel3.Controls.Add(this.textBoxOpNaamNieuw);
            this.panel3.Controls.Add(this.buttonOpNaamNieuw);
            this.panel3.Controls.Add(this.buttonAlleNieuw);
            this.panel3.Location = new System.Drawing.Point(353, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 250);
            this.panel3.TabIndex = 15;
            // 
            // buttonSelKlantNieuw
            // 
            this.buttonSelKlantNieuw.Location = new System.Drawing.Point(393, 20);
            this.buttonSelKlantNieuw.Name = "buttonSelKlantNieuw";
            this.buttonSelKlantNieuw.Size = new System.Drawing.Size(134, 29);
            this.buttonSelKlantNieuw.TabIndex = 4;
            this.buttonSelKlantNieuw.Text = "Selecteer klant";
            this.buttonSelKlantNieuw.UseVisualStyleBackColor = true;
            this.buttonSelKlantNieuw.Click += new System.EventHandler(this.buttonSelKlantNieuw_Click);
            // 
            // listBoxKlantenNieuw
            // 
            this.listBoxKlantenNieuw.FormattingEnabled = true;
            this.listBoxKlantenNieuw.ItemHeight = 20;
            this.listBoxKlantenNieuw.Location = new System.Drawing.Point(169, 66);
            this.listBoxKlantenNieuw.Name = "listBoxKlantenNieuw";
            this.listBoxKlantenNieuw.Size = new System.Drawing.Size(368, 164);
            this.listBoxKlantenNieuw.TabIndex = 3;
            // 
            // textBoxOpNaamNieuw
            // 
            this.textBoxOpNaamNieuw.Location = new System.Drawing.Point(13, 111);
            this.textBoxOpNaamNieuw.Name = "textBoxOpNaamNieuw";
            this.textBoxOpNaamNieuw.Size = new System.Drawing.Size(139, 27);
            this.textBoxOpNaamNieuw.TabIndex = 2;
            this.textBoxOpNaamNieuw.Text = "Geef naam in";
            // 
            // buttonOpNaamNieuw
            // 
            this.buttonOpNaamNieuw.Location = new System.Drawing.Point(13, 65);
            this.buttonOpNaamNieuw.Name = "buttonOpNaamNieuw";
            this.buttonOpNaamNieuw.Size = new System.Drawing.Size(139, 29);
            this.buttonOpNaamNieuw.TabIndex = 1;
            this.buttonOpNaamNieuw.Text = "Zoek op naam";
            this.buttonOpNaamNieuw.UseVisualStyleBackColor = true;
            this.buttonOpNaamNieuw.Click += new System.EventHandler(this.buttonOpNaamNieuw_Click);
            // 
            // buttonAlleNieuw
            // 
            this.buttonAlleNieuw.Location = new System.Drawing.Point(13, 20);
            this.buttonAlleNieuw.Name = "buttonAlleNieuw";
            this.buttonAlleNieuw.Size = new System.Drawing.Size(139, 29);
            this.buttonAlleNieuw.TabIndex = 0;
            this.buttonAlleNieuw.Text = "Toon alle klanten";
            this.buttonAlleNieuw.UseVisualStyleBackColor = true;
            this.buttonAlleNieuw.Click += new System.EventHandler(this.buttonAlleNieuw_Click);
            // 
            // buttonVoegToe
            // 
            this.buttonVoegToe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVoegToe.Location = new System.Drawing.Point(670, 461);
            this.buttonVoegToe.Name = "buttonVoegToe";
            this.buttonVoegToe.Size = new System.Drawing.Size(237, 44);
            this.buttonVoegToe.TabIndex = 14;
            this.buttonVoegToe.Text = "Voeg nieuw dier toe";
            this.buttonVoegToe.UseVisualStyleBackColor = true;
            this.buttonVoegToe.Click += new System.EventHandler(this.buttonVoegToe_Click);
            // 
            // dateTimePickerNieuw
            // 
            this.dateTimePickerNieuw.Location = new System.Drawing.Point(480, 68);
            this.dateTimePickerNieuw.Name = "dateTimePickerNieuw";
            this.dateTimePickerNieuw.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerNieuw.TabIndex = 13;
            // 
            // listBoxBaasjeNieuw
            // 
            this.listBoxBaasjeNieuw.FormattingEnabled = true;
            this.listBoxBaasjeNieuw.ItemHeight = 20;
            this.listBoxBaasjeNieuw.Location = new System.Drawing.Point(480, 120);
            this.listBoxBaasjeNieuw.Name = "listBoxBaasjeNieuw";
            this.listBoxBaasjeNieuw.Size = new System.Drawing.Size(185, 24);
            this.listBoxBaasjeNieuw.TabIndex = 12;
            // 
            // textBoxStatusNieuw
            // 
            this.textBoxStatusNieuw.Location = new System.Drawing.Point(51, 324);
            this.textBoxStatusNieuw.Name = "textBoxStatusNieuw";
            this.textBoxStatusNieuw.Size = new System.Drawing.Size(248, 27);
            this.textBoxStatusNieuw.TabIndex = 11;
            // 
            // textBoxKleurNieuw
            // 
            this.textBoxKleurNieuw.Location = new System.Drawing.Point(131, 223);
            this.textBoxKleurNieuw.Name = "textBoxKleurNieuw";
            this.textBoxKleurNieuw.Size = new System.Drawing.Size(168, 27);
            this.textBoxKleurNieuw.TabIndex = 10;
            // 
            // textBoxRasNieuw
            // 
            this.textBoxRasNieuw.Location = new System.Drawing.Point(131, 177);
            this.textBoxRasNieuw.Name = "textBoxRasNieuw";
            this.textBoxRasNieuw.Size = new System.Drawing.Size(168, 27);
            this.textBoxRasNieuw.TabIndex = 9;
            // 
            // textBoxSoortNieuw
            // 
            this.textBoxSoortNieuw.Location = new System.Drawing.Point(131, 126);
            this.textBoxSoortNieuw.Name = "textBoxSoortNieuw";
            this.textBoxSoortNieuw.Size = new System.Drawing.Size(168, 27);
            this.textBoxSoortNieuw.TabIndex = 8;
            // 
            // textBoxNaamNieuw
            // 
            this.textBoxNaamNieuw.Location = new System.Drawing.Point(131, 65);
            this.textBoxNaamNieuw.Name = "textBoxNaamNieuw";
            this.textBoxNaamNieuw.Size = new System.Drawing.Size(168, 27);
            this.textBoxNaamNieuw.TabIndex = 7;
            // 
            // labelBaasjeNieuw
            // 
            this.labelBaasjeNieuw.AutoSize = true;
            this.labelBaasjeNieuw.Location = new System.Drawing.Point(353, 120);
            this.labelBaasjeNieuw.Name = "labelBaasjeNieuw";
            this.labelBaasjeNieuw.Size = new System.Drawing.Size(52, 20);
            this.labelBaasjeNieuw.TabIndex = 6;
            this.labelBaasjeNieuw.Text = "Baasje";
            // 
            // labelDatumNieuw
            // 
            this.labelDatumNieuw.AutoSize = true;
            this.labelDatumNieuw.Location = new System.Drawing.Point(353, 68);
            this.labelDatumNieuw.Name = "labelDatumNieuw";
            this.labelDatumNieuw.Size = new System.Drawing.Size(115, 20);
            this.labelDatumNieuw.TabIndex = 5;
            this.labelDatumNieuw.Text = "Geboortedatum";
            // 
            // labelStatusNieuw
            // 
            this.labelStatusNieuw.AutoSize = true;
            this.labelStatusNieuw.Location = new System.Drawing.Point(51, 288);
            this.labelStatusNieuw.Name = "labelStatusNieuw";
            this.labelStatusNieuw.Size = new System.Drawing.Size(136, 20);
            this.labelStatusNieuw.TabIndex = 4;
            this.labelStatusNieuw.Text = "Gezondheidsstatus:";
            // 
            // labelKleurNieuw
            // 
            this.labelKleurNieuw.AutoSize = true;
            this.labelKleurNieuw.Location = new System.Drawing.Point(51, 226);
            this.labelKleurNieuw.Name = "labelKleurNieuw";
            this.labelKleurNieuw.Size = new System.Drawing.Size(43, 20);
            this.labelKleurNieuw.TabIndex = 3;
            this.labelKleurNieuw.Text = "Kleur";
            // 
            // labelSoortNieuw
            // 
            this.labelSoortNieuw.AutoSize = true;
            this.labelSoortNieuw.Location = new System.Drawing.Point(51, 129);
            this.labelSoortNieuw.Name = "labelSoortNieuw";
            this.labelSoortNieuw.Size = new System.Drawing.Size(45, 20);
            this.labelSoortNieuw.TabIndex = 2;
            this.labelSoortNieuw.Text = "Soort";
            // 
            // labelRasNieuw
            // 
            this.labelRasNieuw.AutoSize = true;
            this.labelRasNieuw.Location = new System.Drawing.Point(51, 180);
            this.labelRasNieuw.Name = "labelRasNieuw";
            this.labelRasNieuw.Size = new System.Drawing.Size(32, 20);
            this.labelRasNieuw.TabIndex = 1;
            this.labelRasNieuw.Text = "Ras";
            // 
            // labelNaamNieuw
            // 
            this.labelNaamNieuw.AutoSize = true;
            this.labelNaamNieuw.Location = new System.Drawing.Point(51, 68);
            this.labelNaamNieuw.Name = "labelNaamNieuw";
            this.labelNaamNieuw.Size = new System.Drawing.Size(49, 20);
            this.labelNaamNieuw.TabIndex = 0;
            this.labelNaamNieuw.Text = "Naam";
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
            this.panel2.PerformLayout();
            this.tabPageVoegToe.ResumeLayout(false);
            this.tabPageVoegToe.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TabControl tabControlDieren;
        private System.Windows.Forms.TabPage tabPageOverzicht;
        private System.Windows.Forms.TabPage tabPageVoegToe;
        private System.Windows.Forms.Button buttonNaamKlant;
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
        private System.Windows.Forms.Button buttonVerwijder;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelSelectedDier;
        private System.Windows.Forms.Button buttonAlleKlanten;
        private System.Windows.Forms.ListBox listBoxKlanten;
        private System.Windows.Forms.TextBox textBoxNaamKlant;
        private System.Windows.Forms.Button buttonSelecteerKlant;
        private System.Windows.Forms.DateTimePicker dateTimePickerDier;
        private System.Windows.Forms.Label labelDatumNieuw;
        private System.Windows.Forms.Label labelStatusNieuw;
        private System.Windows.Forms.Label labelKleurNieuw;
        private System.Windows.Forms.Label labelSoortNieuw;
        private System.Windows.Forms.Label labelRasNieuw;
        private System.Windows.Forms.Label labelNaamNieuw;
        private System.Windows.Forms.Label labelBaasjeNieuw;
        private System.Windows.Forms.TextBox textBoxStatusNieuw;
        private System.Windows.Forms.TextBox textBoxKleurNieuw;
        private System.Windows.Forms.TextBox textBoxRasNieuw;
        private System.Windows.Forms.TextBox textBoxSoortNieuw;
        private System.Windows.Forms.TextBox textBoxNaamNieuw;
        private System.Windows.Forms.DateTimePicker dateTimePickerNieuw;
        private System.Windows.Forms.ListBox listBoxBaasjeNieuw;
        private System.Windows.Forms.Button buttonVoegToe;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonAlleNieuw;
        private System.Windows.Forms.Button buttonSelKlantNieuw;
        private System.Windows.Forms.ListBox listBoxKlantenNieuw;
        private System.Windows.Forms.TextBox textBoxOpNaamNieuw;
        private System.Windows.Forms.Button buttonOpNaamNieuw;
    }
}