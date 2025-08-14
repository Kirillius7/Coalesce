using MyFirstASP_Application.Models;

namespace MyFirstASP_Application.Services.ExpenseService
{
    public interface IExpenseService
    {
        IEnumerable<Expense> Expenses();

        void CreateEditExpense(int? id);

        void DeleteExpense(int? id);

        void CreateEditExpenseForm(Expense expense);

        double TotalExpenses();
    }
}
