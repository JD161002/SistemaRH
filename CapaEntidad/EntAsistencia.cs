using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntAsistencia
    {
        public int Id { get; set; }

        public int idTrabajador {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime fecha { get; set; }
        public DateTime HoraIngreso { get; set; }
        public DateTime HoraSalida { get; set; }

    }
}
