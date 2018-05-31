using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerococina2018.BE
{
    public class Configuracion
    {
        public int cve_configuracion { get; set; }
        public string descripcion { get; set; }
        public string contrasena { get; set; }
        public DateTime fecha_registro { get; set; }
    }
}
