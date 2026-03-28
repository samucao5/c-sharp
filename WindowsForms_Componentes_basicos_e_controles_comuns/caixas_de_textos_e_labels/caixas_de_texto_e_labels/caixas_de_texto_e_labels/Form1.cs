namespace caixas_de_texto_e_labels
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.String nome_pessoa = textBox1.Text;
            if(nome_pessoa != "")
            {
                label3.Text = "";
                label1.Text = "boa tarde," + nome_pessoa;
                
            }
            else
            {
                label3.Text = "erro, digite algo na textbox";
            }
            
        }
    }
}
