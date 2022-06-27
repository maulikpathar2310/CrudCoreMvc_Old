using EmpCrudCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EmpCrudCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
      

        public IActionResult Login()
        {
            return View();
        }

        /* 
        [HttpPost]
        public async Task<IActionResult> Login(Logins model)
        {
          if(ModelState.IsValid)
            {
                var res = await _db.Logins(model.Username, model.Password, false);
                if (res.Succeded)
                {
                    return RedirectToAction("List", "Emp");
                }
                ModelState.AddModelError(string.Empty, "Invalid Login ");
            }
          return View(model);

        }
         */

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
