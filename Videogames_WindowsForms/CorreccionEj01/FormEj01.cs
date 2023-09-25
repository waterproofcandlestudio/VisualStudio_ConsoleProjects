using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorreccionEj01
{
    public partial class FormEj01 : Form
    {
        private Player p1 = new Player("Susana", 1000, 10, 50, 2);
        private Enemy  e1 = new Enemy("Enrique", 500, 15, 57);

        public FormEj01()
        {
            InitializeComponent();
            RefreshData();
        }

        private void RefreshData()
        {
            gbPlayer.Text            = p1.name;
            lblPlayerHealth.Text     = p1.health.ToString();
            lblPlayerDmg.Text        = p1.damage.ToString();
            lblPlayerCritChance.Text = p1.critChance.ToString();
            lblPlayerCritMult.Text   = p1.critMult.ToString();

            gbEnemy.Text             = e1.name;
            lblEnemyHealth.Text      = e1.health.ToString();
            lblEnemyDmg.Text         = e1.damage.ToString();
            lblEnemyShield.Text      = e1.shield.ToString();

            rbPlayer.Text = p1.name;
            rbEnemy.Text  = e1.name;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if(rbPlayer.Checked)
            {
                e1.RecieveDmg(p1.GetDamage());
            }
            else
            {
                p1.RecieveDmg(e1.GetDamage());
            }

            RefreshData();
        }
    }
}
