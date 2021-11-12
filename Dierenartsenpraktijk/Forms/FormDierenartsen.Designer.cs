namespace Dierenartsenpraktijk.Forms
{
    partial class FormDierenartsen
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageOverzicht = new System.Windows.Forms.TabPage();
            this.buttonSelecteer = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonVerwijder = new System.Windows.Forms.Button();
            this.labelSelectedArts = new System.Windows.Forms.Label();
            this.textBoxSpecialisatie = new System.Windows.Forms.TextBox();
            this.labelSpecialisatie = new System.Windows.Forms.Label();
            this.textBoxTelefoonnummer = new System.Windows.Forms.TextBox();
            this.labelTelefoonnummer = new System.Windows.Forms.Label();
            this.textBoxAchternaam = new System.Windows.Forms.TextBox();
            this.labelAchternaam = new System.Windows.Forms.Label();
            this.labelVoornaam = new System.Windows.Forms.Label();
            this.textBoxVoornaam = new System.Windows.Forms.TextBox();
            this.buttonZoekOpNaam = new System.Windows.Forms.Button();
            this.listBoxDierenartsen = new System.Windows.Forms.ListBox();
            this.textBoxNaamIngave = new System.Windows.Forms.TextBox();
            this.buttonToonAlle = new System.Windows.Forms.Button();
            this.tabPageNieuwe = new System.Windows.Forms.TabPage();
            this.textBoxSpecialisatieNieuwe = new System.Windows.Forms.TextBox();
            this.textBoxTelefoonNieuwe = new System.Windows.Forms.TextBox();
            this.textBoxAchternaamNieuwe = new System.Windows.Forms.TextBox();
            this.textBoxVoornaamNieuwe = new System.Windows.Forms.TextBox();
            this.labelSpecialisatieNieuwe = new System.Windows.Forms.Label();
            this.labelTelefoonNieuwe = new System.Windows.Forms.Label();
            this.labelAchternaamNieuwe = new System.Windows.Forms.Label();
            this.labelVoornaamNieuw = new System.Windows.Forms.Label();
            this.buttonVoegToe = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageOverzicht.SuspendLayout();
            this.tabPageNieuwe.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(886, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(33, 35);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageOverzicht);
            this.tabControl.Controls.Add(this.tabPageNieuwe);
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(943, 561);
            this.tabControl.TabIndex = 1;
            this.tabControl.Tag = "";
            // 
            // tabPageOverzicht
            // 
            this.tabPageOverzicht.Controls.Add(this.buttonSelecteer);
            this.tabPageOverzicht.Controls.Add(this.buttonUpdate);
            this.tabPageOverzicht.Controls.Add(this.buttonVerwijder);
            this.tabPageOverzicht.Controls.Add(this.labelSelectedArts);
            this.tabPageOverzicht.Controls.Add(this.textBoxSpecialisatie);
            this.tabPageOverzicht.Controls.Add(this.labelSpecialisatie);
            this.tabPageOverzicht.Controls.Add(this.textBoxTelefoonnummer);
            this.tabPageOverzicht.Controls.Add(this.labelTelefoonnummer);
            this.tabPageOverzicht.Controls.Add(this.textBoxAchternaam);
            this.tabPageOverzicht.Controls.Add(this.labelAchternaam);
            this.tabPageOverzicht.Controls.Add(this.labelVoornaam);
            this.tabPageOverzicht.Controls.Add(this.textBoxVoornaam);
            this.tabPageOverzicht.Controls.Add(this.buttonZoekOpNaam);
            this.tabPageOverzicht.Controls.Add(this.listBoxDierenartsen);
            this.tabPageOverzicht.Controls.Add(this.textBoxNaamIngave);
            this.tabPageOverzicht.Controls.Add(this.buttonToonAlle);
            this.tabPageOverzicht.Location = new System.Drawing.Point(4, 29);
            this.tabPageOverzicht.Name = "tabPageOverzicht";
            this.tabPageOverzicht.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOverzicht.Size = new System.Drawing.Size(935, 528);
            this.tabPageOverzicht.TabIndex = 0;
            this.tabPageOverzicht.Text = "Overzicht";
            this.tabPageOverzicht.UseVisualStyleBackColor = true;
            // 
            // buttonSelecteer
            // 
            this.buttonSelecteer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelecteer.Location = new System.Drawing.Point(739, 260);
            this.buttonSelecteer.Name = "buttonSelecteer";
            this.buttonSelecteer.Size = new System.Drawing.Size(150, 31);
            this.buttonSelecteer.TabIndex = 15;
            this.buttonSelecteer.Text = "Selecteer dierenarts";
            this.buttonSelecteer.UseVisualStyleBackColor = true;
            this.buttonSelecteer.Click += new System.EventHandler(this.buttonSelecteer_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(680, 456);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(209, 47);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "Update gegevens";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonVerwijder
            // 
            this.buttonVerwijder.Location = new System.Drawing.Point(44, 474);
            this.buttonVerwijder.Name = "buttonVerwijder";
            this.buttonVerwijder.Size = new System.Drawing.Size(166, 29);
            this.buttonVerwijder.TabIndex = 13;
            this.buttonVerwijder.Text = "Verwijder dierenarts";
            this.buttonVerwijder.UseVisualStyleBackColor = true;
            this.buttonVerwijder.Click += new System.EventHandler(this.buttonVerwijder_Click);
            // 
            // labelSelectedArts
            // 
            this.labelSelectedArts.AutoSize = true;
            this.labelSelectedArts.ForeColor = System.Drawing.Color.Navy;
            this.labelSelectedArts.Location = new System.Drawing.Point(44, 293);
            this.labelSelectedArts.Name = "labelSelectedArts";
            this.labelSelectedArts.Size = new System.Drawing.Size(80, 20);
            this.labelSelectedArts.TabIndex = 12;
            this.labelSelectedArts.Text = "Dierenarts:";
            // 
            // textBoxSpecialisatie
            // 
            this.textBoxSpecialisatie.Location = new System.Drawing.Point(614, 388);
            this.textBoxSpecialisatie.Name = "textBoxSpecialisatie";
            this.textBoxSpecialisatie.Size = new System.Drawing.Size(163, 27);
            this.textBoxSpecialisatie.TabIndex = 11;
            // 
            // labelSpecialisatie
            // 
            this.labelSpecialisatie.AutoSize = true;
            this.labelSpecialisatie.Location = new System.Drawing.Point(458, 388);
            this.labelSpecialisatie.Name = "labelSpecialisatie";
            this.labelSpecialisatie.Size = new System.Drawing.Size(92, 20);
            this.labelSpecialisatie.TabIndex = 10;
            this.labelSpecialisatie.Text = "Specialisatie";
            // 
            // textBoxTelefoonnummer
            // 
            this.textBoxTelefoonnummer.Location = new System.Drawing.Point(614, 328);
            this.textBoxTelefoonnummer.Name = "textBoxTelefoonnummer";
            this.textBoxTelefoonnummer.Size = new System.Drawing.Size(163, 27);
            this.textBoxTelefoonnummer.TabIndex = 9;
            // 
            // labelTelefoonnummer
            // 
            this.labelTelefoonnummer.AutoSize = true;
            this.labelTelefoonnummer.Location = new System.Drawing.Point(458, 331);
            this.labelTelefoonnummer.Name = "labelTelefoonnummer";
            this.labelTelefoonnummer.Size = new System.Drawing.Size(122, 20);
            this.labelTelefoonnummer.TabIndex = 8;
            this.labelTelefoonnummer.Text = "Telefoonnummer";
            // 
            // textBoxAchternaam
            // 
            this.textBoxAchternaam.Location = new System.Drawing.Point(190, 385);
            this.textBoxAchternaam.Name = "textBoxAchternaam";
            this.textBoxAchternaam.Size = new System.Drawing.Size(163, 27);
            this.textBoxAchternaam.TabIndex = 7;
            // 
            // labelAchternaam
            // 
            this.labelAchternaam.AutoSize = true;
            this.labelAchternaam.Location = new System.Drawing.Point(73, 388);
            this.labelAchternaam.Name = "labelAchternaam";
            this.labelAchternaam.Size = new System.Drawing.Size(89, 20);
            this.labelAchternaam.TabIndex = 6;
            this.labelAchternaam.Text = "Achternaam";
            // 
            // labelVoornaam
            // 
            this.labelVoornaam.AutoSize = true;
            this.labelVoornaam.Location = new System.Drawing.Point(73, 328);
            this.labelVoornaam.Name = "labelVoornaam";
            this.labelVoornaam.Size = new System.Drawing.Size(77, 20);
            this.labelVoornaam.TabIndex = 5;
            this.labelVoornaam.Text = "Voornaam";
            // 
            // textBoxVoornaam
            // 
            this.textBoxVoornaam.Location = new System.Drawing.Point(190, 328);
            this.textBoxVoornaam.Name = "textBoxVoornaam";
            this.textBoxVoornaam.Size = new System.Drawing.Size(163, 27);
            this.textBoxVoornaam.TabIndex = 4;
            // 
            // buttonZoekOpNaam
            // 
            this.buttonZoekOpNaam.Location = new System.Drawing.Point(291, 25);
            this.buttonZoekOpNaam.Name = "buttonZoekOpNaam";
            this.buttonZoekOpNaam.Size = new System.Drawing.Size(196, 29);
            this.buttonZoekOpNaam.TabIndex = 3;
            this.buttonZoekOpNaam.Text = "Zoek op naam";
            this.buttonZoekOpNaam.UseVisualStyleBackColor = true;
            this.buttonZoekOpNaam.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxDierenartsen
            // 
            this.listBoxDierenartsen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxDierenartsen.FormattingEnabled = true;
            this.listBoxDierenartsen.ItemHeight = 20;
            this.listBoxDierenartsen.Location = new System.Drawing.Point(44, 70);
            this.listBoxDierenartsen.Name = "listBoxDierenartsen";
            this.listBoxDierenartsen.ScrollAlwaysVisible = true;
            this.listBoxDierenartsen.Size = new System.Drawing.Size(845, 184);
            this.listBoxDierenartsen.TabIndex = 2;
            // 
            // textBoxNaamIngave
            // 
            this.textBoxNaamIngave.Location = new System.Drawing.Point(503, 27);
            this.textBoxNaamIngave.Name = "textBoxNaamIngave";
            this.textBoxNaamIngave.Size = new System.Drawing.Size(252, 27);
            this.textBoxNaamIngave.TabIndex = 1;
            this.textBoxNaamIngave.Text = "Geef naam in";
            // 
            // buttonToonAlle
            // 
            this.buttonToonAlle.Location = new System.Drawing.Point(44, 25);
            this.buttonToonAlle.Name = "buttonToonAlle";
            this.buttonToonAlle.Size = new System.Drawing.Size(203, 29);
            this.buttonToonAlle.TabIndex = 0;
            this.buttonToonAlle.Text = "Toon Alle Dierenartsen";
            this.buttonToonAlle.UseVisualStyleBackColor = true;
            this.buttonToonAlle.Click += new System.EventHandler(this.buttonToonAlle_Click);
            // 
            // tabPageNieuwe
            // 
            this.tabPageNieuwe.Controls.Add(this.buttonVoegToe);
            this.tabPageNieuwe.Controls.Add(this.textBoxSpecialisatieNieuwe);
            this.tabPageNieuwe.Controls.Add(this.textBoxTelefoonNieuwe);
            this.tabPageNieuwe.Controls.Add(this.textBoxAchternaamNieuwe);
            this.tabPageNieuwe.Controls.Add(this.textBoxVoornaamNieuwe);
            this.tabPageNieuwe.Controls.Add(this.labelSpecialisatieNieuwe);
            this.tabPageNieuwe.Controls.Add(this.labelTelefoonNieuwe);
            this.tabPageNieuwe.Controls.Add(this.labelAchternaamNieuwe);
            this.tabPageNieuwe.Controls.Add(this.labelVoornaamNieuw);
            this.tabPageNieuwe.Location = new System.Drawing.Point(4, 29);
            this.tabPageNieuwe.Name = "tabPageNieuwe";
            this.tabPageNieuwe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNieuwe.Size = new System.Drawing.Size(935, 528);
            this.tabPageNieuwe.TabIndex = 1;
            this.tabPageNieuwe.Text = "Nieuwe dierenarts";
            this.tabPageNieuwe.UseVisualStyleBackColor = true;
            // 
            // textBoxSpecialisatieNieuwe
            // 
            this.textBoxSpecialisatieNieuwe.Location = new System.Drawing.Point(601, 167);
            this.textBoxSpecialisatieNieuwe.Name = "textBoxSpecialisatieNieuwe";
            this.textBoxSpecialisatieNieuwe.Size = new System.Drawing.Size(195, 27);
            this.textBoxSpecialisatieNieuwe.TabIndex = 8;
            // 
            // textBoxTelefoonNieuwe
            // 
            this.textBoxTelefoonNieuwe.Location = new System.Drawing.Point(601, 98);
            this.textBoxTelefoonNieuwe.Name = "textBoxTelefoonNieuwe";
            this.textBoxTelefoonNieuwe.Size = new System.Drawing.Size(195, 27);
            this.textBoxTelefoonNieuwe.TabIndex = 7;
            // 
            // textBoxAchternaamNieuwe
            // 
            this.textBoxAchternaamNieuwe.Location = new System.Drawing.Point(159, 167);
            this.textBoxAchternaamNieuwe.Name = "textBoxAchternaamNieuwe";
            this.textBoxAchternaamNieuwe.Size = new System.Drawing.Size(195, 27);
            this.textBoxAchternaamNieuwe.TabIndex = 6;
            // 
            // textBoxVoornaamNieuwe
            // 
            this.textBoxVoornaamNieuwe.Location = new System.Drawing.Point(159, 101);
            this.textBoxVoornaamNieuwe.Name = "textBoxVoornaamNieuwe";
            this.textBoxVoornaamNieuwe.Size = new System.Drawing.Size(195, 27);
            this.textBoxVoornaamNieuwe.TabIndex = 5;
            // 
            // labelSpecialisatieNieuwe
            // 
            this.labelSpecialisatieNieuwe.AutoSize = true;
            this.labelSpecialisatieNieuwe.Location = new System.Drawing.Point(444, 170);
            this.labelSpecialisatieNieuwe.Name = "labelSpecialisatieNieuwe";
            this.labelSpecialisatieNieuwe.Size = new System.Drawing.Size(102, 20);
            this.labelSpecialisatieNieuwe.TabIndex = 4;
            this.labelSpecialisatieNieuwe.Text = "Specialisatie *";
            // 
            // labelTelefoonNieuwe
            // 
            this.labelTelefoonNieuwe.AutoSize = true;
            this.labelTelefoonNieuwe.Location = new System.Drawing.Point(444, 101);
            this.labelTelefoonNieuwe.Name = "labelTelefoonNieuwe";
            this.labelTelefoonNieuwe.Size = new System.Drawing.Size(132, 20);
            this.labelTelefoonNieuwe.TabIndex = 3;
            this.labelTelefoonNieuwe.Text = "Telefoonnummer *";
            // 
            // labelAchternaamNieuwe
            // 
            this.labelAchternaamNieuwe.AutoSize = true;
            this.labelAchternaamNieuwe.Location = new System.Drawing.Point(32, 170);
            this.labelAchternaamNieuwe.Name = "labelAchternaamNieuwe";
            this.labelAchternaamNieuwe.Size = new System.Drawing.Size(99, 20);
            this.labelAchternaamNieuwe.TabIndex = 2;
            this.labelAchternaamNieuwe.Text = "Achternaam *";
            // 
            // labelVoornaamNieuw
            // 
            this.labelVoornaamNieuw.AutoSize = true;
            this.labelVoornaamNieuw.Location = new System.Drawing.Point(32, 101);
            this.labelVoornaamNieuw.Name = "labelVoornaamNieuw";
            this.labelVoornaamNieuw.Size = new System.Drawing.Size(87, 20);
            this.labelVoornaamNieuw.TabIndex = 1;
            this.labelVoornaamNieuw.Text = "Voornaam *";
            // 
            // buttonVoegToe
            // 
            this.buttonVoegToe.Location = new System.Drawing.Point(570, 271);
            this.buttonVoegToe.Name = "buttonVoegToe";
            this.buttonVoegToe.Size = new System.Drawing.Size(226, 37);
            this.buttonVoegToe.TabIndex = 9;
            this.buttonVoegToe.Text = "Voeg nieuwe dierenarts toe";
            this.buttonVoegToe.UseVisualStyleBackColor = true;
            this.buttonVoegToe.Click += new System.EventHandler(this.buttonVoegToe_Click);
            // 
            // FormDierenartsen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 585);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDierenartsen";
            this.Text = "FormDierenartsen";
            this.tabControl.ResumeLayout(false);
            this.tabPageOverzicht.ResumeLayout(false);
            this.tabPageOverzicht.PerformLayout();
            this.tabPageNieuwe.ResumeLayout(false);
            this.tabPageNieuwe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageOverzicht;
        private System.Windows.Forms.TabPage tabPageNieuwe;
        private System.Windows.Forms.Button buttonToonAlle;
        private System.Windows.Forms.Button buttonZoekOpNaam;
        private System.Windows.Forms.ListBox listBoxDierenartsen;
        private System.Windows.Forms.TextBox textBoxNaamIngave;
        private System.Windows.Forms.TextBox textBoxVoornaam;
        private System.Windows.Forms.Label labelVoornaam;
        private System.Windows.Forms.Label labelAchternaam;
        private System.Windows.Forms.TextBox textBoxSpecialisatie;
        private System.Windows.Forms.Label labelSpecialisatie;
        private System.Windows.Forms.TextBox textBoxTelefoonnummer;
        private System.Windows.Forms.Label labelTelefoonnummer;
        private System.Windows.Forms.TextBox textBoxAchternaam;
        private System.Windows.Forms.Label labelSelectedArts;
        private System.Windows.Forms.Button buttonSelecteer;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonVerwijder;
        private System.Windows.Forms.Label labelAchternaamNieuwe;
        private System.Windows.Forms.Label labelVoornaamNieuw;
        private System.Windows.Forms.Label labelTelefoonNieuwe;
        private System.Windows.Forms.TextBox textBoxSpecialisatieNieuwe;
        private System.Windows.Forms.TextBox textBoxTelefoonNieuwe;
        private System.Windows.Forms.TextBox textBoxAchternaamNieuwe;
        private System.Windows.Forms.TextBox textBoxVoornaamNieuwe;
        private System.Windows.Forms.Label labelSpecialisatieNieuwe;
        private System.Windows.Forms.Button buttonVoegToe;
    }
}