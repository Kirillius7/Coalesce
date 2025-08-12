using Microsoft.AspNetCore.Mvc;
using MyFirstASP_Application.Models;
using System.Diagnostics;

namespace MyFirstASP_Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ExpensesDbContext _context;

        public HomeController(ILogger<HomeController> logger, ExpensesDbContext context)
        {
            _logger = logger;
            _context = context;
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
            return RedirectToAction("Index");
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
    }
}
