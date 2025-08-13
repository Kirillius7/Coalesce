using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFirstASP_Application.Models;
using MyFirstASP_Application.Services.ExpenseService;

namespace MyFirstASP_Application.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly IExpenseService _context;
        public ExpenseController(IExpenseService context)
        {
            _context = context;
        }
        public IActionResult Expenses()
        {
            //var allExpenses = _context.expenses.ToList();

            //var totalExpenses = _context.expenses.Sum(x => x.Value);
            //ViewBag.expenses = totalExpenses;
            var allExpenses = _context.Expenses();
            return View(allExpenses);
        }
        public IActionResult CreateEditExpense(int? id)
        {
            if (id is not null)
            {
                //var expense = _context.expenses.SingleOrDefault(x => x.id == id);
                _context.CreateEditExpense(id);
                return View();
            }

            return View();
        }
        public IActionResult DeleteExpense(int? id)
        {
            //var expense = _context.expenses.SingleOrDefault(x => x.id == id);
            //_context.expenses.Remove(expense);
            //_context.SaveChanges();
            _context.DeleteExpense(id);
            return RedirectToAction("Expenses");
        }
        public IActionResult CreateEditExpenseForm(Expense model)
        {
            //if (model.id == 0)
            //{
            //    _context.expenses.Add(model);
            //}
            //else
            //{
            //    _context.expenses.Update(model);
            //}
            //_context.SaveChanges();
            _context.CreateEditExpenseForm(model);
            return RedirectToAction("Expenses");
        }
    }
}
