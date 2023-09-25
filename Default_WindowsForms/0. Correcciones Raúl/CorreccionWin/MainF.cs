using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorreccionWin
{
    public partial class MainF : Form
    {
        public MainF()
        {
            InitializeComponent();
        }

        private string Fibonacci(int n)
        {
            string output = "";

            double first = 0;
            double second = 1;

            for (int i = 0; i < n; i++)
            {
                if (i == 0) output += "0";
                else if (i == 1) output += ", 1";
                else
                {
                    double current = first + second;
                    output += ", " + current;
                    first = second;
                    second = current;
                }
            }

            return output;
        }

        private double FactRecursive(int n)
        {
            if (n <= 1) return 1;
            else return FactRecursive(n - 1) * n;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(tbMain.Text);
            string text = "Sucesión de Fibonacci:\n";

            text += Fibonacci(n) + "\n";
            text += "Factorial:\n";
            text += FactRecursive(n);

            lblText.Text = text;
        }
    }
}
