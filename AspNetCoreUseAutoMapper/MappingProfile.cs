using AspNetCoreUseAutoMapper.Domain;
using AspNetCoreUseAutoMapper.Models;
using AutoMapper;

namespace AspNetCoreUseAutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDTO>();
        }
    }
}
