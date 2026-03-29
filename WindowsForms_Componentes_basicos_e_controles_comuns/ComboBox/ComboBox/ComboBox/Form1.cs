namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.String adicionar_categoria;
            adicionar_categoria = textBox1.Text;

            if(adicionar_categoria != "")
            {
                comboBox1.Items.Add(adicionar_categoria);
                MessageBox.Show("cargo: " + adicionar_categoria + " adicionado no comboBox");
            }
            else
            {
                MessageBox.Show("caixa de texto esta vazia");
                textBox1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cargo: "+comboBox1.Text+" escolhido com sucesso");
        }
    }
}
