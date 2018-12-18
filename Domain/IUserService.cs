using AutoMapper;

namespace Domain
{
    public interface IUserService
    {
        void Test();
    }

    public class UserService : IUserService
    {
        private readonly IMapper _mapper;

        public UserService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public void Test()
        {
            var userDTO = new UserDTO
            {
                Id = 1,
                Name = "bidianqing"
            };

            User user = _mapper.Map<User>(userDTO);
        }
    }
}
