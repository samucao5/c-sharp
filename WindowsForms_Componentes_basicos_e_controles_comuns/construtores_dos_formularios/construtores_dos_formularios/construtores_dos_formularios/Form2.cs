using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace construtores_dos_formularios
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 valor) //Construtor
        {
            InitializeComponent();
            form1 = valor;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.button1.Text = "você ja clicou";
        }
    }
}
