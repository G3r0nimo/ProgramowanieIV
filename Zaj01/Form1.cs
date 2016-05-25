using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaj01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPolicz_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, Func<double, double, double>> operations 
                = new Dictionary<string, Func<double, double, double>>
            {
                {"+", (a, b) => a + b},
                {"-", (a, b) => a - b},
                {"*", (a, b) => a * b},
                {"/", (a, b) => a / b}
            };

            try
            {
                double liczba1 = double.Parse(txtLiczba1.Text);
                double liczba2 = double.Parse(txtLiczba2.Text);

                double wynik = operations[(sender as Button).Text](liczba1, liczba2);

                MessageBox.Show(wynik.ToString(),
                    "Wynik dodawania",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Niepoprawne dane",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }
    }
}
