using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica01_MiguelRodríguezGallego
{
    public partial class MenuCoordenadas : Form
    {
        private Punto1 p1 = new Punto1("Punto 1", 0, 0);
        private Punto2 p2 = new Punto2("Punto 2", 0, 0);        

        public MenuCoordenadas()
        {
            InitializeComponent();
            NombrarCoordenadas();
            // Hago que empiece seleccionado el radio button de X
            rb1.Checked = true;
        }
        private void NombrarCoordenadas()
        {
            rb1.Text = p1.name;
            rb2.Text = p2.name;
        }

        // Coge "X" e "Y" segun el punto escogido con los "RadioButtons" 1 y 2
        private void btnCapturarCoordenadas_Click(object sender, EventArgs e)
        {
            try
            {
                // X
                if (rb1.Checked)
                {
                    p1.x = Convert.ToInt32(tbX.Text);
                }
                if (rb2.Checked)
                {
                    p2.x = Convert.ToInt32(tbX.Text);
                }
                // Y
                if (rb1.Checked)
                {
                    p1.y = Convert.ToInt32(tbY.Text);
                }
                if (rb2.Checked)
                {
                    p2.y = Convert.ToInt32(tbY.Text);
                }
            }
            catch
            {
                MessageBox.Show("Vuelve a introducir los valores correctamente", "Error!");
            }
        }
        // Calcular y mostrar el resultado final de la distancia entre puntos
        // El Math.Pow() sirve para elevar un número a cierta cantidad y funciona así ==> Math.Pow(numero, 2) == [número al cuadrado]
        // El Math.Sqrt() sirve para hacer la raiz cuadrada de 1 número
        private void btnCalDist_Click(object sender, EventArgs e)
        {
            double distancia = Math.Sqrt(Math.Pow((p2.x - p1.x), 2) + Math.Pow((p2.y - p1.y), 2));
            MessageBox.Show(distancia.ToString(), "Resultado");  
        }
        // Botón salir ==> Cerrar programa
        private void btnSalir_Click(object sender, EventArgs e) => this.Close();
    }
}
