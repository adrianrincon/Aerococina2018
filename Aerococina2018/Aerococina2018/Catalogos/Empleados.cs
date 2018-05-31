﻿using System;
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

        private void Empleados_Load(object sender, EventArgs e)
        {
            ObtenerEmpleados();
        }

        private void ObtenerEmpleados()
        {
            try
            {
                dgvEmpleados.AutoGenerateColumns = false;
                dgvEmpleados.DataSource = Library.BL.EmpleadosBL.ObtenerListaEmpleados();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
