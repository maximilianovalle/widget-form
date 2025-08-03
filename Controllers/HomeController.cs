using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WidgetForm.Models;

namespace WidgetForm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() {
            // DELETE ME: temporary list of Widgets for development purposes
            List<Widget> widgets = new List<Widget> {
                new Widget { ID = 0, Name = "Widget 0", Date = "2004-04-05", Time = "12:04", Type = WidgetType.A, Subtype = WidgetSubtype.Apple },
                new Widget { ID = 1, Name = "Widget 1", Date = "2012-11-11", Time = "02:22", Type = WidgetType.One, Subtype = WidgetSubtype.Uno },
                new Widget { ID = 2, Name = "Widget 2", Date = "2021-01-28", Time = "7:12", Type = WidgetType.Two, Subtype = WidgetSubtype.Secondary },
                new Widget { ID = 3, Name = "Widget 3", Date = "2004-04-05", Time = "12:04", Type = WidgetType.A, Subtype = WidgetSubtype.Apple },
                new Widget { ID = 4, Name = "Widget 4", Date = "2012-11-11", Time = "02:22", Type = WidgetType.One, Subtype = WidgetSubtype.Uno },
                new Widget { ID = 5, Name = "Widget 5", Date = "2021-01-28", Time = "7:12", Type = WidgetType.Two, Subtype = WidgetSubtype.Secondary },
            };

            return View(widgets);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
