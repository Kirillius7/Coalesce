using MyFirstASP_Application.Models;

namespace MyFirstASP_Application.Services.ResponsibilityService
{
    public interface IResponsibilityService
    {
        IEnumerable<Responsibility> GetAllResponsibilities();
        void CreateEditResponsibility(int? id);
        void DeleteResponsibility(int? id);
        void DeleteDayResponsibilities(int id, int month);
        void CreateEditResponsibilityForm(Responsibility model);
        IEnumerable<Responsibility> MonthResponsibilities(int day, int month);

        int TotalMonthResponsibilities(int day, int month);
        int TotalResponsibilities();
    }
}
