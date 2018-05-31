using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerococina2018
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Catalogos.Empleados form = new Catalogos.Empleados();
            form.ShowDialog();
        }
    }
}
