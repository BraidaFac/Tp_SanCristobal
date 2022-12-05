using GSC_BackEnd_TP.Configuration;
using GSC_BackEnd_TP.Dto;
using GSC_BackEnd_TP.Services;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace GSC_BackEnd_TP.Handler
{
    public class JwtHandler : IJwtHandler
    {
        private readonly JwtOptions _jwtOptions;


        public JwtHandler(IOptions<JwtOptions> jwtOptions)
        {
            _jwtOptions= jwtOptions?.Value ?? throw new ArgumentNullException(nameof(jwtOptions));
        }

        public string GenerateToken(User user)
        {
            var signingCredetials = GetSigningCredentials();
            var claims = GetClaims(user);
            var tokenOptions = GenerateTokenOptions(signingCredetials, claims);
            var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
            return token;
        }

        public JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var tokenOptions = new JwtSecurityToken(
               claims: claims,
               issuer: _jwtOptions.Issuer,
               audience: _jwtOptions.Audience,
               signingCredentials: signingCredentials);

            return tokenOptions;
        }
        private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(_jwtOptions.Key);
            var secret = new SymmetricSecurityKey(key);

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        public List<Claim> GetClaims(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, user.Email)
            };

 
                claims.Add(new Claim(ClaimTypes.Role, user.Rol));
          
            return claims;
        }
    }

        
}

