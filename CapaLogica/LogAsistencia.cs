using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class LogAsistencia
    {

        private static readonly LogAsistencia _instancia = new LogAsistencia();
        //privado para evitar la instanciación directa
        public static LogAsistencia Instancia
        {
            get
            {
                return LogAsistencia._instancia;
            }
        }
        ///listado

        public List<EntAsistencia> ListarAsistencias()
        {
            return datAsistencia.Instancia.ListarAsistencias();
        }


        public void insertarAsistencia(EntAsistencia ent)
        {
            datAsistencia.Instancia.InsertarAsistencia(ent);
        }


        public void EliminarAsistencia(EntAsistencia ent)
        {
            datAsistencia.Instancia.DeshabilitarAsistencia(ent);
        }
    }
}
