using System.ComponentModel.DataAnnotations;

namespace MyFirstASP_Application.Models
{
    public class Date
    {
        public int id { get; set; }

        [Required]
        public string? name { get; set; }

        [Required]
        public string? type { get; set; }

        [Required]
        public DateTime dt { get; set; }
    }
}
