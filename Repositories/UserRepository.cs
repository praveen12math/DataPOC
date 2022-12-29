using DataPOC.Core;
using DataPOC.Entity;
using DataPOC.Repositories.Abstract;

namespace DataPOC.Repositories
{
    internal class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
