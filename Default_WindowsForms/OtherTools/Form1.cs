using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtherTools
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();

            //this.StartPosition = FormStartPosition.Manual;
            //FormBorderStyle = FormBorderStyle.FixedSingle;
            //MaximizeBox = false;
            //MinimizeBox = false;

            //form2.StartPosition = FormStartPosition.Manual;
            //form2.FormBorderStyle = FormBorderStyle.FixedSingle;
            //form2.MaximizeBox = false;
            //form2.MinimizeBox = false;

            int formsOffset = 410;

            this.Location =
                new Point
                (
                    (int)((Screen.PrimaryScreen.WorkingArea.Width - this.Width) * 0.5f) - formsOffset,
                    (int)((Screen.PrimaryScreen.WorkingArea.Height - this.Height) * 0.5f)
                );

            form2.Location =
                new Point
                (
                    (int)((Screen.PrimaryScreen.WorkingArea.Width - form2.Width) * 0.5f) + formsOffset,
                    (int)((Screen.PrimaryScreen.WorkingArea.Height - form2.Height) * 0.5f)
                );

            form2.Show(this);

            form2.Disposed += (object sender, EventArgs e) => this.Close();

            //form2.Disposed += new System.EventHandler((object sender, EventArgs e) => this.Close());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sobrecarga 7
            DialogResult result = MessageBox.Show("Yes, No or Cancel?", "Message Box 01", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                MessageBox.Show("aquí el valor de la distancia", "Distancia", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}
