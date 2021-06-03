using System;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace AttendanceMgmtFYP.Data
{
    public interface IJWTAuth
    {
        public string GetToken(string Username,string Password);
    }
    
    public class JWTAuth : IJWTAuth
    {
        private string secretkey;
        public string SecretKey {
            get {
                return this.secretkey;
            }
        }
        public JWTAuth(string SecretKey){
            this.secretkey = SecretKey;
        }
        public string GetToken(string Username, string Password)
        {
          var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, Username,null),
                    new Claim("Password", Password,null),
                    new Claim("Time",DateTime.Now.ToString(),null)
                }),
                Expires = DateTime.UtcNow.AddDays(15),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SecretKey)),
                    SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
          }
    }
}