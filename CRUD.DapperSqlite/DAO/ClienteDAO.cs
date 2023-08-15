using CRUD.DapperSqlite.Models;
using Dapper;
using System.Data;

namespace CRUD.DapperSqlite.DAO
{
    internal class ClienteDAO : IDAOBase<Cliente>
    {
        private readonly IDbConnection _connection;

        public ClienteDAO(IDbConnection connection)
        {
            _connection = connection;
            CreateTable();
        }

        private void CreateTable()
        {
            //using var conn = ConnectionData;
            //conn.Open();
            //conn.Execute(Properties.Resources.create_table_cliente);
            try
            {
                _connection.Execute(Properties.Resources.create_table_cliente);
            }
            catch (Exception) { throw; }
        }

        public List<Cliente> GetAll()
        {
            try
            {
                return _connection.Query<Cliente>(@"SELECT * FROM CLIENTE ORDER BY Nome").ToList();
            }
            catch (Exception) { throw; }
        }

        public Cliente GetById(int id)
        {
            try
            {
                return _connection.QuerySingleOrDefault<Cliente>(@"SELECT * FROM CLIENTE WHERE ID = @id", new { id });
            }
            catch (Exception) { throw; }
        }

        public int Insert(Cliente dto)
        {
            try
            {
                return _connection.ExecuteScalar<int>(
                    @"INSERT INTO CLIENTE (NOME, TELEFONE, CIDADE, UF) VALUES (@Nome, @Telefone, @Cidade, @UF); SELECT last_insert_rowid()",
                    dto);
            }
            catch (Exception) { throw; }
        }

        public int Update(Cliente dto)
        {
            try
            {
                return _connection.Execute(@"UPDATE CLIENTE SET Nome = @Nome, Telefone = @Telefone, Cidade = @Cidade, UF = @UF WHERE ID = @Id", dto);
            }
            catch (Exception) { throw; }
        }

        public int Delete(int id)
        {
            try
            {
                return _connection.Execute(@"DELETE FROM CLIENTE WHERE ID = @Id", new { Id = id });
            }
            catch (Exception) { throw; }
        }
    }
}
