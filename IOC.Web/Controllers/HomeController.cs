using IOC.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IOC.Web.Controllers
{
    public class HomeController : Controller
    {
        //homecontrollerın ındex metotuna bır req yapıldıgında ctor calısır ve enjekte eder
        private readonly ISingletonDateService _singletonDateService;
        public HomeController(ISingletonDateService singletonDateService)
        {
            _singletonDateService=singletonDateService;
        }
        
        public IActionResult Index()
        {
            ViewBag.time1 = _singletonDateService.GetDayTime.TimeOfDay.ToString();
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
