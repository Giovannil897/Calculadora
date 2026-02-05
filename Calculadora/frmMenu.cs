namespace Calculadora
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void calculadoraSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.Show();
        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Burbuja burb = new Burbuja();
            burb.Show();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro reg = new Registro();
            reg.Show();
        }
    }
}
