using CapaEntidad;
using CapaLogica;

namespace SistemaRH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listarTrabajador();
        }

        public void listarTrabajador()
        {
            dataGridView1.DataSource = logTrabajador.Instancia.ListarTrabajador();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}