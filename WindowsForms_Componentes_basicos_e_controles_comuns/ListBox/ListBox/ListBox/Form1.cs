namespace ListBox
{
    public partial class Form1 : Form
    {
        List<System.String> options = new List<System.String>();


        public Form1()
        {
            InitializeComponent();
            options.Add("martelo");
            options.Add("alicate de corte");
            options.Add("alicate universal");

            listBox1.DataSource = options;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Text != "")
            {
                MessageBox.Show($"ferramenta escolhida: {listBox1.Text}");
            }
            else
            {
                MessageBox.Show("nenhuma opção escolhida");
                listBox1.Focus();
            }
        }
    }
}
