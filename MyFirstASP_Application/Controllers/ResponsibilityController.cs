using Microsoft.AspNetCore.Mvc;
using MyFirstASP_Application.Models;
using MyFirstASP_Application.Services.ResponsibilityService;

namespace MyFirstASP_Application.Controllers
{
    public class ResponsibilityController : Controller
    {
        public IResponsibilityService _responsibilityService;
        public ResponsibilityController(IResponsibilityService responsibilityService)
        {
            _responsibilityService = responsibilityService;
        }
        public IActionResult Responsibilities()
        {
            var respons = _responsibilityService.GetAllResponsibilities();
            ViewBag.responsibilities = _responsibilityService.TotalResponsibilities();
            return View(respons);
        }
        public IActionResult MonthResponsibilities(int day, int month)
        {
            var dayRespons = _responsibilityService.MonthResponsibilities(day, month);
            ViewBag.tasksMonth = _responsibilityService.TotalMonthResponsibilities(day, month);
            return View(dayRespons);
        }

        public IActionResult CreateEditResponsibilityForm(Responsibility model)
        {
            _responsibilityService.CreateEditResponsibilityForm(model);
            return RedirectToAction("Responsibilities");
        }
        public IActionResult DeleteResponsibility(int id, int day, int month)
        {
            _responsibilityService.DeleteResponsibility(id);
            return RedirectToAction("MonthResponsibilities", new { day, month });
        }

        public IActionResult CreateEditResponsibility(int? id)
        {
            _responsibilityService.CreateEditResponsibility(id);

            return View();
        }

        public IActionResult DeleteDayResponsibilities(int day, int month)
        {
            _responsibilityService.DeleteDayResponsibilities(day, month);
            return RedirectToAction("Responsibilities");
        }
    }
}
