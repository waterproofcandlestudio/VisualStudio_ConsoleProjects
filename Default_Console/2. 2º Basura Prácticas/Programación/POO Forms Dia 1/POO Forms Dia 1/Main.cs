using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Forms_Dia_1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Introduce n:");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    double fact = n;

        //    Fibonacci(n);
        //    FactIterative(n, fact);
        //}

        private string Fibonacci(int n)
        {
            string output = "";
            int first = 0;
            int second = 1;

            // Darle 2 veces a tabulador tras poner el for para 
            // construirlo entero casi automáticamente
            for (int i = 0; i < n; i++)
            {
                if (i == 0) output += "0";
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

        private static void FactIterative(int n, double fact)
        {
            for (int i = n; i > 1; i--)
            {
                fact = fact * i;
            }
        }

        private static void ShowFactRec(int n, double fact)
        {
            Console.WriteLine("El factorial de {0} es: {1}", n, fact);
        }

        private static double FactRecursive(int n)
        {
            if (n <= 1) return 1;
            else return FactRecursive(n - 1) * n;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(tbMain.Text);
            string text = "Sucesión de Fibonacci:\n";

            text += Fibonacci(n);
            text += "Factorial:\n";
            text += FactRecursive(n);

            lblText.Text = text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
