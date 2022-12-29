using DataPOC.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DataPOC
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;
        public IUserRepository UserRepository { get; set; }

        public UnitOfWork(DataContext dataContext, IUserRepository userRepository)
        {
            _dataContext = dataContext;
            UserRepository = userRepository;
        }

        public int SaveChanges()
        {
            return _dataContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _dataContext.SaveChangesAsync();
        }

        public IQueryable<TEntity> FromSql<TEntity>(string sql, params object[] parameters) where TEntity : class
        {
            return _dataContext.Set<TEntity>().FromSqlRaw(sql, parameters);
        }

        public int ExecuteSqlCommand(string sql, params object[] parameters)
        {
            return _dataContext.Database.ExecuteSqlRaw(sql, parameters);
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}
