using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiguelRodriguezGallego_Ejercicio2
{
    public partial class Combate : Form
    {
        private Player p1 = new Player("La Roca", 300, 10, 50, 2, "Normal", "none");

        // Lista para guardar los enemigos
        //private List<Enemy> enemyList = new List<Enemy>();
        private Enemy e1 = new Enemy("Enemigo de Fuego", 100, 15, "Fuego", "none");
        private Enemy e2 = new Enemy("Enemigo de Agua", 100, 15, "Agua", "none");
        private Enemy e3 = new Enemy("Enemigo de Planta", 100, 15,"Planta", "none");

        private Enemy eEnCombate = new Enemy("none", 100, 15, "none", "none");

        public Combate()
        {
            InitializeComponent();

            eEnCombate = e1;

            RefreshData();
            //RellenarListaEnemigos();
        }

        private void CambiarEnemigo()
        {
            int i = 0;
            if (eEnCombate.health <= 0 && i == 0)
            {
                eEnCombate = e2;
                lblTipoDeEnemigo.Text = e2.tipoDeEnemigo;

                lblPlayerName.Text = p1.name;
                lblPlayerHealth.Text = p1.health.ToString();

                lblEnemyName.Text = e2.name;
                lblEnemyHealth.Text = e2.health.ToString();
                i++;                
            }

            if (eEnCombate.health <= 0 && i == 1)
            {
                eEnCombate = e3;
                lblTipoDeEnemigo.Text = e3.tipoDeEnemigo;

                lblPlayerName.Text = p1.name;
                lblPlayerHealth.Text = p1.health.ToString();

                lblEnemyName.Text = e3.name;
                lblEnemyHealth.Text = e3.health.ToString();
                i++;                
            }
            RefreshData();

            if (eEnCombate.health <= 0 && i == 2)
            {
                MessageBox.Show("Derrotaste a todos tus oponentes!", "Fin de la partida!");
                this.Close();
            }
        }
        private void MuerteJugador()
        {
            if (p1.health <= 0)
            {
                MessageBox.Show("La salud del jugador llegó a 0", "Fin de la partida");
                this.Close();
            }
        }

        private void RefreshData()
        {
            lblPlayerName.Text = p1.name;
            lblPlayerHealth.Text = p1.health.ToString();

            lblEnemyName.Text = eEnCombate.name;
            lblEnemyHealth.Text = eEnCombate.health.ToString();
        }
        //public void RellenarListaEnemigos()
        //{
        //    int i = 0;
        //    if (i == 0)
        //    {
        //        enemyList.Add(e1);
        //        enemyList.Add(e2);
        //        enemyList.Add(e3);
        //        i++;
        //    }
        //}

        //private void EnemigoActual()
        //{

        //    foreach (Enemy e in enemyList)
        //    {
        //        Enemy enemyRef = e as Enemy;
        //    }
        //}

        private void btnAttack_Click_1(object sender, EventArgs e)
        {
            if (rbAtaque1.Checked)
            {
                eEnCombate.RecieveDmg(p1.AtaqueNormal());

                p1.RecieveDmg(eEnCombate.AtaqueNormal());
            }
            if (rbAtaque2.Checked)
            {
                eEnCombate.RecieveDmg(p1.AtaqueFuego(eEnCombate.tipoDeEnemigo));

                p1.RecieveDmg(eEnCombate.AtaqueNormal());
            }
            if (rbAtaque3.Checked)
            {
                eEnCombate.RecieveDmg(p1.AtaqueAgua(eEnCombate.tipoDeEnemigo));

                p1.RecieveDmg(eEnCombate.AtaqueNormal());
            }
            if (rbAtaque4.Checked)
            {
                eEnCombate.RecieveDmg(p1.AtaquePlanta(eEnCombate.tipoDeEnemigo));

                p1.RecieveDmg(eEnCombate.AtaqueNormal());
            }                        
            MuerteJugador();
            CambiarEnemigo();
            RefreshData();
        }
    }
}
