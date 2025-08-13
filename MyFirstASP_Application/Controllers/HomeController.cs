using Microsoft.AspNetCore.Mvc;
using MyFirstASP_Application.Models;
using System.Diagnostics;

namespace MyFirstASP_Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ExpensesDbContext _context;

        private readonly ResponsibilitiesDbContext _rspcontext;


        public HomeController(ILogger<HomeController> logger, ExpensesDbContext context, ResponsibilitiesDbContext rspcontext) 
        {
            _logger = logger;
            _context = context;
            _rspcontext = rspcontext;
        }
        [HttpGet]
        public IActionResult Test(int firstNumber, int secondNumber)
        {
            return View(firstNumber + secondNumber);
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Expenses()
        {
            var allExpenses = _context.expenses.ToList();

            var totalExpenses = _context.expenses.Sum(x => x.Value);
            ViewBag.expenses = totalExpenses;
            return View(allExpenses);
        }
        public IActionResult CreateEditExpense(int? id)
        {
            if(id is not null)
            {
                var expense = _context.expenses.SingleOrDefault(x => x.id == id);
                return View();
            }

            return View();
        }
        public IActionResult DeleteExpense(int? id)
        {
            var expense = _context.expenses.SingleOrDefault(x => x.id == id);
            _context.expenses.Remove(expense);
            _context.SaveChanges();
            return RedirectToAction("Expenses");
        }
        public IActionResult CreateEditExpenseForm(Expense model)
        {
            if (model.id == 0)
            {
                _context.expenses.Add(model);
            }
            else
            {
                _context.expenses.Update(model);
            }
            _context.SaveChanges();
            return RedirectToAction("Expenses");
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

        public IActionResult PeopleFill()
        {
            return View();
        }

        public IActionResult PeopleForm(Person pn)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Responsibilities()
        {
            var respons = _rspcontext.responsibilities.ToList();
            var totalResponsibilities = _rspcontext.responsibilities.Count();
            ViewBag.responsibilities = totalResponsibilities;
            return View(respons);
        }
        public IActionResult MonthResponsibilities(int day, int month)
        {
            var dayRespons = _rspcontext.responsibilities.Where(x => x.date.Day == day && x.date.Month == month).ToList();
            var unfinished = _rspcontext.responsibilities.Where(x => x.accoplishment == false).Count();
            ViewBag.responsibilities = unfinished;
            return View(dayRespons);
        }

        public IActionResult CreateEditResponsibilityForm(Responsibility model)
        {
            if (model.id == 0)
            {
                _rspcontext.responsibilities.Add(model);
            }
            else
            {
                _rspcontext.responsibilities.Update(model);
            }
            _rspcontext.SaveChanges();
            return RedirectToAction("Responsibilities");
        }
        public IActionResult DeleteResponsibility(int id, int day, int month)
        {
            var responsibility = _rspcontext.responsibilities.SingleOrDefault(x => x.id == id);
            _rspcontext.responsibilities.Remove(responsibility);
            _rspcontext.SaveChanges();
            //var nw = _rspcontext.responsibilities.Where(x => x.date.Day == model.date.Day && x.date.Year == model.date.Year);
            return RedirectToAction("MonthResponsibilities", new { day, month}); ////////////////////////////////////
        }

        public IActionResult CreateEditResponsibility(int? id)
        {
            if (id is not null)
            {
                var responsibility = _rspcontext.responsibilities.SingleOrDefault(x => x.id == id);
                return View();
            }

            return View();
        }

        public IActionResult DeleteMonthResponsibilities(int? month)
        {
            var resps = _rspcontext.responsibilities.Where(x => x.date.Month == month).ToList();
            _rspcontext.responsibilities.RemoveRange(resps);
            _rspcontext.SaveChanges();
            return RedirectToAction("Responsibilities");
        }
    }
}
