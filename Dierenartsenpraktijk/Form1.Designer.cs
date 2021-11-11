namespace Dierenartsenpraktijk
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAfspraken = new System.Windows.Forms.Button();
            this.buttonArtsen = new System.Windows.Forms.Button();
            this.buttonDieren = new System.Windows.Forms.Button();
            this.buttonKlanten = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildform = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.buttonAfspraken);
            this.panel1.Controls.Add(this.buttonArtsen);
            this.panel1.Controls.Add(this.buttonDieren);
            this.panel1.Controls.Add(this.buttonKlanten);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 632);
            this.panel1.TabIndex = 0;
            // 
            // buttonAfspraken
            // 
            this.buttonAfspraken.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAfspraken.Location = new System.Drawing.Point(0, 312);
            this.buttonAfspraken.Name = "buttonAfspraken";
            this.buttonAfspraken.Size = new System.Drawing.Size(250, 43);
            this.buttonAfspraken.TabIndex = 2;
            this.buttonAfspraken.Text = "Afspraken";
            this.buttonAfspraken.UseVisualStyleBackColor = false;
            this.buttonAfspraken.Click += new System.EventHandler(this.buttonAfspraken_Click);
            // 
            // buttonArtsen
            // 
            this.buttonArtsen.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonArtsen.Location = new System.Drawing.Point(0, 263);
            this.buttonArtsen.Name = "buttonArtsen";
            this.buttonArtsen.Size = new System.Drawing.Size(250, 43);
            this.buttonArtsen.TabIndex = 2;
            this.buttonArtsen.Text = "Dierenartsen";
            this.buttonArtsen.UseVisualStyleBackColor = false;
            this.buttonArtsen.Click += new System.EventHandler(this.buttonArtsen_Click);
            // 
            // buttonDieren
            // 
            this.buttonDieren.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonDieren.Location = new System.Drawing.Point(0, 214);
            this.buttonDieren.Name = "buttonDieren";
            this.buttonDieren.Size = new System.Drawing.Size(250, 43);
            this.buttonDieren.TabIndex = 2;
            this.buttonDieren.Text = "Dieren";
            this.buttonDieren.UseVisualStyleBackColor = false;
            this.buttonDieren.Click += new System.EventHandler(this.buttonDieren_Click);
            // 
            // buttonKlanten
            // 
            this.buttonKlanten.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonKlanten.Location = new System.Drawing.Point(0, 165);
            this.buttonKlanten.Name = "buttonKlanten";
            this.buttonKlanten.Size = new System.Drawing.Size(250, 43);
            this.buttonKlanten.TabIndex = 1;
            this.buttonKlanten.Text = "Klanten";
            this.buttonKlanten.UseVisualStyleBackColor = false;
            this.buttonKlanten.Click += new System.EventHandler(this.buttonKlanten_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(41, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 112);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildform
            // 
            this.panelChildform.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelChildform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildform.Location = new System.Drawing.Point(250, 0);
            this.panelChildform.Name = "panelChildform";
            this.panelChildform.Size = new System.Drawing.Size(961, 632);
            this.panelChildform.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1211, 632);
            this.Controls.Add(this.panelChildform);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Dierenartsenpraktijk";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonKlanten;
        private System.Windows.Forms.Button buttonAfspraken;
        private System.Windows.Forms.Button buttonArtsen;
        private System.Windows.Forms.Button buttonDieren;
        private System.Windows.Forms.Panel panelChildform;
    }
}

