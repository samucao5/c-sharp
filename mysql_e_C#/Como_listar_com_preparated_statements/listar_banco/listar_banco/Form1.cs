using Microsoft.Win32.SafeHandles;
using MySql.Data.MySqlClient;
namespace listar_banco
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn;
        private System.String data_source = "datasource=localhost;username=root;password=;database=db_agenda";
        private MySqlCommand cmd = new MySqlCommand();

        public Form1()
        {
            InitializeComponent();
            
            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listView1.Columns.Add("NOME", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("E-MAIL", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("TELEFONE", 150, HorizontalAlignment.Left);

            carregar_contatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                conn = new MySqlConnection(data_source);
                cmd.Connection = conn;
                conn.Open();

                cmd.CommandText = "SELECT * FROM contato WHERE nome_contato LIKE @Buscar OR email LIKE @Buscar";

                //sempre utilizar cmd.Parameters.Clear() antes de colocar um cmd.parameters.AddWithValue, se não acumula paramentros deixando o programa mais pesado depedendo do tempo de uso
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Buscar", "%" + textBox1.Text + "%");

                MySqlDataReader reader = cmd.ExecuteReader();

                listView1.Items.Clear();

                while (reader.Read())
                {
                    System.String[] row =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };

                    listView1.Items.Add(new ListViewItem(row));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void carregar_contatos()
        {
            try
            {
                conn = new MySqlConnection(data_source);
                cmd.Connection = conn;
                conn.Open();

                cmd.CommandText = "SELECT * FROM contato ORDER BY id_contato ASC";


                MySqlDataReader reader = cmd.ExecuteReader();

                listView1.Items.Clear();

                while (reader.Read())
                {
                    System.String[] row =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };

                    listView1.Items.Add(new ListViewItem(row));
                }
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
