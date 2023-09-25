using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartado2_Práctica01_MiguelRodríguezGallego
{
    public partial class MenuListarJugadores : Form
    {
        // Listas para capturar los datos y luego mostrarlos en el form2        
        private List<Portero> porList = new List<Portero>();
        private List<Defensa> defList = new List<Defensa>();
        private List<Medio> medList = new List<Medio>();
        private List<Delantero> delList = new List<Delantero>();

        public MenuListarJugadores()
        {
            InitializeComponent();
            // Hago que empiece seleccionado el radio button de X
            rbPortero.Checked = true;
        }
        private void btnCapturarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbPortero.Checked)
                {
                    Portero por = new Portero(tbNombre.Text, "Portero", Convert.ToInt32(tbNumUniforme.Text), Convert.ToDouble(tbMinJugados.Text), 0);
                    porList.Add(por);
                }

                if (rbDefensa.Checked)
                {
                    Defensa def = new Defensa(tbNombre.Text, "Defensa", Convert.ToInt32(tbNumUniforme.Text), Convert.ToDouble(tbMinJugados.Text), Convert.ToInt32(tbGolesAnotados.Text));
                    defList.Add(def);
                }

                if (rbMedio.Checked)
                {
                    Medio med = new Medio(tbNombre.Text, "Medio", Convert.ToInt32(tbNumUniforme.Text), Convert.ToDouble(tbMinJugados.Text), Convert.ToInt32(tbGolesAnotados.Text));
                    medList.Add(med);
                }

                if (rbDelantero.Checked)
                {
                    Delantero del = new Delantero(tbNombre.Text, "Delantero", Convert.ToInt32(tbNumUniforme.Text), Convert.ToDouble(tbMinJugados.Text), Convert.ToInt32(tbGolesAnotados.Text));
                    delList.Add(del);
                }
            }
            catch
            {
                MessageBox.Show("Vuelve a introducir los valores correctamente", "Error!");
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {

            dgvJugadores.DataSource = porList;
            dgvJugadores.DataSource = defList;
            dgvJugadores.DataSource = medList;
            dgvJugadores.DataSource = delList;
        }

        private void btnSalir_Click_1(object sender, EventArgs e) => this.Close();

        private void rbPortero_CheckedChanged(object sender, EventArgs e)
        {
            tbGolesAnotados.Enabled = false;
        }

        private void rbDefensa_CheckedChanged(object sender, EventArgs e)
        {
            tbGolesAnotados.Enabled = true;
        }

        private void rbMedio_CheckedChanged(object sender, EventArgs e)
        {
            tbGolesAnotados.Enabled = true;
        }

        private void rbDelantero_CheckedChanged(object sender, EventArgs e)
        {
            tbGolesAnotados.Enabled = true;
        }
    }
}
