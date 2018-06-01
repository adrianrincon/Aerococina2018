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
            AutoMapper.Mapper.Initialize(c => c.AddProfile<MappingProfile>());
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogos.Empleados form = new Catalogos.Empleados();
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }
    }
}
