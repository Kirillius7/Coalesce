using Microsoft.AspNetCore.Mvc;
using MyFirstASP_Application.Models;

namespace MyFirstASP_Application.Services.DateService
{
    public class DateSrvc : IDateService
    {
        private readonly DatesDbContext _context;
        public DateSrvc(DatesDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Date> GetAllDates()
        {
            return _context.dates.ToList();
        }

        public int GetTotalDates()
        {
            return _context.dates.Count();
        }

        public void DeleteDate(int? id)
        {
            var date = _context.dates.SingleOrDefault(x => x.id == id);
            if (date is not null)
            {
                _context.dates.Remove(date);
                _context.SaveChanges();
            }
        }
        public void CreateEditDate(int? id)
        {
            if (id is not null)
            {
                var date = _context.dates.SingleOrDefault(x => x.id == id);
            }
        }
        public void CreateEditDateForm(Date model)
        {
            if (model.id == 0)
            {
                _context.dates.Add(model);
            }
            else
            {
                _context.dates.Update(model);
            }
            _context.SaveChanges();
        }

    }
}
