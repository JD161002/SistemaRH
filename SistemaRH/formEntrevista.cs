using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidad;

namespace SistemaRH
{
    public partial class formEntrevista : Form
    {
        public formEntrevista()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtCandidato.Text = "";
            txtEntrevistador.Text = "";
            txtOferta.Text = "";
            checkBox1.Checked = false;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LogEntrevista.Instancia.ListarEntrevista();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                EntEntrevista ent = new EntEntrevista();
                ent.fecha = dateTimePicker1.Value;
                ent.oferta = txtOferta.Text;
                ent.entrevistador = txtEntrevistador.Text;
                ent.candidato = txtCandidato.Text;
                ent.estado = checkBox1.Checked;

                LogEntrevista.Instancia.insertarEntrevista(ent);

                MessageBox.Show("Ingresado con exito");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                EntEntrevista ent = new EntEntrevista();
                ent.id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);


                LogEntrevista.Instancia.DeshabilitarEntrevista(ent);

                MessageBox.Show("exito");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            Limpiar();
        }
    }
}
