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
        // Instancio las clases aquí solamente para poder acceder a los datos de la posición y mostrarlos en el dataGridView al enseñar la lista por pantalla
        readonly Portero por = new Portero();
        readonly Defensa def = new Defensa();
        readonly Medio med = new Medio();
        readonly Delantero del = new Delantero();

        // Listas para capturar los datos y luego mostrarlos en el form2        
        private readonly List<Portero> porList = new List<Portero>();
        private readonly List<Defensa> defList = new List<Defensa>();
        private readonly List<Medio> medList = new List<Medio>();
        private readonly List<Delantero> delList = new List<Delantero>();

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
                    Portero portero = new Portero(tbNombre.Text, por.Posicion, Convert.ToInt32(tbNumUniforme.Text), Convert.ToDouble(tbMinJugados.Text), 0);
                    porList.Add(portero);
                }

                if (rbDefensa.Checked)
                {
                    Defensa defensa = new Defensa(tbNombre.Text, def.Posicion, Convert.ToInt32(tbNumUniforme.Text), Convert.ToDouble(tbMinJugados.Text), Convert.ToInt32(tbGolesAnotados.Text));
                    defList.Add(defensa);
                }

                if (rbMedio.Checked)
                {
                    Medio medio = new Medio(tbNombre.Text, med.Posicion, Convert.ToInt32(tbNumUniforme.Text), Convert.ToDouble(tbMinJugados.Text), Convert.ToInt32(tbGolesAnotados.Text));
                    medList.Add(medio);
                }

                if (rbDelantero.Checked)
                {
                    Delantero delantero = new Delantero(tbNombre.Text, del.Posicion, Convert.ToInt32(tbNumUniforme.Text), Convert.ToDouble(tbMinJugados.Text), Convert.ToInt32(tbGolesAnotados.Text));
                    delList.Add(delantero);
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
            dgvPorteros.DataSource = null;
            // Igualo la base de datos de la tabla a la lista instanciada en la que guardé los datos para mostrarlos por pantalla
            dgvPorteros.DataSource = porList;

            dgvDefensas.DataSource = null;
            dgvDefensas.DataSource = defList;

            dgvMedios.DataSource = null;
            dgvMedios.DataSource = medList;

            dgvDelanteros.DataSource = null;
            dgvDelanteros.DataSource = delList;
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
