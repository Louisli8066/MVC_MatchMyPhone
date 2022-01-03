using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyWeb.Data;
using MyWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        private readonly PhonecompareContext _context;

        public HomeController(PhonecompareContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index(string mail)
        {
            ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
            mail = HttpContext.Session.GetString("LoginEmail");
            Member m = await _context.Members.SingleOrDefaultAsync(m=>m.Email==mail);
            if (m==null)
            {
                return View();
            }
            ViewBag.id = m.Id;
            ViewBag.email = m.Email;
            ViewBag.password = m.Password;
            ViewBag.name = m.UserName;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        



    }
}
