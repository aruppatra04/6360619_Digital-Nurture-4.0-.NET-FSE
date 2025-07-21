using JwtAuthDemo2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JwtAuthDemo2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] UserModel user)
        {
            // Simple username/password check
            if (user.Username == "admin" && user.Password == "admin123")
            {
                var key = Encoding.UTF8.GetBytes("mysupersecurekey123456789012345678"); // min 32 chars
                var token = new JwtSecurityToken(
                    issuer: "https://localhost:7271",
                    audience: "https://localhost:7271",
                    expires: DateTime.UtcNow.AddMinutes(30),
                    claims: new[]
                    {
                        new Claim(ClaimTypes.Name, user.Username),
                        new Claim(ClaimTypes.Role, "Admin")
                    },
                    signingCredentials: new SigningCredentials(
                        new SymmetricSecurityKey(key),
                        SecurityAlgorithms.HmacSha256)
                );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }

            return Unauthorized("Invalid credentials");
        }
    }
}
