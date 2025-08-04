using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WidgetForm.Models;

namespace WidgetForm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly WidgetContext _context;

        public HomeController(ILogger<HomeController> logger, WidgetContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index() {
            var widgets = _context.Widgets.ToList();
            return View(widgets);
        }

        public IActionResult Add() {
            return View();  // empty Widget submission form
        }

        [HttpPost]
        public IActionResult Add(Widget newWidget) {
            _context.Widgets.Add(newWidget);
            _context.SaveChanges();

            TempData["Name"] = newWidget.Name;
            TempData["Type"] = newWidget.Type.ToString();
            TempData["Subtype"] = newWidget.Subtype.ToString();
            if (newWidget.Date != null) {
                DateTime dateTimeObj = DateTime.Parse(newWidget.Date);
                TempData["Date"] = dateTimeObj.ToShortDateString();
            }
            TempData["Time"] = newWidget.Time;

            return RedirectToAction("Confirm");
        }

        public IActionResult Confirm(Widget widget) {
            if (TempData["Name"] == null || TempData["Type"] == null || TempData["Subtype"] == null || TempData["Date"] == null || TempData["Time"] == null) {
                return RedirectToAction("Index");
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}