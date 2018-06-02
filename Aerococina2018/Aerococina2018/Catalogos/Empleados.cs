using Aerococina2018.BE;
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

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != string.Empty && txtNumEmpleado.Text != string.Empty)
            {
                EmpleadosBE obj = new EmpleadosBE()
                {
                    estatus = rActivo.Checked ? true : false,
                    fecha_registro = DateTime.Now,
                    nombre = txtNombre.Text.ToUpper(),
                    num_empleado = int.Parse(txtNumEmpleado.Text)
                };

                var result=await Library.BL.EmpleadosBL.AgregarEmpleado(obj);
                if(result)
                {
                    MessageBox.Show("Se guardo correctamente!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Todos los campos son requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
