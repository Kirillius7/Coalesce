using System.ComponentModel.DataAnnotations;

namespace MyFirstASP_Application.Models
{
    public class Expense
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Value is required")]
        public double Value { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }
    }
}
