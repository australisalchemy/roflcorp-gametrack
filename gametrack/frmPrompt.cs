using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gametrack
{
    public partial class frmPrompt : Form
    {
        public frmPrompt()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmGame f = new frmGame();
            frmStart d = new frmStart();
            this.Hide();
            d.Hide();
            f.Show();


            if (frmStart.Event == "LAN")
            {
                f.lblEvent.Text = "LAN: " + txtEventName.Text;
            }
            if (frmStart.Event == "Competition")
            {
                f.lblEvent.Text = "Comp: " + txtEventName.Text;
            }
        }

        private void frmPrompt_Load(object sender, EventArgs e)
        {
            this.Focus(); // Focus the form
            txtEventName.Focus(); // Then focus the text box
        }
    }
}
