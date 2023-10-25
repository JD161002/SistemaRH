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
    public class datAsistencia
    {
        //patron de Diseño Singleton

        private static readonly datAsistencia _instancia = new datAsistencia();
        //privado para evitar la instanciación directa
        public static datAsistencia Instancia
        {
            get
            {
                return datAsistencia._instancia;
            }
        }

        public List<EntAsistencia> ListarAsistencias()
        {
            SqlCommand cmd = null;
            List<EntAsistencia> lista = new List<EntAsistencia>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("ListarAsistencias", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntAsistencia Asist = new EntAsistencia();



                    Asist.Id = Convert.ToInt32(dr["idAsistencia"]);
                    Asist.idTrabajador = Convert.ToInt32(dr["idTrabajador"]);
                    Asist.Nombre = dr["Nombre"].ToString();
                    Asist.Apellido = dr["Apellido"].ToString();
                    Asist.fecha = Convert.ToDateTime(dr["fecha"]);
                    Asist.HoraIngreso = Convert.ToDateTime(dr["HoraEntrada"]);
                    Asist.HoraSalida = Convert.ToDateTime(dr["HoraSalida"]);
                    lista.Add(Asist);
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


       
        public Boolean InsertarAsistencia(EntAsistencia asist)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("RegistrarAsistencia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTrabajador", asist.idTrabajador);
                cmd.Parameters.AddWithValue("@fecha", asist.fecha);
                cmd.Parameters.AddWithValue("@FechaEntrada", asist.HoraIngreso);
                cmd.Parameters.AddWithValue("@FechaSalida", asist.HoraSalida);
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
        public Boolean DeshabilitarAsistencia(EntAsistencia asist)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EliminarAsistencia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idAsistencia", asist.Id);
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
            finally { cmd.Connection.Close(); }
            return delete;
        }

    }
}
