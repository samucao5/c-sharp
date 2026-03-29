namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.String data = dateTimePicker1.Text;
            label2.Text = data;
            //caso queira pegar somente o mes
            //dateTimePicker1.Value.Month.ToString();
            //caso queira pegar somente o dia
            //dateTimePicker1.Value.Day.ToString();


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(textBox1.Text);
            int mes = int.Parse(textBox2.Text);
            int ano = int.Parse(textBox3.Text);

            DateTime data = new DateTime(ano, mes, dia);
            dateTimePicker1.Value = data;
        }
    }
}
