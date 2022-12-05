using GSC_BackEnd_TP.Dto;
using GSC_BackEnd_TP.Handler;
using GSC_BackEnd_TP.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;

namespace GSC_BackEnd_TP.Controllers.WebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController: ControllerBase
    {
        private readonly IJwtHandler jwtHandler;
        private readonly ILoginService loginService;

        public LoginController(IJwtHandler jwtHandler, ILoginService loginService)
        {
            this.jwtHandler = jwtHandler;
            this.loginService = loginService;
        }
        [EnableCors("AngularPolicy")]
        [HttpPost]
        public IActionResult Login(UserDto user)
        {
            if (user.Email == null) {
                return BadRequest("No se envio el email");
            };
            if (user.Password == null)
            {
                return BadRequest("No se envio password");
            }
            user.Password=ComputeStringToSha256Hash(user.Password);

            User? u = loginService.getOneUser(user);
            if (u == null) return BadRequest("La contrasena o el email son incorrectos");
            
            var bearer = jwtHandler.GenerateToken(u);
            return Ok(new
            {
                token = bearer,

            });
            }

        static string ComputeStringToSha256Hash(string plainText)
        {
            // Create a SHA256 hash from string   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Computing Hash - returns here byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(plainText));

                // now convert byte array to a string   
                StringBuilder stringbuilder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    stringbuilder.Append(bytes[i].ToString("x2"));
                }
                return stringbuilder.ToString();
            }
        }

    }
}
