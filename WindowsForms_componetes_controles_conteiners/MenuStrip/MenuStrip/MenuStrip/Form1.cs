namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void abrirJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Janela = new Form2();
            Janela.Show();
        }

        private void marcarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marcarToolStripMenuItem.Checked = !marcarToolStripMenuItem.Checked;
        }
    }
}
