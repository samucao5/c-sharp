namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TreeNode novo = treeView1.Nodes.Add("novo_valor");
            novo.Name = "valor Adicionado";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TreeNode novo = treeView1.Nodes.Add("novo_valor");
            TreeNode novo_filho = novo.Nodes.Add("novo_filho");

            novo_filho.Name = "filho adicionado";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TreeNode novo = treeView1.SelectedNode.Nodes.Add("novo filho");
        }
    }
}
