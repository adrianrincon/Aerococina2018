using Aerococina2018.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Aerococina2018.Library.DL;
namespace Aerococina2018.Library.BL
{
    public class EmpleadosBL
    {
        public static List<EmpleadosBE> ObtenerListaEmpleados()
        {
            var lista = new List<EmpleadosBE>();
            try
            {
                using (DL.Aerococina2018Entities ctx=new DL.Aerococina2018Entities())
                {
                    var listaEntity = ctx.empleados.ToList();
                    lista = Mapper.Map<List<empleados>, List<EmpleadosBE>>(listaEntity);
                }
            }
            catch (Exception ex)
            {

                throw ex ;
            }
            return lista;
        }
    }
}
