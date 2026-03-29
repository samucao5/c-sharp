namespace LinkLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //primeiro parametro e onde esta localizado o navegador, ja o segundo e o link que deseja abrir no navegador
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe", "https://github.com/samucao5");
        }
    }
}
