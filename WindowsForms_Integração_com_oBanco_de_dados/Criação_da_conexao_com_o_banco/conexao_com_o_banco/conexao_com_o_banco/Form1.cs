using System.Data;
using System.Data.SQLite;

namespace conexao_com_o_banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //funciona mais e melhor usar o metodo abaixo
        //public SQLiteConnection conexao = = new SQLiteConnection("\"C:\\Users\\samue\\Music\\C#\\windowsForms_banco_de_dados\\Criação_da_conexao_com_o_banco\\conexao_com_o_banco\\conexao_com_o_banco\\database.db\"");

        public SQLiteConnection conexao;
        public SQLiteConnection obterConexao() 
        {
            System.String local_banco = "\"C:\\Users\\samue\\Music\\C#\\windowsForms_banco_de_dados\\Criação_da_conexao_com_o_banco\\conexao_com_o_banco\\conexao_com_o_banco\\database.db\"";
            conexao = new SQLiteConnection(local_banco);
            conexao.Open();
            return conexao;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
