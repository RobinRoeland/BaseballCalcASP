using BaseballCalcASP.Areas.Identity.Pages.Account;
using BaseballCalcASP.Data;
using BaseballCalcASP.APIModels;
using BaseballCalcASP.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BaseballCalcASP.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly BaseballCalcASPContext _context;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(BaseballCalcASPContext context, SignInManager<AppUser> signInManager)
        {
            _context = context;
            _signInManager = signInManager;
        }

        [HttpPost]
        [Route("/API/Login")]
        public async Task<ActionResult<Boolean>> Login([FromBody]APIModels.LoginModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                return User.Identity.IsAuthenticated;
            }
            return false;
        }
    }
}
