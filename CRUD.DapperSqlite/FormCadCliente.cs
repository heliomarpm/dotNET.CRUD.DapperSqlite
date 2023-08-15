using CRUD.DapperSqlite.DAO;
using CRUD.DapperSqlite.Models;
using System.Data;

namespace CRUD.DapperSqlite
{
    public partial class FormCadCliente : Form
    {
        readonly IDbConnection _dbConnection;
        ClienteDAO _dao;
        Cliente _cliente;

        public FormCadCliente(IDbConnection dbConnection)
        {
            InitializeComponent();

            _dbConnection = dbConnection;
            _dao = new ClienteDAO(_dbConnection);

            this.Text = "Inclusão de Novo Cliente";
            txtId.Text = "{Automático}";
            txtId.ReadOnly = true;
            txtNome.Focus();
        }

        public FormCadCliente(IDbConnection dbConnection, int idCliente)
            : this(dbConnection)
        {
            this.Text = "Alteração de Cliente existente";
            var cliente = new ClienteDAO(dbConnection).GetById(idCliente);
            if (cliente != null)
            {
                txtId.Text = cliente.Id.ToString();
                txtNome.Text = cliente.Nome;
                txtTelefone.Text = cliente.Telefone;
                txtCidade.Text = cliente.Cidade;
                txtUF.Text = cliente.UF;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                _ = int.TryParse(txtId.Text, out int id);

                var cliente = new Cliente()
                {
                    Nome = txtNome.Text.Trim(),
                    Telefone = txtTelefone.Text.Trim(),
                    Cidade = txtCidade.Text.Trim(),
                    UF = txtUF.Text.Trim()
                };

                if (id == 0)
                {
                    var resultado = new ClienteDAO(_dbConnection).Insert(cliente);
                    if (resultado == 0)
                        throw new Exception("Erro desconhecido ao tentar INCLUIR o Cliente");
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    cliente.Id = id;

                    var resultado = new ClienteDAO(_dbConnection).Update(cliente);
                    if (resultado == 0)
                        throw new Exception("Erro desconhecido ao tentar ALTERAR os dados do Cliente");
                    else
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ShowErro("Erro ao tentar SALVAR os dados!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
