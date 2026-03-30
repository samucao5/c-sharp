namespace Arquivo_de_Recursos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.Texto_1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.Texto_2;
        }
    }
}
