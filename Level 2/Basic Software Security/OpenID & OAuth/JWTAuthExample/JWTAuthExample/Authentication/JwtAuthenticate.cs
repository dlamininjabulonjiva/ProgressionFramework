using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace JWTAuthExample.Authentication
{
    public class JwtAuthenticate: IJwtAuthenticate
    {
        private const string Username = "njabulo";
        private const string Password = "dlamini";
        private readonly string _key;

        public JwtAuthenticate(string key)
        {
            _key = key;
        }

        public JwtAuthenticateResponse? Authentication(JwtAuthenticateRequest request)
        {
            if (!(Username.Equals(request.Username) || Password.Equals(request.Password)))
            {
                return null;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(_key);

            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(
                    new[]
                    {
                        new Claim(ClaimTypes.Name, request.Username)
                    }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };

            var createdToken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(createdToken);

            return new JwtAuthenticateResponse(request.Username, token);
        }
    }
}
