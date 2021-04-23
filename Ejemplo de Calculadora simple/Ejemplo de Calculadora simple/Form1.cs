using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_de_Calculadora_simple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            Double Num1 = 0;
            Double Num2 = 0;
            Double Operacion = 0;

            Num1 = Double.Parse(TxtNum1.Text);
            Num2 = Double.Parse(TxtNum2.Text);

            Operacion = Num1 + Num2;

            MessageBox.Show("El resultado es " + Operacion);
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            Double Num1 = 0;
            Double Num2 = 0;
            Double Operacion = 0;

            Num1 = Double.Parse(TxtNum1.Text);
            Num2 = Double.Parse(TxtNum2.Text);

            Operacion = Num1 - Num2;

            MessageBox.Show("El resultado es " + Operacion);
        }

        private void BtnMultiplicacion_Click(object sender, EventArgs e)
        {
            Double Num1 = 0;
            Double Num2 = 0;
            Double Operacion = 0;

            Num1 = Double.Parse(TxtNum1.Text);
            Num2 = Double.Parse(TxtNum2.Text);

            Operacion = Num1 * Num2;

            MessageBox.Show("El resultado es " + Operacion);
        }

        private void BtnDivicion_Click(object sender, EventArgs e)
        {
            Double Num1 = 0;
            Double Num2 = 0;
            Double Operacion = 0;

            Num1 = Double.Parse(TxtNum1.Text);
            Num2 = Double.Parse(TxtNum2.Text);

            Operacion = Num1 / Num2;

            MessageBox.Show("El resultado es " + Operacion);
        }
    }
}
