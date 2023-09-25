using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFibFac
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string text;

            try
            {
                int n = Convert.ToInt32(tbNumber.Text);
                text = "Sucesión de Fibonacci:\n";

                text += Fibonnaci(n) + "\n";
                text += "Factorial:\n";
                text += FactorialRecFunct(n);
            }
            catch(FormatException ex)
            {
                text = ex.Message;
            }

            lblResult.Text = text;
        }

        private string Fibonnaci(int n)
        {
            string output = "";

            int first = 0;
            int second = 1;

            for (int i = 0; i < n; i++)
            {
                if (i == 0)      output += "0";
                else if (i == 1) output += ", 1";
                else
                {
                    int current = first + second;
                    output += ", " + current;
                    first = second;
                    second = current;
                }
            }

            return output;
        }

        private double FactorialRecFunct(double n)
        {
            if (n <= 0) return 0;
            else if (n == 1) return 1;
            else return FactorialRecFunct(n - 1) * n;
        }
    }
}
