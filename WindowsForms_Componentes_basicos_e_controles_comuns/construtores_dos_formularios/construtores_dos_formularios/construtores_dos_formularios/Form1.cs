namespace construtores_dos_formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 janela = new Form2(this);
            janela.Show();
        }
    }
}
