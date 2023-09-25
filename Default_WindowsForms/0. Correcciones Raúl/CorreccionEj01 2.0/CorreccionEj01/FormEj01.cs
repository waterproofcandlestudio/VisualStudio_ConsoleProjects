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
        private Player p1 = new Player("Susana", 1000, 10, 100, 2);
        private Enemy  e1 = new Enemy("Enrique", 500, 15, 57, Enemy.Tactic.Ofensive);

        List<Character> charList = new List<Character>();

        public FormEj01()
        {
            InitializeComponent();
            RefreshData();
            Do();
        }

        public void Do()
        {
            Character c1 = p1;

            charList.Add(p1);
            charList.Add(e1);

            foreach (Character e in charList)
            {
                Player playerRef = e as Player;

                if(playerRef != null)
                {
                    Debug.WriteLine("Player:");
                    playerRef.Return999();
                }
                else
                {
                    Debug.WriteLine("Enemy:");
                }

                Debug.WriteLine(e.GetDamage());
            }
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
            IAttacker i1 = p1;
            IAttacker i2 = e1;

            if(rbPlayer.Checked)
            {
                i2.RecieveDmg(i1.GetDamage());
            }
            else
            {
                i1.RecieveDmg(i2.GetDamage());
            }

            RefreshData();
        }
    }
}
