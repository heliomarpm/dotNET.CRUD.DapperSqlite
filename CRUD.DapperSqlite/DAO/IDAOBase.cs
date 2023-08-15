namespace CRUD.DapperSqlite.DAO
{
    internal interface IDAOBase<T>
    {
        List<T> GetAll();
        T GetById(int id);
        int Insert(T dto);
        int Update(T dto);
        int Delete(int id);
    }
}
