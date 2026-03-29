namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("index alterado");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.String[] obj = { "004", "chave philips", "5", "Bosch" };

            ListViewItem item = new ListViewItem(obj);
            //contrutor -> vetor

            listView1.Items.Add(item);
            MessageBox.Show("ferramenta: " + obj[1] + " adicionada com sucesso");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //remover clicando no listview e apertando para remover no botao
            listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("id da ferramenta: " + listView1.SelectedItems[0].SubItems[0].Text);
            //SelectedItems -> Todos os items selecionados (coleção)
            //SubItems -> todos os SubItems (colação)

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //mostra quantos valores estão sendo selecionados
            MessageBox.Show("selecionados: "+ listView1.SelectedItems.Count.ToString());
        }
    }
}
