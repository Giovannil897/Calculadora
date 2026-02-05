using Calculadora.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Registro : Form
    {
        List<Personas> persona = new List<Personas>();
        public Registro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            persona.Add(new Personas() { Nombre = tbNombre.Text, Apellido = tbApellido.Text, Fecha = dtbFecha.Value });
            MessageBox.Show("registrao con exito");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                dgvpersonas.DataSource = null;
                dgvpersonas.DataSource = persona;
            }
        }
    }
}
