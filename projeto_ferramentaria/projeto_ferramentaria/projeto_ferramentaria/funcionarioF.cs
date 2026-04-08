using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projeto_ferramentaria
{
    public partial class funcionarioF : Form
    {
        public funcionarioF()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Menu"].Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.String nome_funcionario_f = textBox1.Text;
            System.String Matricula_CSN = comboBox3.Text + textBox2.Text;
            DateTime data_nascimento = DateTime.Parse(maskedTextBox1.Text);
            System.String cargo = comboBox1.Text;
            System.String local_f = comboBox4.Text;
            System.String area_csn = comboBox2.Text;

            MessageBox.Show("Funcionario f: "+nome_funcionario_f+"\n"+Matricula_CSN+"\n"+data_nascimento.ToString("dd/MM/yyyy")+"\n"+cargo+"\n"+local_f+"\n"+area_csn+"\n adicionado com sucesso");
        }
    }
}
