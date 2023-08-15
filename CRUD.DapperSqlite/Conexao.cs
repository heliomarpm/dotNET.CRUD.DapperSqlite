using System.Data.SQLite;

namespace CRUD.DapperSqlite
{
    internal class Conexao
    {
        private readonly string _databaseFile = Environment.CurrentDirectory + "\\database.db";

        public SQLiteConnection ConnectionData => new($"Data Source={_databaseFile};Cache=Shared");
    }
}