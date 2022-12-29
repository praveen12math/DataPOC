using BusinessManagerPOC.Models;

namespace BusinessManagerPOC.BusinessManager
{
    public interface IUserManager
    {
        Task<RequestUser> CreateUserAsync(RequestUser user);
        Task<IList<ResponseUser>> GetAllUsersAsync();
    }
}
