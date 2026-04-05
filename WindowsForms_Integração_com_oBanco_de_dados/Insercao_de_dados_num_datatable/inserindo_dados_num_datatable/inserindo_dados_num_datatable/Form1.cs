using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace inserindo_dados_num_datatable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public SQLiteConnection conexao;
        public SQLiteConnection obterConexao()
        {
            //No System.Data.SQLite, a string precisa ser assim:
            //"Data Source=C:\\Users\\samue\\Music\\C#\\windowsForms_banco_de_dados\\Criação_da_conexao_com_o_banco\\conexao_com_o_banco\\conexao_com_o_banco\\database.db;Version=3;"
            System.String local_banco = "Data Source=C:\\Users\\samue\\Music\\C#\\windowsForms_banco_de_dados\\Criação_da_conexao_com_o_banco\\conexao_com_o_banco\\conexao_com_o_banco\\database.db;Version=3;";
            conexao = new SQLiteConnection(local_banco);
            conexao.Open();
            return conexao;
        }

        public DataTable ObterProdutos()
        {
            SQLiteDataAdapter da;
            DataTable dt = new DataTable();

            var cmd = obterConexao().CreateCommand();
            cmd.CommandText = "SELECT * FROM produtos";

            da = new SQLiteDataAdapter(cmd.CommandText, obterConexao());
            da.Fill(dt);

            return dt;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
