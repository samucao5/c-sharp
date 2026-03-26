namespace botoes_e_evento
{
    public partial class Form1 : Form
    {
        int contagem = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (contagem == 0)
            {
                button1.Text = "voce clicou no botao";
                contagem += 1;
            }
            else if (contagem >= 1)
            {
                button1.Text = "voce clicou no botao pela " + contagem;
                contagem += 1;
            }

                    
        }
    }
}
