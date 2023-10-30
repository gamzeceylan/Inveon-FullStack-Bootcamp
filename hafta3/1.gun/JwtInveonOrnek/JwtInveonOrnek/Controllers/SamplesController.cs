using JwtInveonOrnek.Models;
using JwtInveonOrnek.Services.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtInveonOrnek.Controllers
{
    //Authorize attribute ile bu sınıfı sadece yetkisi yani tokenı olan kişilerin girmesini söylüyoruz.
    [Authorize]
    [ApiController]
    //Routing için mesela /Sample/GetSummaries olarak ayarlıyoruz.
    [Route("[controller]/[action]")]
    public class SamplesController : ControllerBase
    {

        private static readonly string[] Summaries = { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
        private readonly IUserService _userService;
        public SamplesController(IUserService userService) => _userService = userService;



        //Burada da AllowAnonymous attribute nü kullanarak bu seferde bu metoda herkesin erişebileceğini söylüyoruz.
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Authenticate([FromBody] AuthenticationModel authenticateModel)
        {
            var user = _userService.Authenticate(authenticateModel.Username, authenticateModel.Password);

            if (user == null)
                return BadRequest("Username ve şifre hatalı!");

            return Ok(new { Username = user.Value.username, Token = user.Value.token });
        }

        //Token a sahip olanlar bu metodu çağırabilecekler
        [HttpGet]
        public IActionResult GetSummaries() => Ok(Summaries);
    }
}
