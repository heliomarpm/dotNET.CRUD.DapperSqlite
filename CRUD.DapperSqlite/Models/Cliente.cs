namespace CRUD.DapperSqlite.Models
{
    internal class Cliente
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public string Telefone { get; set; } = "";
        public string Cidade { get; set; } = "";
        public string UF { get; set; } = "";
    }
}
