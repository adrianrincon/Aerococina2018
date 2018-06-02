using Aerococina2018.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Aerococina2018.Library.DL;
using System.Data.Entity;

namespace Aerococina2018.Library.BL
{
    public class EmpleadosBL
    {
        public static async Task<List<EmpleadosBE>> ObtenerListaEmpleados()
        {
            var lista = new List<EmpleadosBE>();
            try
            {
                using (DL.Aerococina2018Entities ctx=new DL.Aerococina2018Entities())
                {
                    var listaEntity = await ctx.empleados.ToListAsync();
                    lista = Mapper.Map<List<empleados>, List<EmpleadosBE>>(listaEntity);
                }
            }
            catch (Exception ex)
            {

                throw ex ;
            }
            return lista;
        }

        public static async Task<bool> AgregarEmpleado(EmpleadosBE item)
        {
            bool resultado = false;
            try
            {
                using (Library.DL.Aerococina2018Entities ctx = new Aerococina2018Entities())
                {
                    var objEntity = Mapper.Map<EmpleadosBE, empleados>(item);
                    ctx.empleados.Add(objEntity);
                    await ctx.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;
        }
    }
}
