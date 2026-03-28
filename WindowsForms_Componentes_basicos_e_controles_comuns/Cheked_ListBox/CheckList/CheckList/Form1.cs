namespace CheckList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            System.String options = "";
            foreach (var item in checkedListBox1.CheckedItems)
            {
                options += item + "\n";
            }
            MessageBox.Show($"o lanche tera:\n{options}");
            //caso queira adicionar um checkbox na list o comando e:
            //checkListBox1.Items.Add();
            //obs: usei CheckListBox1 porque e o nome que esta mais pode ser modificado

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.String nome_categoria;
            nome_categoria = textBox1.Text;
            if(nome_categoria != "")
            {
                checkedListBox1.Items.Add(nome_categoria);
            }
            else
            {
                MessageBox.Show("a caixa de texto esta vazia");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
