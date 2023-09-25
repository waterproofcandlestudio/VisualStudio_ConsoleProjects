// Miguel Rodriguez Gallego
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
        // Creo un objeto que es una Lista de jugadoresGoleadores para capturar los datos y luego mostrarlos en el form2
        // Esta misma la instancio con el "new" para así crear un espacio de memoria para guardar los datos de la lista
        private List<JugadorFueraDePorteria> jugList = new List<JugadorFueraDePorteria>();

        public MenuListarJugadores()
        {
            InitializeComponent();
            // Hago que empiece seleccionado el radio button de X
            rbPortero.Checked = true;
        }
        // Boton capturar datos
        private void btnCapturarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbPortero.Checked)
                {
                    JugadorFueraDePorteria portero = new JugadorFueraDePorteria(tbNombre.Text, "Portero", Convert.ToInt32(tbNumUniforme.Text), Convert.ToDouble(tbMinJugados.Text), 0);
                    jugList.Add(portero);
                }

                if (rbDefensa.Checked)
                {
                    JugadorFueraDePorteria defensa = new JugadorFueraDePorteria(tbNombre.Text, "Defensa", Convert.ToInt32(tbNumUniforme.Text), Convert.ToDouble(tbMinJugados.Text), Convert.ToInt32(tbGolesAnotados.Text));
                    jugList.Add(defensa);
                }

                if (rbMedio.Checked)
                {
                    JugadorFueraDePorteria medio = new JugadorFueraDePorteria(tbNombre.Text, "Medio", Convert.ToInt32(tbNumUniforme.Text), Convert.ToDouble(tbMinJugados.Text), Convert.ToInt32(tbGolesAnotados.Text));
                    jugList.Add(medio);
                }

                if (rbDelantero.Checked)
                {
                    JugadorFueraDePorteria delantero = new JugadorFueraDePorteria(tbNombre.Text, "Delantero", Convert.ToInt32(tbNumUniforme.Text), Convert.ToDouble(tbMinJugados.Text), Convert.ToInt32(tbGolesAnotados.Text));
                    jugList.Add(delantero);
                }
            }
            catch
            {
                MessageBox.Show("Vuelve a introducir los valores correctamente", "Error!");
            }
        }

        // Método para rellenar las tablas con los datos de las listas
        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            // Primero igualo a null la base de datos de la tabla/dataGridView para refrescar los datos de  las listas al volver a mostrarlas de nuevo
            dgv.DataSource = null;
            // Igualo la base de datos de la tabla a la lista instanciada en la que guardé los datos para mostrarlos por pantalla
            dgv.DataSource = jugList;
        }
        // Boton cerrar programa
        private void btnSalir_Click_1(object sender, EventArgs e) => this.Close();

        // 4 Checkers para bloquear la casilla de goles al seleccionar su casilla pero activarla al seleccionar cualquier otra
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
