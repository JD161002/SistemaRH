using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntEntrevista
    {

        public int id {  get; set; }
        public string oferta { get; set; }
        public bool estado { get; set; }
        public string entrevistador { get; set; }
        public string candidato { get; set; }
        public DateTime fecha { get; set; }
    }
}
