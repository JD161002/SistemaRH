using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class datEntrevista
    {
        private static readonly datEntrevista _instancia = new datEntrevista();
        //privado para evitar la instanciación directa
        public static datEntrevista Instancia
        {
            get
            {
                return datEntrevista._instancia;
            }
        }


        public List<EntEntrevista> ListarEntrevistas()
        {
            SqlCommand cmd = null;
            List<EntEntrevista> lista = new List<EntEntrevista>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("ListarEntrevistas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntEntrevista Entre = new EntEntrevista();
                    Entre.id = Convert.ToInt32(dr["idEntrevista"]);
                    Entre.entrevistador = dr["Entrevistador"].ToString();
                    Entre.candidato = dr["Candidato"].ToString();
                    Entre.fecha = Convert.ToDateTime(dr["fecha"]);
                    Entre.oferta = dr["oferta"].ToString();
                    Entre.estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(Entre);
                }
            }
            catch (Exception e)
            {
                throw e;

            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        public Boolean InsertarEntrevista(EntEntrevista ent)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("AgregarEntrevista", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", ent.fecha);
                cmd.Parameters.AddWithValue("@Entrevistador", ent.entrevistador);
                cmd.Parameters.AddWithValue("@Candidato", ent.candidato);
                cmd.Parameters.AddWithValue("@oferta", ent.oferta);
                cmd.Parameters.AddWithValue("@Estado", ent.estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }
        public Boolean DeshabilitarEntrevista(EntEntrevista ent)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("DeshabilitarEntrevista", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEntrevista", ent.id);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { 
                cmd.Connection.Close();
            }
            return delete;
        }

    }
}
