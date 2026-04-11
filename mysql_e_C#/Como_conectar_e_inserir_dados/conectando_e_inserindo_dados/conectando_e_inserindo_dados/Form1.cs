using MySql.Data.MySqlClient;
namespace conectando_e_inserindo_dados
  
{
    public partial class Form1 : Form
    {
        MySqlConnection conexao;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.String data_source = "datasource=localhost;username=root;password=;database=db_agenda";
                //criar conexão com MySQL
                conexao = new MySqlConnection(data_source);


                //executar Comando Insert
                System.String sql = "INSERT INTO contato (nome_contato, email, telefone) VALUES (@nome ,@email ,@telefone)";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTel.Text);

                //abrir a conexão 
                conexao.Open();

                //executa o comando INSERT
                cmd.ExecuteReader();

                MessageBox.Show("usuario cadastrado com sucesso");

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                conexao.Close();
            }
        }
    }
}
