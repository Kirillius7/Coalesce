using MyFirstASP_Application.Models;

namespace MyFirstASP_Application.Services.ExpenseService
{
    public class ExpenseSrvc : IExpenseService
    {
        public ExpensesDbContext context;
        public ExpenseSrvc(ExpensesDbContext expensesDbContext)
        {
            context = expensesDbContext;
        }

        public IEnumerable<Expense> Expenses()
        {
            var collctn = context.expenses.ToList();
            return collctn;
        }
        public void CreateEditExpense(int? id)
        {
            if(id is not null)
            {
                var exp = context.expenses.SingleOrDefault(x => x.id == id);
            }
        }
        public void DeleteExpense(int? id)
        {
            if(id is not null)
            {
                var exp = context.expenses.SingleOrDefault(x => x.id == id);
                context.expenses.Remove(exp);
                context.SaveChanges();
            }
        }
        public void CreateEditExpenseForm(Expense expense)
        {
            if(expense.id == 0)
            {
                context.expenses.Add(expense);
                context.SaveChanges();
            }
            else
            {
                context.expenses.Update(expense);
                context.SaveChanges();
            }
        }
    }
}
