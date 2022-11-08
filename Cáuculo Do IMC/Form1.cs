using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cáuculo_Do_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
                       
            
            try
            {
                double n1 = double.Parse(txbN1.Text);
                double n2 = double.Parse(txbN2.Text);
                double r;

                r = n2 / (n1 * n1);
                txbResultado.Text = Math.Round(r,2).ToString();

                if (r < 18.5)
                {                    
                    lblIMC.Text = "Abaixo do peso";
                    lblIMC.ForeColor = Color.Black;
                }
                else if (r < 24.9)
                {                    
                    lblIMC.Text = "Peso ideal (párabens)";
                    lblIMC.ForeColor = Color.Green;
                }
                else if (r < 29.9)
                {                    
                    lblIMC.Text = "Levemente acima do peso";
                    lblIMC.ForeColor = Color.YellowGreen;
                }
                else if (r < 34.9)
                {                    
                    lblIMC.Text = "Obesidade grau |";
                    lblIMC.ForeColor = Color.Orange;
                }
                else if (r < 39.9)
                {                    
                    lblIMC.Text = "Obesidade grau || (severa)";
                    lblIMC.ForeColor = Color.Red;
                }
                else if (r > 40)
                {                    
                    lblIMC.Text = "Obesidade ||| (mórbida)";
                    lblIMC.ForeColor = Color.Purple;
                }
            }
            catch
            {
                MessageBox.Show("ERROR!", "Erro ao executar", MessageBoxButtons.OK);
            }
           
            




        }
    }
}
