using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaLogica
{
    public class logTrabajador
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logTrabajador _instancia = new logTrabajador();
        //privado para evitar la instanciación directa
        public static logTrabajador Instancia
        {
            get
            {
                return logTrabajador._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entTrabajador> ListarTrabajador()
        {
            return datTrabajador.Instancia.ListarTrabajador();
        }
        #endregion metodos
    }
}
