namespace ToolStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("primeiro botão do ToolStrip funcionou");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form2 Janela = new Form2();
            Janela.ShowDialog();
        }
    }
}
