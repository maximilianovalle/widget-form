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

        // DELETE ME: temporary list of Widgets for development purposes
        static private List<Widget> widgets = new List<Widget> { };

        public IActionResult Index() {
            return View(widgets);
        }

        public IActionResult Add() {
            return View();  // empty Widget submission form
        }

        //[HttpPost]
        //public IActionResult Add(Widget newWidget) {
        //    newWidget.ID = widgets.Count;   // TODO: remove when DB is created
        //    widgets.Add(newWidget);
        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public IActionResult Confirm(Widget widget) {
            widget.ID = widgets.Count;   // TODO: remove when DB is created
            widgets.Add(widget);
            return View(widget);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}