namespace Abertura_de_novos_formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 janela = new Form2();
            //show: exibe a janela
            //ShowDialog não permitem que os dois estejam juntos, um so aparece se o outro for fechado
            janela.ShowDialog();
        }
    }
}
