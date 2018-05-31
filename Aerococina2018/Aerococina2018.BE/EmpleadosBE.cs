using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerococina2018.BE
{
    public class EmpleadosBE
    {
        //Propiedades nativas, igual que en BD
        public int cve_empleado { get; set; }
        public int num_empleado { get; set; }
        public string nombre { get; set; }
        public bool estatus { get; set; }
        public DateTime fecha_registro { get; set; }

        //Propiedades agregadas
        public string estatus_descripcion
        {
            get { return estatus ? "Activo" : "Baja"; }
        }
    }
}
