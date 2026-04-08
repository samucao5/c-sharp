using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projeto_ferramentaria
{
    public partial class cadastroFuncionarios : Form
    {
        public cadastroFuncionarios()
        {
            InitializeComponent();
        }

        private void cadastroFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Menu"].Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.String Nome_funcionario = textBox1.Text;
            System.String matricula = comboBox3.Text + textBox2.Text;
            DateTime data_nascimento = DateTime.Parse(maskedTextBox1.Text);
            System.String cargo = comboBox1.Text;
            System.String Area_CSN = comboBox2.Text;

            MessageBox.Show("Funcionario: \n" + Nome_funcionario + "\n" + matricula + "\n" + data_nascimento.ToString("dd/MM/yyyy") + "\n" + cargo + "\n" + Area_CSN + "\n adicionado com sucesso");
        }
    }
}
