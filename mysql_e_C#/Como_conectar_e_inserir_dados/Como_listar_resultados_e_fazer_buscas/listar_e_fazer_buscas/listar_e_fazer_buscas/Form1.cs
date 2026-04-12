using MySql.Data.MySqlClient;
namespace listar_e_fazer_buscas
{
   

    public partial class Form1 : Form
    {

        private MySqlConnection conn;
        private System.String data_source = "datasource=localhost;username=root;password=;database=db_agenda";
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {

                
                conn = new MySqlConnection(data_source);
                System.String sql = "SELECT * FROM contato WHERE nome_contato LIKE @Buscar OR email LIKE @Buscar";

                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Buscar", "%" + txtBuscar.Text + "%");

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

                    var linha_listview = new ListViewItem(row);

                    listView1.Items.Add(linha_listview);
                }
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
