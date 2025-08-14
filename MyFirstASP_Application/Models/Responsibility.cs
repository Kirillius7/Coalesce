using System.ComponentModel.DataAnnotations;

namespace MyFirstASP_Application.Models
{
    public class Responsibility
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Task is required")]
        public string? task { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime date { get; set; }

        public bool accoplishment { get; set; }
    }
}
