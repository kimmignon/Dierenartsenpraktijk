namespace Dierenartsenpraktijk.Forms
{
    partial class FormAfspraken
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOverzicht = new System.Windows.Forms.TabPage();
            this.tabPageNieuweAfspraak = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelReden = new System.Windows.Forms.Label();
            this.buttonVoegToe = new System.Windows.Forms.Button();
            this.panelDierenartsNieuw = new System.Windows.Forms.Panel();
            this.listBoxAListNieuw = new System.Windows.Forms.ListBox();
            this.buttonSelectAN = new System.Windows.Forms.Button();
            this.textBoxNaamAN = new System.Windows.Forms.TextBox();
            this.buttonNaamAN = new System.Windows.Forms.Button();
            this.buttonAlleAN = new System.Windows.Forms.Button();
            this.labelKlantNieuw = new System.Windows.Forms.Label();
            this.listBoxKlantNieuw = new System.Windows.Forms.ListBox();
            this.listBoxArtsNieuw = new System.Windows.Forms.ListBox();
            this.labelDierenartsNieuw = new System.Windows.Forms.Label();
            this.dateTimePickerNieuw = new System.Windows.Forms.DateTimePicker();
            this.labelDatumTijdNieuw = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxDListNieuw = new System.Windows.Forms.ListBox();
            this.buttonSelDN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAlleKN = new System.Windows.Forms.Button();
            this.buttonOpNaamKN = new System.Windows.Forms.Button();
            this.listBoxKListNieuw = new System.Windows.Forms.ListBox();
            this.buttonSelKN = new System.Windows.Forms.Button();
            this.textBoxNaamKN = new System.Windows.Forms.TextBox();
            this.listBoxDierNieuw = new System.Windows.Forms.ListBox();
            this.labelDierNieuw = new System.Windows.Forms.Label();
            this.buttonToonAlles = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPageOverzicht.SuspendLayout();
            this.tabPageNieuweAfspraak.SuspendLayout();
            this.panelDierenartsNieuw.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(897, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(34, 29);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageOverzicht);
            this.tabControl1.Controls.Add(this.tabPageNieuweAfspraak);
            this.tabControl1.Location = new System.Drawing.Point(-2, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(947, 563);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageOverzicht
            // 
            this.tabPageOverzicht.Controls.Add(this.listBox1);
            this.tabPageOverzicht.Controls.Add(this.buttonToonAlles);
            this.tabPageOverzicht.Location = new System.Drawing.Point(4, 29);
            this.tabPageOverzicht.Name = "tabPageOverzicht";
            this.tabPageOverzicht.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOverzicht.Size = new System.Drawing.Size(939, 530);
            this.tabPageOverzicht.TabIndex = 0;
            this.tabPageOverzicht.Text = "Overzicht";
            this.tabPageOverzicht.UseVisualStyleBackColor = true;
            // 
            // tabPageNieuweAfspraak
            // 
            this.tabPageNieuweAfspraak.Controls.Add(this.comboBox1);
            this.tabPageNieuweAfspraak.Controls.Add(this.labelReden);
            this.tabPageNieuweAfspraak.Controls.Add(this.buttonVoegToe);
            this.tabPageNieuweAfspraak.Controls.Add(this.panelDierenartsNieuw);
            this.tabPageNieuweAfspraak.Controls.Add(this.labelKlantNieuw);
            this.tabPageNieuweAfspraak.Controls.Add(this.listBoxKlantNieuw);
            this.tabPageNieuweAfspraak.Controls.Add(this.listBoxArtsNieuw);
            this.tabPageNieuweAfspraak.Controls.Add(this.labelDierenartsNieuw);
            this.tabPageNieuweAfspraak.Controls.Add(this.dateTimePickerNieuw);
            this.tabPageNieuweAfspraak.Controls.Add(this.labelDatumTijdNieuw);
            this.tabPageNieuweAfspraak.Controls.Add(this.panel2);
            this.tabPageNieuweAfspraak.Controls.Add(this.panel1);
            this.tabPageNieuweAfspraak.Controls.Add(this.listBoxDierNieuw);
            this.tabPageNieuweAfspraak.Controls.Add(this.labelDierNieuw);
            this.tabPageNieuweAfspraak.Location = new System.Drawing.Point(4, 29);
            this.tabPageNieuweAfspraak.Name = "tabPageNieuweAfspraak";
            this.tabPageNieuweAfspraak.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNieuweAfspraak.Size = new System.Drawing.Size(939, 530);
            this.tabPageNieuweAfspraak.TabIndex = 1;
            this.tabPageNieuweAfspraak.Text = "Nieuwe Afspraak";
            this.tabPageNieuweAfspraak.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BinnenbrengenOperatie",
            "Ophalen",
            "Consult",
            "Vaccinatie"});
            this.comboBox1.Location = new System.Drawing.Point(10, 363);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 28);
            this.comboBox1.TabIndex = 14;
            // 
            // labelReden
            // 
            this.labelReden.AutoSize = true;
            this.labelReden.Location = new System.Drawing.Point(6, 340);
            this.labelReden.Name = "labelReden";
            this.labelReden.Size = new System.Drawing.Size(105, 20);
            this.labelReden.TabIndex = 13;
            this.labelReden.Text = "Reden consult:";
            // 
            // buttonVoegToe
            // 
            this.buttonVoegToe.Location = new System.Drawing.Point(62, 445);
            this.buttonVoegToe.Name = "buttonVoegToe";
            this.buttonVoegToe.Size = new System.Drawing.Size(235, 46);
            this.buttonVoegToe.TabIndex = 12;
            this.buttonVoegToe.Text = "Voeg afspraak toe";
            this.buttonVoegToe.UseVisualStyleBackColor = true;
            this.buttonVoegToe.Click += new System.EventHandler(this.buttonVoegToe_Click);
            // 
            // panelDierenartsNieuw
            // 
            this.panelDierenartsNieuw.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelDierenartsNieuw.Controls.Add(this.listBoxAListNieuw);
            this.panelDierenartsNieuw.Controls.Add(this.buttonSelectAN);
            this.panelDierenartsNieuw.Controls.Add(this.textBoxNaamAN);
            this.panelDierenartsNieuw.Controls.Add(this.buttonNaamAN);
            this.panelDierenartsNieuw.Controls.Add(this.buttonAlleAN);
            this.panelDierenartsNieuw.Location = new System.Drawing.Point(3, 86);
            this.panelDierenartsNieuw.Name = "panelDierenartsNieuw";
            this.panelDierenartsNieuw.Size = new System.Drawing.Size(387, 235);
            this.panelDierenartsNieuw.TabIndex = 11;
            // 
            // listBoxAListNieuw
            // 
            this.listBoxAListNieuw.FormattingEnabled = true;
            this.listBoxAListNieuw.ItemHeight = 20;
            this.listBoxAListNieuw.Location = new System.Drawing.Point(3, 106);
            this.listBoxAListNieuw.Name = "listBoxAListNieuw";
            this.listBoxAListNieuw.ScrollAlwaysVisible = true;
            this.listBoxAListNieuw.Size = new System.Drawing.Size(351, 124);
            this.listBoxAListNieuw.TabIndex = 5;
            // 
            // buttonSelectAN
            // 
            this.buttonSelectAN.Location = new System.Drawing.Point(221, 38);
            this.buttonSelectAN.Name = "buttonSelectAN";
            this.buttonSelectAN.Size = new System.Drawing.Size(149, 29);
            this.buttonSelectAN.TabIndex = 4;
            this.buttonSelectAN.Text = "Selecteer dierenarts";
            this.buttonSelectAN.UseVisualStyleBackColor = true;
            this.buttonSelectAN.Click += new System.EventHandler(this.buttonSelectAN_Click);
            // 
            // textBoxNaamAN
            // 
            this.textBoxNaamAN.Location = new System.Drawing.Point(3, 73);
            this.textBoxNaamAN.Name = "textBoxNaamAN";
            this.textBoxNaamAN.Size = new System.Drawing.Size(203, 27);
            this.textBoxNaamAN.TabIndex = 2;
            this.textBoxNaamAN.Text = "Geef naam in";
            // 
            // buttonNaamAN
            // 
            this.buttonNaamAN.Location = new System.Drawing.Point(3, 38);
            this.buttonNaamAN.Name = "buttonNaamAN";
            this.buttonNaamAN.Size = new System.Drawing.Size(200, 29);
            this.buttonNaamAN.TabIndex = 1;
            this.buttonNaamAN.Text = "Toon dierenartsen op naam";
            this.buttonNaamAN.UseVisualStyleBackColor = true;
            this.buttonNaamAN.Click += new System.EventHandler(this.buttonNaamAN_Click);
            // 
            // buttonAlleAN
            // 
            this.buttonAlleAN.Location = new System.Drawing.Point(3, 3);
            this.buttonAlleAN.Name = "buttonAlleAN";
            this.buttonAlleAN.Size = new System.Drawing.Size(200, 29);
            this.buttonAlleAN.TabIndex = 0;
            this.buttonAlleAN.Text = "Toon alle dierenartsen";
            this.buttonAlleAN.UseVisualStyleBackColor = true;
            this.buttonAlleAN.Click += new System.EventHandler(this.buttonAlleAN_Click);
            // 
            // labelKlantNieuw
            // 
            this.labelKlantNieuw.AutoSize = true;
            this.labelKlantNieuw.Location = new System.Drawing.Point(414, 20);
            this.labelKlantNieuw.Name = "labelKlantNieuw";
            this.labelKlantNieuw.Size = new System.Drawing.Size(43, 20);
            this.labelKlantNieuw.TabIndex = 4;
            this.labelKlantNieuw.Text = "Klant";
            // 
            // listBoxKlantNieuw
            // 
            this.listBoxKlantNieuw.FormattingEnabled = true;
            this.listBoxKlantNieuw.ItemHeight = 20;
            this.listBoxKlantNieuw.Location = new System.Drawing.Point(463, 16);
            this.listBoxKlantNieuw.Name = "listBoxKlantNieuw";
            this.listBoxKlantNieuw.Size = new System.Drawing.Size(250, 24);
            this.listBoxKlantNieuw.TabIndex = 8;
            // 
            // listBoxArtsNieuw
            // 
            this.listBoxArtsNieuw.FormattingEnabled = true;
            this.listBoxArtsNieuw.ItemHeight = 20;
            this.listBoxArtsNieuw.Location = new System.Drawing.Point(137, 59);
            this.listBoxArtsNieuw.Name = "listBoxArtsNieuw";
            this.listBoxArtsNieuw.Size = new System.Drawing.Size(253, 24);
            this.listBoxArtsNieuw.TabIndex = 7;
            // 
            // labelDierenartsNieuw
            // 
            this.labelDierenartsNieuw.AutoSize = true;
            this.labelDierenartsNieuw.Location = new System.Drawing.Point(33, 63);
            this.labelDierenartsNieuw.Name = "labelDierenartsNieuw";
            this.labelDierenartsNieuw.Size = new System.Drawing.Size(77, 20);
            this.labelDierenartsNieuw.TabIndex = 1;
            this.labelDierenartsNieuw.Text = "Dierenarts";
            // 
            // dateTimePickerNieuw
            // 
            this.dateTimePickerNieuw.Location = new System.Drawing.Point(134, 20);
            this.dateTimePickerNieuw.Name = "dateTimePickerNieuw";
            this.dateTimePickerNieuw.Size = new System.Drawing.Size(256, 27);
            this.dateTimePickerNieuw.TabIndex = 3;
            // 
            // labelDatumTijdNieuw
            // 
            this.labelDatumTijdNieuw.AutoSize = true;
            this.labelDatumTijdNieuw.Location = new System.Drawing.Point(33, 25);
            this.labelDatumTijdNieuw.Name = "labelDatumTijdNieuw";
            this.labelDatumTijdNieuw.Size = new System.Drawing.Size(58, 20);
            this.labelDatumTijdNieuw.TabIndex = 0;
            this.labelDatumTijdNieuw.Text = "Tijdstip";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.listBoxDListNieuw);
            this.panel2.Controls.Add(this.buttonSelDN);
            this.panel2.Location = new System.Drawing.Point(414, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 202);
            this.panel2.TabIndex = 8;
            // 
            // listBoxDListNieuw
            // 
            this.listBoxDListNieuw.FormattingEnabled = true;
            this.listBoxDListNieuw.ItemHeight = 20;
            this.listBoxDListNieuw.Location = new System.Drawing.Point(3, 6);
            this.listBoxDListNieuw.Name = "listBoxDListNieuw";
            this.listBoxDListNieuw.ScrollAlwaysVisible = true;
            this.listBoxDListNieuw.Size = new System.Drawing.Size(351, 184);
            this.listBoxDListNieuw.TabIndex = 5;
            // 
            // buttonSelDN
            // 
            this.buttonSelDN.Location = new System.Drawing.Point(370, 51);
            this.buttonSelDN.Name = "buttonSelDN";
            this.buttonSelDN.Size = new System.Drawing.Size(149, 29);
            this.buttonSelDN.TabIndex = 4;
            this.buttonSelDN.Text = "Selecteer dier";
            this.buttonSelDN.UseVisualStyleBackColor = true;
            this.buttonSelDN.Click += new System.EventHandler(this.buttonSelDN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.buttonAlleKN);
            this.panel1.Controls.Add(this.buttonOpNaamKN);
            this.panel1.Controls.Add(this.listBoxKListNieuw);
            this.panel1.Controls.Add(this.buttonSelKN);
            this.panel1.Controls.Add(this.textBoxNaamKN);
            this.panel1.Location = new System.Drawing.Point(414, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 202);
            this.panel1.TabIndex = 7;
            // 
            // buttonAlleKN
            // 
            this.buttonAlleKN.Location = new System.Drawing.Point(192, 3);
            this.buttonAlleKN.Name = "buttonAlleKN";
            this.buttonAlleKN.Size = new System.Drawing.Size(179, 29);
            this.buttonAlleKN.TabIndex = 0;
            this.buttonAlleKN.Text = "Toon alle klanten";
            this.buttonAlleKN.UseVisualStyleBackColor = true;
            this.buttonAlleKN.Click += new System.EventHandler(this.buttonAlleKN_Click);
            // 
            // buttonOpNaamKN
            // 
            this.buttonOpNaamKN.Location = new System.Drawing.Point(6, 3);
            this.buttonOpNaamKN.Name = "buttonOpNaamKN";
            this.buttonOpNaamKN.Size = new System.Drawing.Size(177, 29);
            this.buttonOpNaamKN.TabIndex = 1;
            this.buttonOpNaamKN.Text = "Toon klanten op naam";
            this.buttonOpNaamKN.UseVisualStyleBackColor = true;
            this.buttonOpNaamKN.Click += new System.EventHandler(this.buttonOpNaamKN_Click);
            // 
            // listBoxKListNieuw
            // 
            this.listBoxKListNieuw.FormattingEnabled = true;
            this.listBoxKListNieuw.ItemHeight = 20;
            this.listBoxKListNieuw.Location = new System.Drawing.Point(3, 66);
            this.listBoxKListNieuw.Name = "listBoxKListNieuw";
            this.listBoxKListNieuw.ScrollAlwaysVisible = true;
            this.listBoxKListNieuw.Size = new System.Drawing.Size(351, 124);
            this.listBoxKListNieuw.TabIndex = 5;
            // 
            // buttonSelKN
            // 
            this.buttonSelKN.Location = new System.Drawing.Point(370, 51);
            this.buttonSelKN.Name = "buttonSelKN";
            this.buttonSelKN.Size = new System.Drawing.Size(149, 29);
            this.buttonSelKN.TabIndex = 4;
            this.buttonSelKN.Text = "Selecteer klant";
            this.buttonSelKN.UseVisualStyleBackColor = true;
            this.buttonSelKN.Click += new System.EventHandler(this.buttonSelKN_Click);
            // 
            // textBoxNaamKN
            // 
            this.textBoxNaamKN.Location = new System.Drawing.Point(6, 38);
            this.textBoxNaamKN.Name = "textBoxNaamKN";
            this.textBoxNaamKN.Size = new System.Drawing.Size(177, 27);
            this.textBoxNaamKN.TabIndex = 2;
            this.textBoxNaamKN.Text = "Geef naam in";
            // 
            // listBoxDierNieuw
            // 
            this.listBoxDierNieuw.FormattingEnabled = true;
            this.listBoxDierNieuw.ItemHeight = 20;
            this.listBoxDierNieuw.Location = new System.Drawing.Point(463, 271);
            this.listBoxDierNieuw.Name = "listBoxDierNieuw";
            this.listBoxDierNieuw.Size = new System.Drawing.Size(250, 24);
            this.listBoxDierNieuw.TabIndex = 9;
            // 
            // labelDierNieuw
            // 
            this.labelDierNieuw.AutoSize = true;
            this.labelDierNieuw.Location = new System.Drawing.Point(414, 271);
            this.labelDierNieuw.Name = "labelDierNieuw";
            this.labelDierNieuw.Size = new System.Drawing.Size(37, 20);
            this.labelDierNieuw.TabIndex = 5;
            this.labelDierNieuw.Text = "Dier";
            // 
            // buttonToonAlles
            // 
            this.buttonToonAlles.Location = new System.Drawing.Point(10, 16);
            this.buttonToonAlles.Name = "buttonToonAlles";
            this.buttonToonAlles.Size = new System.Drawing.Size(155, 29);
            this.buttonToonAlles.TabIndex = 0;
            this.buttonToonAlles.Text = "Toon alle afspraken";
            this.buttonToonAlles.UseVisualStyleBackColor = true;
            this.buttonToonAlles.Click += new System.EventHandler(this.buttonToonAlles_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(10, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(919, 164);
            this.listBox1.TabIndex = 1;
            // 
            // FormAfspraken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 585);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAfspraken";
            this.Text = "FormAfspraken";
            this.tabControl1.ResumeLayout(false);
            this.tabPageOverzicht.ResumeLayout(false);
            this.tabPageNieuweAfspraak.ResumeLayout(false);
            this.tabPageNieuweAfspraak.PerformLayout();
            this.panelDierenartsNieuw.ResumeLayout(false);
            this.panelDierenartsNieuw.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageOverzicht;
        private System.Windows.Forms.TabPage tabPageNieuweAfspraak;
        private System.Windows.Forms.Label labelDierenartsNieuw;
        private System.Windows.Forms.Label labelDatumTijdNieuw;
        private System.Windows.Forms.DateTimePicker dateTimePickerNieuw;
        private System.Windows.Forms.Label labelDierNieuw;
        private System.Windows.Forms.Label labelKlantNieuw;
        private System.Windows.Forms.ListBox listBoxArtsNieuw;
        private System.Windows.Forms.ListBox listBoxDierNieuw;
        private System.Windows.Forms.ListBox listBoxKlantNieuw;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBoxDListNieuw;
        private System.Windows.Forms.Button buttonSelDN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxKListNieuw;
        private System.Windows.Forms.Button buttonSelKN;
        private System.Windows.Forms.TextBox textBoxNaamKN;
        private System.Windows.Forms.Button buttonOpNaamKN;
        private System.Windows.Forms.Button buttonAlleKN;
        private System.Windows.Forms.Panel panelDierenartsNieuw;
        private System.Windows.Forms.ListBox listBoxAListNieuw;
        private System.Windows.Forms.Button buttonSelectAN;
        private System.Windows.Forms.TextBox textBoxNaamAN;
        private System.Windows.Forms.Button buttonNaamAN;
        private System.Windows.Forms.Button buttonAlleAN;
        private System.Windows.Forms.Button buttonVoegToe;
        private System.Windows.Forms.Label labelReden;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonToonAlles;
        private System.Windows.Forms.ListBox listBox1;
    }
}