using AutoMapper;

namespace BusinessManagerPOC.Mapper
{
    public class DataAutoMapper : Profile
    {
        public DataAutoMapper()
        {
            CreateMap<Models.RequestUser, DataPOC.Entity.User>().ReverseMap();
            CreateMap<Models.ResponseUser, DataPOC.Entity.User>().ReverseMap();
        }
    }
}
