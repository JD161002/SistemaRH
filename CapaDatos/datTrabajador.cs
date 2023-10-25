using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datTrabajador
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datTrabajador _instancia = new datTrabajador();
        //privado para evitar la instanciación directa
        public static datTrabajador Instancia
        {
            get
            {
                return datTrabajador._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Clientes
        public List<entTrabajador> ListarTrabajador()
        {
            SqlCommand cmd = null;
            List<entTrabajador> lista = new List<entTrabajador>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarTrabajador", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTrabajador Tra = new entTrabajador();
                    Tra.idTrabajador = Convert.ToInt32(dr["idTrabajador"]);
                    Tra.Nombre = dr["Nombre"].ToString();
                    Tra.Apellido = dr["Apellido"].ToString();
                    Tra.FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]);
                    Tra.Genero = dr["Genero"].ToString();
                    Tra.CorreoElectronico = dr["CorreoElectronico"].ToString();
                    Tra.Telefono = dr["Telefono"].ToString();
                    Tra.Direccion = dr["Direccion"].ToString();
                    Tra.Departamento = dr["Departamento"].ToString();
                    Tra.Puesto = dr["Puesto"].ToString();
                    lista.Add(Tra);              
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
        #endregion metodos
    }
}
