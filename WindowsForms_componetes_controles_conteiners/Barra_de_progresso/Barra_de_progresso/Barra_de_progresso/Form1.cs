namespace Barra_de_progresso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.String valor = textBox1.Text;
            progressBar1.Value = int.Parse(valor);

            if(progressBar1.Value == 100)
            {
                progressBar1.Visible = false;
            }
            else
            {
                progressBar1.Visible = true;
            }

        }
    }
}
