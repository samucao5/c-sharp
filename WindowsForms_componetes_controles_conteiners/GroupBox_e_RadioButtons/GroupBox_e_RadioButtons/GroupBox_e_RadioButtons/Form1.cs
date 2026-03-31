namespace GroupBox_e_RadioButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.String valor_marcado = R_marcado();
            MessageBox.Show(valor_marcado);
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public System.String R_marcado()
        {
            if (radioButton1.Checked)
            {
                return radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                return radioButton2.Text;
            }
            else
            {
                return radioButton3.Text;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (RadioButton rb in groupBox2.Controls)
            {
                if (rb.Checked)
                {
                    MessageBox.Show(rb.Text);
                }
            }
        }
    }
}
