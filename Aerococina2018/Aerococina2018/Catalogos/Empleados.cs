using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerococina2018.Catalogos
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private async void Empleados_LoadAsync(object sender, EventArgs e)
        {
            await ObtenerEmpleados();
        }

        private async Task ObtenerEmpleados()
        {
            try
            {
                dgvEmpleados.AutoGenerateColumns = false;
                dgvEmpleados.DataSource = await Library.BL.EmpleadosBL.ObtenerListaEmpleados();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
