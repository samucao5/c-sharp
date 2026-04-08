using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projeto_ferramentaria
{
    public partial class localferramentaria : Form
    {
        public localferramentaria()
        {
            InitializeComponent();
        }

        private void localferramentaria_Load(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Menu"].Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.String local_f = textBox1.Text;
            MessageBox.Show("local ferramentaria: "+local_f+" adicionado com sucesso");
        }
    }
}
