using System.ComponentModel.DataAnnotations;

namespace MyFirstASP_Application.Models
{
    public class Date
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string? name { get; set; }

        [Required(ErrorMessage = "Type is required")]
        public string? type { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime dt { get; set; }
    }
}
