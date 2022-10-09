using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB.Areas.Admin.Controllers
{
    [Authorize(Roles="Admin")]
    [Area("Admin")]
    public class HomeController : Controller

    {

        public IActionResult Index()
        {
            TempData["Title"] = "Anasayfa";
            return View();
        }
    }
}
