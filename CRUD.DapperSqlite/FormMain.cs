using CRUD.DapperSqlite.DAO;
using System.Data;

namespace CRUD.DapperSqlite
{
    public partial class FormMain : Form
    {
        private readonly IDbConnection _connection;

        public FormMain()
        {
            InitializeComponent();

            _connection = new Conexao().ConnectionData;
            _connection.Open();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {

            var clientes = new ClienteDAO(_connection).GetAll();
            var rcount = clientes.Count;

            btnAlterar.Enabled = rcount > 0;
            btnExcluir.Enabled = rcount > 0;

            lblRCount.Text = $"Qtd. registros: {rcount}";

            dtgDados.DataSource = clientes;
            dtgDados.Focus();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            new FormCadCliente(_connection).ShowDialog();
            //btnCarregar.PerformClick();
            CarregarDados();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(dtgDados.SelectedRows[0].Cells[0].Value);
                new FormCadCliente(_connection, id).ShowDialog();

                CarregarDados();
            }
            catch
            {
                MessageBox.Show("Erro ao selecionar o registro");
                return;
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(dtgDados.SelectedRows[0].Cells[0].Value);

                if (id > 0 && MessageBox.Show(ProductName, "Confirma Exclusão?",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    new ClienteDAO(_connection).Delete(id);
                    CarregarDados();
                }
            }
            catch
            {
                MessageBox.Show("Erro ao selecionar o registro");
                return;
            }

        }

        private void dtgDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}