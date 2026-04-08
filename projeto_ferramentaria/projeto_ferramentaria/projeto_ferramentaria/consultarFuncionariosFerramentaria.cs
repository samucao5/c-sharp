using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projeto_ferramentaria
{
    public partial class consultarFuncionariosFerramentaria : Form
    {
        public consultarFuncionariosFerramentaria()
        {
            InitializeComponent();
        }

        private void consultarFuncionariosFerramentaria_Load(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Menu"].Show();
        }
    }
}
