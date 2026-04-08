namespace projeto_ferramentaria
{

    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(Form form)
        {
            form.Owner = this;
            form.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        //cadastrar

        //funcionarios

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Cargos());
        }

        private void funcionarioferramentariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new funcionarioF());
        }

        private void funcionarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new cadastroFuncionarios());
        }
        //csn

        private void localferramentariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new localferramentaria());
        }

        private void areasCsnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new areasCsn());
        }

        //ferramentas

        private void cadastrarFerramentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ferramentas());
        }

        private void categoriaFerramentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new categoriaFerramenta());
        }

        //Emprestimo

        //realizar emprestimo
        private void realizarEmprestimoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new realizarEmprestimo());
        }


        //consultar emprestimo


        private void consultarEmprestimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new consultarEmprestimos());
        }

        //Consultar 

        //consultar funcionarios

        private void funcionariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new consultarFuncionarios());
        }

        // consultar funcionarios ferramentaria

        private void funcionariosFerramentariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new consultarFuncionariosFerramentaria());
        }

        // consultar ferramentas

        private void ferramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new consultarFerramentas());
        }

        //consultar categorias ferramentas

        private void categoriaFerramentaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new consultarCategoriaFerramenta());
        }
    }
}
