namespace Dierenartsenpraktijk.Forms
{
    partial class FormKlanten
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
            this.tabControlKlanten = new System.Windows.Forms.TabControl();
            this.tabPageOverzicht = new System.Windows.Forms.TabPage();
            this.buttonSelecteer = new System.Windows.Forms.Button();
            this.listBoxKlanten = new System.Windows.Forms.ListBox();
            this.textBoxGeefNaam = new System.Windows.Forms.TextBox();
            this.buttonOpNaam = new System.Windows.Forms.Button();
            this.buttonGeefAlle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonVerwijder = new System.Windows.Forms.Button();
            this.labelDieren = new System.Windows.Forms.Label();
            this.listBoxHuisdieren = new System.Windows.Forms.ListBox();
            this.textBoxTelefoon = new System.Windows.Forms.TextBox();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxAchternaam = new System.Windows.Forms.TextBox();
            this.textBoxVoornaam = new System.Windows.Forms.TextBox();
            this.labelAdres = new System.Windows.Forms.Label();
            this.labelTelefoon = new System.Windows.Forms.Label();
            this.labelAchternaam = new System.Windows.Forms.Label();
            this.labelVoornaam = new System.Windows.Forms.Label();
            this.labelSelectedKlant = new System.Windows.Forms.Label();
            this.tabPageNieuweKlant = new System.Windows.Forms.TabPage();
            this.buttonVoegToe = new System.Windows.Forms.Button();
            this.textBoxAdresNieuwe = new System.Windows.Forms.TextBox();
            this.textBoxTelefoonNieuwe = new System.Windows.Forms.TextBox();
            this.textBoxAchternaamNieuwe = new System.Windows.Forms.TextBox();
            this.textBoxVoornaamNieuwe = new System.Windows.Forms.TextBox();
            this.labelAdresNieuwe = new System.Windows.Forms.Label();
            this.labelTelefoonNieuwe = new System.Windows.Forms.Label();
            this.labelAchternaamNieuwe = new System.Windows.Forms.Label();
            this.labelVoornaamNieuwe = new System.Windows.Forms.Label();
            this.tabControlKlanten.SuspendLayout();
            this.tabPageOverzicht.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageNieuweKlant.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(890, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(41, 30);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // tabControlKlanten
            // 
            this.tabControlKlanten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlKlanten.Controls.Add(this.tabPageOverzicht);
            this.tabControlKlanten.Controls.Add(this.tabPageNieuweKlant);
            this.tabControlKlanten.Location = new System.Drawing.Point(1, 25);
            this.tabControlKlanten.Name = "tabControlKlanten";
            this.tabControlKlanten.SelectedIndex = 0;
            this.tabControlKlanten.Size = new System.Drawing.Size(942, 560);
            this.tabControlKlanten.TabIndex = 1;
            // 
            // tabPageOverzicht
            // 
            this.tabPageOverzicht.Controls.Add(this.buttonSelecteer);
            this.tabPageOverzicht.Controls.Add(this.listBoxKlanten);
            this.tabPageOverzicht.Controls.Add(this.textBoxGeefNaam);
            this.tabPageOverzicht.Controls.Add(this.buttonOpNaam);
            this.tabPageOverzicht.Controls.Add(this.buttonGeefAlle);
            this.tabPageOverzicht.Controls.Add(this.panel1);
            this.tabPageOverzicht.Location = new System.Drawing.Point(4, 29);
            this.tabPageOverzicht.Name = "tabPageOverzicht";
            this.tabPageOverzicht.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOverzicht.Size = new System.Drawing.Size(934, 527);
            this.tabPageOverzicht.TabIndex = 0;
            this.tabPageOverzicht.Text = "Overzicht";
            this.tabPageOverzicht.UseVisualStyleBackColor = true;
            // 
            // buttonSelecteer
            // 
            this.buttonSelecteer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelecteer.Location = new System.Drawing.Point(756, 231);
            this.buttonSelecteer.Name = "buttonSelecteer";
            this.buttonSelecteer.Size = new System.Drawing.Size(144, 28);
            this.buttonSelecteer.TabIndex = 4;
            this.buttonSelecteer.Text = "Selecteer klant";
            this.buttonSelecteer.UseVisualStyleBackColor = true;
            this.buttonSelecteer.Click += new System.EventHandler(this.buttonSelecteer_Click);
            // 
            // listBoxKlanten
            // 
            this.listBoxKlanten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxKlanten.FormattingEnabled = true;
            this.listBoxKlanten.ItemHeight = 20;
            this.listBoxKlanten.Location = new System.Drawing.Point(31, 81);
            this.listBoxKlanten.Name = "listBoxKlanten";
            this.listBoxKlanten.ScrollAlwaysVisible = true;
            this.listBoxKlanten.Size = new System.Drawing.Size(869, 144);
            this.listBoxKlanten.TabIndex = 3;
            // 
            // textBoxGeefNaam
            // 
            this.textBoxGeefNaam.Location = new System.Drawing.Point(463, 26);
            this.textBoxGeefNaam.Name = "textBoxGeefNaam";
            this.textBoxGeefNaam.Size = new System.Drawing.Size(248, 27);
            this.textBoxGeefNaam.TabIndex = 2;
            this.textBoxGeefNaam.Text = "Geef naam in";
            // 
            // buttonOpNaam
            // 
            this.buttonOpNaam.Location = new System.Drawing.Point(260, 24);
            this.buttonOpNaam.Name = "buttonOpNaam";
            this.buttonOpNaam.Size = new System.Drawing.Size(188, 29);
            this.buttonOpNaam.TabIndex = 1;
            this.buttonOpNaam.Text = "Zoek op naam";
            this.buttonOpNaam.UseVisualStyleBackColor = true;
            this.buttonOpNaam.Click += new System.EventHandler(this.buttonOpNaam_Click);
            // 
            // buttonGeefAlle
            // 
            this.buttonGeefAlle.Location = new System.Drawing.Point(31, 24);
            this.buttonGeefAlle.Name = "buttonGeefAlle";
            this.buttonGeefAlle.Size = new System.Drawing.Size(179, 29);
            this.buttonGeefAlle.TabIndex = 0;
            this.buttonGeefAlle.Text = "Toon alle klanten";
            this.buttonGeefAlle.UseVisualStyleBackColor = true;
            this.buttonGeefAlle.Click += new System.EventHandler(this.buttonGeefAlle_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonVerwijder);
            this.panel1.Controls.Add(this.labelDieren);
            this.panel1.Controls.Add(this.listBoxHuisdieren);
            this.panel1.Controls.Add(this.textBoxTelefoon);
            this.panel1.Controls.Add(this.textBoxAdres);
            this.panel1.Controls.Add(this.textBoxAchternaam);
            this.panel1.Controls.Add(this.textBoxVoornaam);
            this.panel1.Controls.Add(this.labelAdres);
            this.panel1.Controls.Add(this.labelTelefoon);
            this.panel1.Controls.Add(this.labelAchternaam);
            this.panel1.Controls.Add(this.labelVoornaam);
            this.panel1.Controls.Add(this.labelSelectedKlant);
            this.panel1.Location = new System.Drawing.Point(3, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 259);
            this.panel1.TabIndex = 6;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.Location = new System.Drawing.Point(740, 52);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(157, 49);
            this.buttonUpdate.TabIndex = 18;
            this.buttonUpdate.Text = "Update gegevens";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonVerwijder
            // 
            this.buttonVerwijder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVerwijder.Location = new System.Drawing.Point(753, 213);
            this.buttonVerwijder.Name = "buttonVerwijder";
            this.buttonVerwijder.Size = new System.Drawing.Size(144, 32);
            this.buttonVerwijder.TabIndex = 17;
            this.buttonVerwijder.Text = "Verwijder klant";
            this.buttonVerwijder.UseVisualStyleBackColor = true;
            this.buttonVerwijder.Click += new System.EventHandler(this.buttonVerwijder_Click);
            // 
            // labelDieren
            // 
            this.labelDieren.AutoSize = true;
            this.labelDieren.Location = new System.Drawing.Point(28, 150);
            this.labelDieren.Name = "labelDieren";
            this.labelDieren.Size = new System.Drawing.Size(56, 20);
            this.labelDieren.TabIndex = 15;
            this.labelDieren.Text = "Dieren:";
            // 
            // listBoxHuisdieren
            // 
            this.listBoxHuisdieren.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxHuisdieren.FormattingEnabled = true;
            this.listBoxHuisdieren.ItemHeight = 20;
            this.listBoxHuisdieren.Location = new System.Drawing.Point(141, 150);
            this.listBoxHuisdieren.Name = "listBoxHuisdieren";
            this.listBoxHuisdieren.ScrollAlwaysVisible = true;
            this.listBoxHuisdieren.Size = new System.Drawing.Size(587, 104);
            this.listBoxHuisdieren.TabIndex = 16;
            // 
            // textBoxTelefoon
            // 
            this.textBoxTelefoon.Location = new System.Drawing.Point(482, 49);
            this.textBoxTelefoon.Name = "textBoxTelefoon";
            this.textBoxTelefoon.Size = new System.Drawing.Size(171, 27);
            this.textBoxTelefoon.TabIndex = 14;
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(482, 94);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(171, 27);
            this.textBoxAdres.TabIndex = 13;
            // 
            // textBoxAchternaam
            // 
            this.textBoxAchternaam.Location = new System.Drawing.Point(141, 91);
            this.textBoxAchternaam.Name = "textBoxAchternaam";
            this.textBoxAchternaam.Size = new System.Drawing.Size(171, 27);
            this.textBoxAchternaam.TabIndex = 11;
            // 
            // textBoxVoornaam
            // 
            this.textBoxVoornaam.Location = new System.Drawing.Point(141, 49);
            this.textBoxVoornaam.Name = "textBoxVoornaam";
            this.textBoxVoornaam.Size = new System.Drawing.Size(171, 27);
            this.textBoxVoornaam.TabIndex = 10;
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(354, 94);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(47, 20);
            this.labelAdres.TabIndex = 9;
            this.labelAdres.Text = "Adres";
            // 
            // labelTelefoon
            // 
            this.labelTelefoon.AutoSize = true;
            this.labelTelefoon.Location = new System.Drawing.Point(354, 52);
            this.labelTelefoon.Name = "labelTelefoon";
            this.labelTelefoon.Size = new System.Drawing.Size(122, 20);
            this.labelTelefoon.TabIndex = 8;
            this.labelTelefoon.Text = "Telefoonnummer";
            // 
            // labelAchternaam
            // 
            this.labelAchternaam.AutoSize = true;
            this.labelAchternaam.Location = new System.Drawing.Point(28, 94);
            this.labelAchternaam.Name = "labelAchternaam";
            this.labelAchternaam.Size = new System.Drawing.Size(89, 20);
            this.labelAchternaam.TabIndex = 7;
            this.labelAchternaam.Text = "Achternaam";
            // 
            // labelVoornaam
            // 
            this.labelVoornaam.AutoSize = true;
            this.labelVoornaam.Location = new System.Drawing.Point(28, 52);
            this.labelVoornaam.Name = "labelVoornaam";
            this.labelVoornaam.Size = new System.Drawing.Size(77, 20);
            this.labelVoornaam.TabIndex = 6;
            this.labelVoornaam.Text = "Voornaam";
            // 
            // labelSelectedKlant
            // 
            this.labelSelectedKlant.AutoSize = true;
            this.labelSelectedKlant.ForeColor = System.Drawing.Color.Navy;
            this.labelSelectedKlant.Location = new System.Drawing.Point(28, 16);
            this.labelSelectedKlant.Name = "labelSelectedKlant";
            this.labelSelectedKlant.Size = new System.Drawing.Size(46, 20);
            this.labelSelectedKlant.TabIndex = 5;
            this.labelSelectedKlant.Text = "Klant:";
            // 
            // tabPageNieuweKlant
            // 
            this.tabPageNieuweKlant.Controls.Add(this.buttonVoegToe);
            this.tabPageNieuweKlant.Controls.Add(this.textBoxAdresNieuwe);
            this.tabPageNieuweKlant.Controls.Add(this.textBoxTelefoonNieuwe);
            this.tabPageNieuweKlant.Controls.Add(this.textBoxAchternaamNieuwe);
            this.tabPageNieuweKlant.Controls.Add(this.textBoxVoornaamNieuwe);
            this.tabPageNieuweKlant.Controls.Add(this.labelAdresNieuwe);
            this.tabPageNieuweKlant.Controls.Add(this.labelTelefoonNieuwe);
            this.tabPageNieuweKlant.Controls.Add(this.labelAchternaamNieuwe);
            this.tabPageNieuweKlant.Controls.Add(this.labelVoornaamNieuwe);
            this.tabPageNieuweKlant.Location = new System.Drawing.Point(4, 29);
            this.tabPageNieuweKlant.Name = "tabPageNieuweKlant";
            this.tabPageNieuweKlant.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNieuweKlant.Size = new System.Drawing.Size(934, 527);
            this.tabPageNieuweKlant.TabIndex = 1;
            this.tabPageNieuweKlant.Text = "Nieuwe klant";
            this.tabPageNieuweKlant.UseVisualStyleBackColor = true;
            // 
            // buttonVoegToe
            // 
            this.buttonVoegToe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVoegToe.Location = new System.Drawing.Point(564, 247);
            this.buttonVoegToe.Name = "buttonVoegToe";
            this.buttonVoegToe.Size = new System.Drawing.Size(208, 37);
            this.buttonVoegToe.TabIndex = 8;
            this.buttonVoegToe.Text = "Voeg nieuwe klant toe";
            this.buttonVoegToe.UseVisualStyleBackColor = true;
            this.buttonVoegToe.Click += new System.EventHandler(this.buttonVoegToe_Click);
            // 
            // textBoxAdresNieuwe
            // 
            this.textBoxAdresNieuwe.Location = new System.Drawing.Point(564, 134);
            this.textBoxAdresNieuwe.Name = "textBoxAdresNieuwe";
            this.textBoxAdresNieuwe.Size = new System.Drawing.Size(196, 27);
            this.textBoxAdresNieuwe.TabIndex = 7;
            // 
            // textBoxTelefoonNieuwe
            // 
            this.textBoxTelefoonNieuwe.Location = new System.Drawing.Point(564, 59);
            this.textBoxTelefoonNieuwe.Name = "textBoxTelefoonNieuwe";
            this.textBoxTelefoonNieuwe.Size = new System.Drawing.Size(196, 27);
            this.textBoxTelefoonNieuwe.TabIndex = 6;
            // 
            // textBoxAchternaamNieuwe
            // 
            this.textBoxAchternaamNieuwe.Location = new System.Drawing.Point(182, 134);
            this.textBoxAchternaamNieuwe.Name = "textBoxAchternaamNieuwe";
            this.textBoxAchternaamNieuwe.Size = new System.Drawing.Size(196, 27);
            this.textBoxAchternaamNieuwe.TabIndex = 5;
            // 
            // textBoxVoornaamNieuwe
            // 
            this.textBoxVoornaamNieuwe.Location = new System.Drawing.Point(182, 59);
            this.textBoxVoornaamNieuwe.Name = "textBoxVoornaamNieuwe";
            this.textBoxVoornaamNieuwe.Size = new System.Drawing.Size(196, 27);
            this.textBoxVoornaamNieuwe.TabIndex = 4;
            // 
            // labelAdresNieuwe
            // 
            this.labelAdresNieuwe.AutoSize = true;
            this.labelAdresNieuwe.Location = new System.Drawing.Point(414, 134);
            this.labelAdresNieuwe.Name = "labelAdresNieuwe";
            this.labelAdresNieuwe.Size = new System.Drawing.Size(47, 20);
            this.labelAdresNieuwe.TabIndex = 3;
            this.labelAdresNieuwe.Text = "Adres";
            // 
            // labelTelefoonNieuwe
            // 
            this.labelTelefoonNieuwe.AutoSize = true;
            this.labelTelefoonNieuwe.Location = new System.Drawing.Point(414, 62);
            this.labelTelefoonNieuwe.Name = "labelTelefoonNieuwe";
            this.labelTelefoonNieuwe.Size = new System.Drawing.Size(132, 20);
            this.labelTelefoonNieuwe.TabIndex = 2;
            this.labelTelefoonNieuwe.Text = "Telefoonnummer *";
            // 
            // labelAchternaamNieuwe
            // 
            this.labelAchternaamNieuwe.AutoSize = true;
            this.labelAchternaamNieuwe.Location = new System.Drawing.Point(58, 134);
            this.labelAchternaamNieuwe.Name = "labelAchternaamNieuwe";
            this.labelAchternaamNieuwe.Size = new System.Drawing.Size(99, 20);
            this.labelAchternaamNieuwe.TabIndex = 1;
            this.labelAchternaamNieuwe.Text = "Achternaam *";
            // 
            // labelVoornaamNieuwe
            // 
            this.labelVoornaamNieuwe.AutoSize = true;
            this.labelVoornaamNieuwe.Location = new System.Drawing.Point(58, 62);
            this.labelVoornaamNieuwe.Name = "labelVoornaamNieuwe";
            this.labelVoornaamNieuwe.Size = new System.Drawing.Size(87, 20);
            this.labelVoornaamNieuwe.TabIndex = 0;
            this.labelVoornaamNieuwe.Text = "Voornaam *";
            // 
            // FormKlanten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 585);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.tabControlKlanten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKlanten";
            this.Text = "FormKlanten";
            this.tabControlKlanten.ResumeLayout(false);
            this.tabPageOverzicht.ResumeLayout(false);
            this.tabPageOverzicht.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageNieuweKlant.ResumeLayout(false);
            this.tabPageNieuweKlant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TabControl tabControlKlanten;
        private System.Windows.Forms.TabPage tabPageOverzicht;
        private System.Windows.Forms.TabPage tabPageNieuweKlant;
        private System.Windows.Forms.Button buttonOpNaam;
        private System.Windows.Forms.Button buttonGeefAlle;
        private System.Windows.Forms.ListBox listBoxKlanten;
        private System.Windows.Forms.TextBox textBoxGeefNaam;
        private System.Windows.Forms.Button buttonSelecteer;
        private System.Windows.Forms.Label labelSelectedKlant;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label labelTelefoon;
        private System.Windows.Forms.Label labelAchternaam;
        private System.Windows.Forms.Label labelVoornaam;
        private System.Windows.Forms.TextBox textBoxVoornaam;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxAchternaam;
        private System.Windows.Forms.TextBox textBoxTelefoon;
        private System.Windows.Forms.ListBox listBoxHuisdieren;
        private System.Windows.Forms.Label labelDieren;
        private System.Windows.Forms.Button buttonVerwijder;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelAchternaamNieuwe;
        private System.Windows.Forms.Label labelVoornaamNieuwe;
        private System.Windows.Forms.Label labelAdresNieuwe;
        private System.Windows.Forms.Label labelTelefoonNieuwe;
        private System.Windows.Forms.Button buttonVoegToe;
        private System.Windows.Forms.TextBox textBoxAdresNieuwe;
        private System.Windows.Forms.TextBox textBoxTelefoonNieuwe;
        private System.Windows.Forms.TextBox textBoxAchternaamNieuwe;
        private System.Windows.Forms.TextBox textBoxVoornaamNieuwe;
    }
}