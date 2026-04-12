using MySql.Data.MySqlClient;
namespace Inserir_dados
{
    public partial class Form1 : Form
    {

        private MySqlConnection conn;
        private System.String data_source = "datasource=localhost;username=root;password=@Samuel5;database=db_agenda";

        public Form1()
        { 
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                
                conn = new MySqlConnection(data_source); 
                MySqlCommand cmd = new MySqlCommand();
                //conecta com o banco de dados
                cmd.Connection = conn;

                conn.Open();

                //
                cmd.CommandText = "INSERT INTO contato (nome_contato, email, telefone) VALUES (@nome, @email, @telefone)";

                //Ele serve para pré-compilar o comando SQL no banco antes de executar.
                //cmd.Prepare();

                cmd.Parameters.AddWithValue("@nome", textBox1.Text);
                cmd.Parameters.AddWithValue("@email", textBox3.Text);
                cmd.Parameters.AddWithValue("@telefone", textBox2.Text);

                MessageBox.Show("contato adicionado com sucesso","Erro",MessageBoxButtons.OK, MessageBoxIcon.Information);


                //Ele executa o comando SQL no banco quando o comando NÃO retorna dados 
                cmd.ExecuteNonQuery();
            }catch (Exception ex)
            {
                MessageBox.Show(" ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
