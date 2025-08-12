using System.ComponentModel.DataAnnotations;

namespace MyFirstASP_Application.Models
{
    public class Expense
    {
        public int id { get; set; }
        public double Value { get; set; }

        [Required]
        public string? Description { get; set; }
        public DateTime Date { get; set; }
    }
}
