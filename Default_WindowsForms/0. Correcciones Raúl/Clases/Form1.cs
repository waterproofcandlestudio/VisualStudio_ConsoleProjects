using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases
{
    public partial class Form1 : Form
    {
        Player p1 = new Player("Hob");
        Ally   a1 = new Ally(health:25);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            cbCharacters.Items.Add(p1.GetName());
            cbCharacters.Items.Add(a1.GetName());
        }

        private void cbCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbCharacters.SelectedIndex)
            {
                case 0:
                    lblName.Text   = p1.GetName();
                    lblHealth.Text = p1.GetHealth().ToString();
                    break;
                case 1:
                    lblName.Text   = a1.GetName();
                    lblHealth.Text = a1.GetHealth().ToString();
                    break;
                default:
                    lblName.Text   = "Not found";
                    lblHealth.Text = "Not found";
                    break;
            }
        }
    }
}
