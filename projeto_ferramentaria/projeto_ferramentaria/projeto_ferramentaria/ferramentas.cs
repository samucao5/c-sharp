using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projeto_ferramentaria
{
    public partial class ferramentas : Form
    {
        public ferramentas()
        {
            InitializeComponent();
        }

        private void ferramentas_Load(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Menu"].Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.String nome_ferramenta = textBox2.Text;
            int estoque_ferramenta = int.Parse(textBox1.Text);
            System.String local_f = comboBox1.Text;
            System.String categoria_f = comboBox2.Text;

            MessageBox.Show("ferramenta:"+nome_ferramenta+"\n"+estoque_ferramenta+"\n"+local_f+"\n"+categoria_f+"\n adicionada com sucesso");
        }
    }
}
