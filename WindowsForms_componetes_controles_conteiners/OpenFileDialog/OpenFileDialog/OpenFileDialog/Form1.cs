namespace OpenFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                StreamReader Reader = new StreamReader(file);
                System.String linha = Reader.ReadLine();
                while (linha != null)
                {
                    textBox1.Text += linha + '\n';
                    linha = Reader.ReadLine();
                }
                Reader.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
