using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogEntrevista
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogEntrevista _instancia = new LogEntrevista();
        //privado para evitar la instanciación directa
        public static LogEntrevista Instancia
        {
            get
            {
                return LogEntrevista._instancia;
            }
        }
        #endregion singleton



        public List<EntEntrevista> ListarEntrevista()
        {
            return datEntrevista.Instancia.ListarEntrevistas();
        }

        public void insertarEntrevista(EntEntrevista ent)
        {
            datEntrevista.Instancia.InsertarEntrevista(ent);
        }


        public void DeshabilitarEntrevista(EntEntrevista ent)
        {
            datEntrevista.Instancia.DeshabilitarEntrevista(ent);
        }


    }
}
