using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0;
                a = Convert.ToInt32(VariableA.Text);
                a = Convert.ToInt32(VariableA.Text);
                int b = 0;
                b = Convert.ToInt32(VariableB.Text);
                int c = a + b;
                MessageBox.Show("El resultado es " + c.ToString(), "sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo realizar la operacion", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            VariableA.ResetText();
            VariableB.ResetText();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
