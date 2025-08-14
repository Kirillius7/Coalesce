using MyFirstASP_Application.Models;
using System.ComponentModel;

namespace MyFirstASP_Application.Services.ResponsibilityService
{
    public class ResponsibilitySrvc : IResponsibilityService
    {
        public ResponsibilitiesDbContext _context;
        public ResponsibilitySrvc(ResponsibilitiesDbContext responsibilitiesDbContext) 
        {
            _context = responsibilitiesDbContext;
        }
        public IEnumerable<Responsibility> GetAllResponsibilities()
        {
            var collection = _context.responsibilities.ToList();
            return collection;
        }

        public void DeleteResponsibility(int? id)
        {
            if(id is not null)
            {
                var smpl = _context.responsibilities.FirstOrDefault(x => x.id == id);
                _context.responsibilities.Remove(smpl);
                _context.SaveChanges();
            }
        }

        public void DeleteDayResponsibilities(int day, int month)
        {
            var coll = _context.responsibilities
                .Where(x => x.date.Day == day && x.date.Month == month).ToList();

            _context.responsibilities.RemoveRange(coll);
            _context.SaveChanges();
        }
        public IEnumerable<Responsibility> MonthResponsibilities(int day, int month)
        {
            var coll = _context.responsibilities
                .Where(x => x.date.Day == day && x.date.Month == month).ToList();
            return coll;
        }
        public void CreateEditResponsibility(int? id)
        {
            if (id is not null)
            {
                var smpl = _context.responsibilities.FirstOrDefault(x => x.id == id);
            }
        }
        public void CreateEditResponsibilityForm(Responsibility model)
        {
            if(model.id == 0)
            {
                _context.responsibilities.Add(model);
                _context.SaveChanges();
            }
            else
            {
                _context.responsibilities.Update(model);
                _context.SaveChanges();
            }
        }
        public int TotalMonthResponsibilities(int day, int month)
        {
            return _context.responsibilities
                .Where(x => x.accoplishment == false && x.date.Day == day && x.date.Month == month).Count();
        }

        public int TotalResponsibilities()
        {
            return _context.responsibilities.Count();
        }
    }
}
