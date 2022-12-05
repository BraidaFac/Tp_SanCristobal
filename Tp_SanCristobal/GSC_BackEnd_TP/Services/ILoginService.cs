using GSC_BackEnd_TP.Dto;

namespace GSC_BackEnd_TP.Services
{
    public interface ILoginService
    {
        public User? getOneUser(UserDto userDto);
        public List<User>? getAll();
    }
}
