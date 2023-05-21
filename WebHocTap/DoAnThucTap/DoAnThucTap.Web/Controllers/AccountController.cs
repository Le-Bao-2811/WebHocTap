using DoAnThucTap.Data.Entites;
using DoAnThucTap.Data.Reponsitory;
using DoAnThucTap.Share.Const;
using DoAnThucTap.Web.ViewModels;
using DoAnThucTap.Web.WebConfig;
using DoAnThucTap.Web.WebConfig.Const;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Security.Claims;

namespace DoAnThucTap.Web.Controllers
{
    public class AccountController : BaseClientController
    {
        public AccountController(BaseReponsitory _repo):base(_repo)
        {
        }

        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult>Login(LoginClientVM model)
        {
            var user = await _repo.GetOneAsync<User, UserDataForApp>
                           (
                               where: x => x.UserName == model.UserName.ToLower(),
                               MapperConfig.LoginConf
                           );
            if (user == null)
            {
                TempData["Mesg"] = "Tài khoản không tồn tại";
                return View();
            }
            var pwdHash = this.HashHMACSHA512WithKey(model.Password, user.PasswordSalt);
            if (!pwdHash.SequenceEqual(user.PasswordHash))
            {
                TempData["Mesg"] = "Tên đăng nhập hoặc mật khẩu không chính xác";
                return View();
            }

            var claims = new List<Claim> {
                           new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                           new Claim(ClaimTypes.Name, user.UserName),
                           new Claim(ClaimTypes.Email, user.Gmail),
                           new Claim(AppClaimType.PhoneNumber, user.PhoneNumber),
                           new Claim(AppClaimType.RoleName, user.RoleName),
                           new Claim(AppClaimType.RoleId, user.RoleId.ToString()),
                           new Claim(AppClaimType.Permissions, user.Permission),
                        };
            var claimsIdentity = new ClaimsIdentity(claims, AppConst.COOKIES_AUTH);
            var principal = new ClaimsPrincipal(claimsIdentity);
            var authenPropeties = new AuthenticationProperties()
            {
                ExpiresUtc = DateTime.UtcNow.AddHours(AppConst.LOGIN_TIMEOUT),
                IsPersistent = model.RemeberMe
            };
            await HttpContext.SignInAsync(AppConst.COOKIES_AUTH, principal, authenPropeties);

            //CreateDirIfNotExist(model.Username);
            //var returnUrl = Request.Query["ReturnUrl"].ToString();
            //if (returnUrl.IsNullOrEmpty())
            //{
            //    return HomePage();
            //}
            return RedirectToAction(nameof(Index), "Home");
        }
    }
}
