using CapaDatos;
using CapaEntidad;
using CapaLogica;
using System.Data;
using System.Data.SqlClient;

namespace SistemaRH




{
    public partial class formAsistencia : Form
    {
        public formAsistencia()
        {
            InitializeComponent();
            //listarAsistencia();
        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LogAsistencia.Instancia.ListarAsistencias();
            //dataGridView1.DataSource = LogEntrevista.Instancia.ListarEntrevista();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                EntAsistencia ent = new EntAsistencia();
                ent.idTrabajador = Convert.ToInt32(txtNombre.Text);
                ent.fecha = dateTimePicker1.Value;
                ent.HoraIngreso = dtpHoraIngreso.Value;
                ent.HoraSalida = dtpHoraSalida.Value;

                LogAsistencia.Instancia.insertarAsistencia(ent);

                //MessageBox.Show(txtApellido.Text);
                //MessageBox.Show(txtNombre.Text);

                //MessageBox.Show(ent.fecha.ToString());
                //MessageBox.Show(dtpHoraIngreso.Value.ToString());
                //MessageBox.Show(dtpHoraSalida.Value.ToString());

                MessageBox.Show("Ingresado con exito");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            Limpiar();

        }


        private void Limpiar()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el valor del IDAsistencia de la fila seleccionada
                int idAsistencia = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                EntAsistencia ent = new EntAsistencia();
                ent.Id = idAsistencia;

                LogAsistencia.Instancia.EliminarAsistencia(ent);
                MessageBox.Show("Deshabilitacion Exitosa");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una asistencia para eliminar.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void forEntrevista_Click_1(object sender, EventArgs e)
        {
            formEntrevista formEntrevista = new formEntrevista();

            formEntrevista.Show();
        }
    }
}