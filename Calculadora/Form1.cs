using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
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

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            // Obter os números do form:
            double n1, n2;
            n1 = double.Parse(txtNum1.Text);
            n2 = double.Parse(txtNum2.Text);
            // Verificar qual operação fo selecionada:
            if (rbSoma.Checked == true)
            {
                lblResultado.Text = (n1+ n2).ToString();
            }
            else if (rbSub.Checked == true)
            {
               lblResultado.Text = (n1 - n2).ToString();
            }
            else if (rbMulti.Checked == true)
            {
                lblResultado.Text = (n1 * n2).ToString();
            }
            else if (rbDiv.Checked == true)
            {
                lblResultado.Text = (n1 / n2).ToString();
            }
            else
            {
                lblResultado.Text = "Nnenhuma operação escolhida!";
            }
        }
    }
}
