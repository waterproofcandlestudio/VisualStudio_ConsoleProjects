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
    public partial class Form1 : Form
    {
        private Portero por = new Portero("none", "Portero", 0, 0, 0);
        private Defensa def = new Defensa("none", "Defensa", 0, 0, 0);
        private Medio med = new Medio("none", "Medio", 0, 0, 0);
        private Delantero del = new Delantero("none", "Delantero", 0, 0, 0);

        public Form1()
        {
            InitializeComponent();
            NombrarCoordenadas();
        }
        private void NombrarCoordenadas()
        {
            rbPortero.Text = por.posicion;
            rbDefensa.Text = def.posicion;
            rbMedio.Text = med.posicion;
            rbDelantero.Text = del.posicion;
        }

        private void btnCapturarDatos_Click(object sender, EventArgs e)
        {
            if (rbPortero.Checked)
            {
                por.numUnif = Convert.ToInt32(tbNumUniforme.Text);
                por.nombre = tbNombre.Text;
                por.minJug = Convert.ToDouble(tbMinJugados.Text);
            }

            if (rbDefensa.Checked)
            {
                def.numUnif = Convert.ToInt32(tbNumUniforme.Text);
                def.nombre = tbNombre.Text;
                def.minJug = Convert.ToDouble(tbMinJugados.Text);
                def.golAnot = Convert.ToInt32(tbGolesAnotados.Text);
            }

            if (rbMedio.Checked)
            {
                med.numUnif = Convert.ToInt32(tbNumUniforme.Text);
                med.nombre = tbNombre.Text;
                med.minJug = Convert.ToDouble(tbMinJugados.Text);
                med.golAnot = Convert.ToInt32(tbGolesAnotados.Text);
            }

            if (rbDelantero.Checked)
            {                
                del.numUnif = Convert.ToInt32(tbNumUniforme.Text);
                del.nombre = tbNombre.Text;
                del.minJug = Convert.ToDouble(tbMinJugados.Text);
                del.golAnot = Convert.ToInt32(tbGolesAnotados.Text);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            if (rbPortero.Checked)
            {
                lblMostrarPosicion.Text = por.posicion;
                lblMostrarNumUnif.Text = por.numUnif.ToString();
                lblMostrarNombre.Text = por.nombre;
                lblMostrarMinJug.Text = por.minJug.ToString();
                lblMostrarGolAnot.Text = por.golAnot.ToString();
            }

            if (rbDefensa.Checked)
            {
                lblMostrarPosicion.Text = def.posicion;
                lblMostrarNumUnif.Text = def.numUnif.ToString();
                lblMostrarNombre.Text = def.nombre;
                lblMostrarMinJug.Text = def.minJug.ToString();
                lblMostrarGolAnot.Text = def.golAnot.ToString();
            }

            if (rbMedio.Checked)
            {
                lblMostrarPosicion.Text = med.posicion;
                lblMostrarNumUnif.Text = med.numUnif.ToString();
                lblMostrarNombre.Text = med.nombre;
                lblMostrarMinJug.Text = med.minJug.ToString();
                lblMostrarGolAnot.Text = med.golAnot.ToString();
            }

            if (rbDelantero.Checked)
            {
                lblMostrarPosicion.Text = del.posicion;
                lblMostrarNumUnif.Text = del.numUnif.ToString();
                lblMostrarNombre.Text = del.nombre;
                lblMostrarMinJug.Text = del.minJug.ToString();
                lblMostrarGolAnot.Text = del.golAnot.ToString();
            }
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
