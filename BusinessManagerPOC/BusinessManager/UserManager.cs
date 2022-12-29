using AutoMapper;
using BusinessManagerPOC.Models;
using DataPOC;

namespace BusinessManagerPOC.BusinessManager
{
    public class UserManager : IUserManager
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserManager(IUnitOfWork unitOfWork,
                           IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<RequestUser> CreateUserAsync(RequestUser user)
        {
            
             await _unitOfWork.UserRepository.InsertAsync(_mapper.Map<DataPOC.Entity.User>(user));
            await _unitOfWork.SaveChangesAsync();
            return user;
        }

        public async Task<IList<ResponseUser>> GetAllUsersAsync()
        {
            var user = await _unitOfWork.UserRepository.GetAllAsync();

            return _mapper.Map<IList<ResponseUser>>(user);
        }
    }

































}
