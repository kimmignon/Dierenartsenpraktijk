using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dierenartsenpraktijk.Forms;

namespace Dierenartsenpraktijk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildform.Controls.Add(childForm);
            panelChildform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonKlanten_Click(object sender, EventArgs e)
        {
            openChildForm(new FormKlanten());
        }

        private void buttonDieren_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDieren());
        }

        private void buttonArtsen_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDierenartsen());
        }

        private void buttonAfspraken_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAfspraken());
        }
    }
}
