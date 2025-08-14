using MyFirstASP_Application.Models;

namespace MyFirstASP_Application.Services.ExpenseService
{
    public class ExpenseSrvc : IExpenseService
    {
        public ExpensesDbContext _context;
        public ExpenseSrvc(ExpensesDbContext expensesDbContext)
        {
            _context = expensesDbContext;
        }

        public IEnumerable<Expense> Expenses()
        {
            var collctn = _context.expenses.ToList();
            return collctn;
        }
        public void CreateEditExpense(int? id)
        {
            if(id is not null)
            {
                var exp = _context.expenses.SingleOrDefault(x => x.id == id);
            }
        }
        public void DeleteExpense(int? id)
        {
            if(id is not null)
            {
                var exp = _context.expenses.SingleOrDefault(x => x.id == id);
                _context.expenses.Remove(exp);
                _context.SaveChanges();
            }
        }
        public void CreateEditExpenseForm(Expense expense)
        {
            if(expense.id == 0)
            {
                _context.expenses.Add(expense);
            }
            else
            {
                _context.expenses.Update(expense);
            }
            _context.SaveChanges();
        }

        public double TotalExpenses()
        {
            return _context.expenses.Sum(x => x.Value);
        }
    }
}
