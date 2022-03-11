using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CMP_1005_Security_App.Controllers
{
    [Authorize]
    public class SecretController : Controller
    {
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;

        public SecretController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        private async Task<IdentityUser> GetUser(ClaimsPrincipal user)
        {
            return await _userManager.GetUserAsync(User);
        }

        public async Task<IActionResult> Index2()
        {
            //var user = await _userManager.GetUserAsync(User);
            //var isSignedIn = _signInManager.IsSignedIn(User);

            await GetUser(User);

            return View();
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            var isSignedIn = _signInManager.IsSignedIn(User);

            return View();
        }
    }
}
