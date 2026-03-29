namespace MaskedTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                MessageBox.Show(maskedTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (maskedTextBox2.PasswordChar.Equals('*'))
            {
                maskedTextBox2.PasswordChar = '\0';
                button2.Text = "ocultar";
            }
            else
            {
                maskedTextBox2.PasswordChar = '*';
                button2.Text = "visualizar";
            }
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
