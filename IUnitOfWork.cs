using DataPOC.Core;
using DataPOC.Repositories.Abstract;

namespace DataPOC
{
    public interface IUnitOfWork : IBaseUnitOfWork
    {
        public IUserRepository UserRepository { get; set; }
    }
}
