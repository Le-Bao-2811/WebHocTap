﻿using Microsoft.AspNetCore.Mvc;

namespace DoAnThucTap.Web.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}