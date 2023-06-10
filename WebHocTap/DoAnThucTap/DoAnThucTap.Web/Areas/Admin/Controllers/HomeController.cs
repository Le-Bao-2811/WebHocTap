using DoAnThucTap.Data.Reponsitory;
using Microsoft.AspNetCore.Mvc;

namespace DoAnThucTap.Web.Areas.Admin.Controllers
{
    public class HomeController : BaseAdminController
    {
        public HomeController(BaseReponsitory repo):base(repo) 
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
