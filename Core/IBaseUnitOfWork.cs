namespace DataPOC.Core
{
    public interface IBaseUnitOfWork : IDisposable
    {
        int SaveChanges();
        Task<int> SaveChangesAsync();
        IQueryable<TEntity> FromSql<TEntity>(string sql, params object[] parameters) where TEntity : class;
        int ExecuteSqlCommand(string sql, params object[] parameters);
    }
}
