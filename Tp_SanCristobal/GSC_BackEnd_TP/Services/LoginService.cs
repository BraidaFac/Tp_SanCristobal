using GSC_BackEnd_TP.Dto;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace GSC_BackEnd_TP.Services
{
    public class User
    {
        [Required]
        public string? Email { get; set; }
        [Required] 
        public string? Password { get; set; }
        [Required]
        public string? Rol { get; set; }
    }

    public class LoginService:ILoginService
    {
        #region Datos de Prueba
        private List<User> users = new List<User> {
            new User{
                Email = "admin@gmail.com",
                Password = "5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5",
                Rol = "Admin",
            
            },
            new User{
               Email = "facundo@gmail.com",
                Password = "5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5",
                Rol = "User",
            },
            new User{
                Email = "pepe@gmail.com",
                Password = "5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5",
                Rol = "User",
            },
        };
        #endregion

        public List<User> getAll()
        {
            return users;
        }

        public User? getOneUser(UserDto userDto)
        {
           var u= users.SingleOrDefault(u => u.Email == userDto.Email);
           if(u==null) return null;
           if (u.Password != userDto.Password) return null;
           return u;
        }
    }
}
