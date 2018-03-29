using AutoMapper;
using Domain;

namespace Service
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
            var user = new User
            {
                Id = 1,
                Name = "bidianqing"
            };

            var model = new User
            {
                Id = 1,
                Name = "test"
            };
            user = _mapper.Map<User>(model);
        }
    }
}
