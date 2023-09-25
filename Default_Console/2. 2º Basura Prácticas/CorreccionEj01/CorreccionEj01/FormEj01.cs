using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorreccionEj01
{
    public partial class FormEj01 : Form
    {
        private Player p1 = new Player("Susana", damage: 5);
        private Enemy e1 = new Enemy("Enrique", damage: 5);

        gbPlayer.Text = p1.name;
        gbEnemy.Text = e1.name;
        public FormEj01()
        {
            InitializeComponent();            
        }

        private void RefreshData()
        {
            gbPlayer.Text = p1.name;
            lblPlayerHealth.Text = p1.health;
            lblPlayerDamage.Text = p1.damage;

            gbEnemy.Text = e1.name;
            lblEnemyHealth.Text = e1.health;
            lblEnemyDamage.Text = e1.damage;

            RbPlayer.Text = p1.name;
            RbEnemy.Text = e1.name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if(RbPlayer.Checked)
            {
                e1.RecieveDmg(p1.GetDamage());
            }
            else
            {
                p1.RecieveDmg(e1.GetDAmage());
            }
        }
    }
}
