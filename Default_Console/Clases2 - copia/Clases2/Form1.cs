using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases2
{
    public partial class Form1 : Form
    {
        Player p1 = new Player("CR7");
        Enemy e1 = new Enemy("Messi");

        Character c1 = new Character(vida: 25);
        

        public Form1()
        {
            InitializeComponent();
        }
        // Muestro al player y al enemy en el cuadro blanco de eleccion 
        private void button1_Click(object sender, EventArgs e)
        {
            cbCharacters.Items.Add(p1.GetName());
            cbCharacters.Items.Add(e1.GetName());
        }
        // Hace q al seleccionar el personaje en el recuadro se muestran en pantalla todas sus estadisticas
        private void cbCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbCharacters.SelectedIndex)
            {
                case 0:
                    lblNamePlayer.Text = p1.GetName();
                    lblHealthPlayer.Text = p1.GetHealth().ToString();
                    lblDamagePlayer.Text = p1.GetDamage().ToString();

                    lblNameEnemy.Text = e1.GetName();
                    lblHealthEnemy.Text = e1.GetHealth().ToString();
                    lblDamageEnemy.Text = e1.GetDamage().ToString();
                    break;
                case 1:
                    lblNameEnemy.Text = e1.GetName();
                    lblHealthEnemy.Text = e1.GetHealth().ToString();
                    lblDamageEnemy.Text = e1.GetDamage().ToString();

                    lblNamePlayer.Text = p1.GetName();
                    lblHealthPlayer.Text = p1.GetHealth().ToString();
                    lblDamagePlayer.Text = p1.GetDamage().ToString();
                    break;
                default:
                    lblNamePlayer.Text = "Not found";
                    lblHealthPlayer.Text = "Not found";
                    lblDamagePlayer.Text = "Not found";

                    lblNameEnemy.Text = "Not found";
                    lblHealthEnemy.Text = "Not found";
                    lblDamageEnemy.Text = "Not found";
                    break;
            }
        }

        // Boton de ataque "Player" en donde junto el escudo, daño y vida
        private void AttackPlayer_Click(object sender, EventArgs e)
        {
            // Uso un nº aleatorio generado por ataque para el ataque crítico, el cual simplemente quita 10 más de salud al contrincante
            Random rnd = new Random();
            if (rnd.Next(5) < 4)
            {
                e1.Vida = e1.Vida + e1.Escudo - p1.Daño;

                lblNameEnemy.Text = e1.GetName();
                lblHealthEnemy.Text = e1.GetHealth().ToString();
                lblDamageEnemy.Text = e1.GetDamage().ToString();
            }

            else
            {
                e1.Vida = e1.Vida + e1.Escudo - p1.Daño - 10;

                lblNameEnemy.Text = e1.GetName();
                lblHealthEnemy.Text = e1.GetHealth().ToString();
                lblDamageEnemy.Text = e1.GetDamage().ToString();
            }
        }
        // Boton de ataque "Enemy" en donde junto el escudo, daño y vida
        private void AttackEnemy_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (rnd.Next(5) < 4)
            {
                p1.Vida = p1.Vida + p1.Escudo - e1.Daño;

                lblNamePlayer.Text = p1.GetName();
                lblHealthPlayer.Text = p1.GetHealth().ToString();
                lblDamagePlayer.Text = p1.GetDamage().ToString();
            }
            else
            {
                p1.Vida = p1.Vida + p1.Escudo - e1.Daño - 10;

                lblNamePlayer.Text = p1.GetName();
                lblHealthPlayer.Text = p1.GetHealth().ToString();
                lblDamagePlayer.Text = p1.GetDamage().ToString();
            }
        }

        // Utilidad para generar números aleatorios en un rango de valores
        public static int NumAleatorio(int inicio, int fin)
        {
            Random rnd = new Random();
            int randNum = rnd.Next(inicio, fin);
            return randNum;
        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
