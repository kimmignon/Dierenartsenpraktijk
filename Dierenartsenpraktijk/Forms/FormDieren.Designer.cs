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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonToonAlle = new System.Windows.Forms.Button();
            this.buttonOpNaam = new System.Windows.Forms.Button();
            this.textBoxGeefNaam = new System.Windows.Forms.TextBox();
            this.listBoxDieren = new System.Windows.Forms.ListBox();
            this.buttonSelecteer = new System.Windows.Forms.Button();
            this.tabControlDieren.SuspendLayout();
            this.tabPageOverzicht.SuspendLayout();
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
            this.tabPageOverzicht.Controls.Add(this.buttonSelecteer);
            this.tabPageOverzicht.Controls.Add(this.listBoxDieren);
            this.tabPageOverzicht.Controls.Add(this.textBoxGeefNaam);
            this.tabPageOverzicht.Controls.Add(this.buttonOpNaam);
            this.tabPageOverzicht.Controls.Add(this.buttonToonAlle);
            this.tabPageOverzicht.Location = new System.Drawing.Point(4, 29);
            this.tabPageOverzicht.Name = "tabPageOverzicht";
            this.tabPageOverzicht.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOverzicht.Size = new System.Drawing.Size(935, 531);
            this.tabPageOverzicht.TabIndex = 0;
            this.tabPageOverzicht.Text = "Overzicht";
            this.tabPageOverzicht.UseVisualStyleBackColor = true;
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
            // buttonToonAlle
            // 
            this.buttonToonAlle.Location = new System.Drawing.Point(32, 25);
            this.buttonToonAlle.Name = "buttonToonAlle";
            this.buttonToonAlle.Size = new System.Drawing.Size(180, 29);
            this.buttonToonAlle.TabIndex = 0;
            this.buttonToonAlle.Text = "Toon alle dieren";
            this.buttonToonAlle.UseVisualStyleBackColor = true;
            // 
            // buttonOpNaam
            // 
            this.buttonOpNaam.Location = new System.Drawing.Point(260, 25);
            this.buttonOpNaam.Name = "buttonOpNaam";
            this.buttonOpNaam.Size = new System.Drawing.Size(155, 29);
            this.buttonOpNaam.TabIndex = 1;
            this.buttonOpNaam.Text = "Zoek op naam";
            this.buttonOpNaam.UseVisualStyleBackColor = true;
            // 
            // textBoxGeefNaam
            // 
            this.textBoxGeefNaam.Location = new System.Drawing.Point(449, 27);
            this.textBoxGeefNaam.Name = "textBoxGeefNaam";
            this.textBoxGeefNaam.Size = new System.Drawing.Size(268, 27);
            this.textBoxGeefNaam.TabIndex = 2;
            this.textBoxGeefNaam.Text = "Geef naam in";
            // 
            // listBoxDieren
            // 
            this.listBoxDieren.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxDieren.FormattingEnabled = true;
            this.listBoxDieren.ItemHeight = 20;
            this.listBoxDieren.Location = new System.Drawing.Point(32, 69);
            this.listBoxDieren.Name = "listBoxDieren";
            this.listBoxDieren.ScrollAlwaysVisible = true;
            this.listBoxDieren.Size = new System.Drawing.Size(870, 144);
            this.listBoxDieren.TabIndex = 3;
            // 
            // buttonSelecteer
            // 
            this.buttonSelecteer.Location = new System.Drawing.Point(768, 219);
            this.buttonSelecteer.Name = "buttonSelecteer";
            this.buttonSelecteer.Size = new System.Drawing.Size(134, 29);
            this.buttonSelecteer.TabIndex = 4;
            this.buttonSelecteer.Text = "Selecteer dier";
            this.buttonSelecteer.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TabControl tabControlDieren;
        private System.Windows.Forms.TabPage tabPageOverzicht;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonSelecteer;
        private System.Windows.Forms.ListBox listBoxDieren;
        private System.Windows.Forms.TextBox textBoxGeefNaam;
        private System.Windows.Forms.Button buttonOpNaam;
        private System.Windows.Forms.Button buttonToonAlle;
    }
}