using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ParksApi.Models;
using ParksApi.DtoModels;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authorization;

namespace ParksApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountsController : ControllerBase
{
  private readonly UserManager<ApplicationUser> _userManager;
  private readonly SignInManager<ApplicationUser> _signInManager;
  private readonly IConfiguration _configuration;

  public AccountsController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
  {
    _userManager = userManager;
    _signInManager = signInManager;
    _configuration = configuration;
  }

  [HttpPost("SignIn")]
  public async Task<IActionResult> SignIn(SignInDto userInfo)
  {
    ApplicationUser user = await _userManager.FindByEmailAsync(userInfo.Email);
    if (user != null)
    {
      Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager.PasswordSignInAsync(user, userInfo.Password, isPersistent: false, lockoutOnFailure: false);
      if (signInResult.Succeeded)
      {
        List<Claim> authClaims = new List<Claim>
        {
          new Claim("UserId", user.Id)
        };

        string newToken = CreateToken(authClaims);

        return Ok(new { status = "success", message = $"{userInfo.Email} signed in", token = newToken});
      }
    }
    return BadRequest(new { status = "error", message = "Unable to sign in"});
  }

  private string CreateToken(List<Claim> authClaims)
  {
    var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

    var token = new JwtSecurityToken(
      issuer: _configuration["JWT:ValidIssuer"],
      audience: _configuration["JWT:ValidAudience"],
      expires: DateTime.Now.AddHours(3),
      claims: authClaims,
      signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
      );

    return new JwtSecurityTokenHandler().WriteToken(token);
  }
}