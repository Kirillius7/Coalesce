using Microsoft.AspNetCore.Mvc;
using MyFirstASP_Application.Models;
using MyFirstASP_Application.Services.DateService;

namespace MyFirstASP_Application.Controllers
{
    public class DateController : Controller
    {
        private readonly IDateService _dateService;

        public DateController(IDateService dateService)
        {
            _dateService = dateService;
        }

        public IActionResult CreateEditDate(int id)
        {
            _dateService.CreateEditDate(id);
            return View();
        }

        public IActionResult DeleteDate(int id)
        {
            _dateService.DeleteDate(id);
            return RedirectToAction("Dates");
        }

        public IActionResult Dates()
        {
            var data = _dateService.GetAllDates();
            return View(data);
        }
        public IActionResult CreateEditDateForm(Date model)
        {
            _dateService.CreateEditDateForm(model);
            return RedirectToAction("Dates");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
