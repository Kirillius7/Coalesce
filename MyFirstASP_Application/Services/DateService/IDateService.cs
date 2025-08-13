using Microsoft.AspNetCore.Mvc;
using MyFirstASP_Application.Models;

namespace MyFirstASP_Application.Services.DateService
{
    public interface IDateService
    {
        IEnumerable<Date> GetAllDates();
        int GetTotalDates();
        Date GetDateById(int id);
        void DeleteDate(int id);
        void CreateEditDate(int? id);
        public void CreateEditDateForm(Date model);
    }
}
