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
    }
}