namespace mensagens_e_focagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.String nome = textBox1.Text;
            if (nome != "")
            {
                //abre uma pequena aba ao qual retorna a mensagem
                MessageBox.Show($"seu nome e: {nome}");
                //quando voce aperta no ok, ele volta direto para a o textbox.
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("a caixa de texto esta vazia");
                textBox1.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
