using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFirstASP_Application.Models;
using MyFirstASP_Application.Services.ExpenseService;

namespace MyFirstASP_Application.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly IExpenseService _expenseService;
        public ExpenseController(IExpenseService expenseService)
        {
            _expenseService = expenseService;
        }
        public IActionResult Expenses()
        {
            var allExpenses = _expenseService.Expenses();
            ViewBag.expenses = _expenseService.TotalExpenses();
            return View(allExpenses);
        }
        public IActionResult CreateEditExpense(int? id)
        {
            if (id is not null)
            {
                _expenseService.CreateEditExpense(id);
                return View();
            }

            return View();
        }
        public IActionResult DeleteExpense(int? id)
        {
            _expenseService.DeleteExpense(id);
            return RedirectToAction("Expenses");
        }
        public IActionResult CreateEditExpenseForm(Expense model)
        {
            _expenseService.CreateEditExpenseForm(model);
            return RedirectToAction("Expenses");
        }
    }
}
