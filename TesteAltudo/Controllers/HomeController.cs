using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TesteAltudo.Models;
using TesteAltudo.Rules;

namespace TesteAltudo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetURL(string url)
        {
            BOPageContents bopc = new BOPageContents();

            try
            {
                var vm = bopc.GetURLContents(url);

                return PartialView(vm);
            }
            catch (Exception ex)
            {
                return PartialView("ErrorPartial", new PageContentsViewModel { ErrorMsg = ex.Message });
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
