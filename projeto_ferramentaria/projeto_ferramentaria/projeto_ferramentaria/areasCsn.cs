using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projeto_ferramentaria
{
    public partial class areasCsn : Form
    {
        public areasCsn()
        {
            InitializeComponent();
        }

        private void areasCsn_Load(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Menu"].Show();
        }

        private void enviarButton_Click(object sender, EventArgs e)
        {
            System.String area_csn = textBox1.Text;
            MessageBox.Show("area CSN: " + area_csn + " adicionado com sucesso");
        }
    }
}
