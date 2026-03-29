namespace MounthCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("o dia selecionado e: "+monthCalendar1.SelectionStart.ToShortDateString());
            //caso queira pegar a data_atual e so utilizar o comando
            //monthCalendar1.TodayDate.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
