using System.ComponentModel.DataAnnotations;

namespace MyFirstASP_Application.Models
{
    public class Responsibility
    {
        public int id { get; set; }

        [Required]
        public string? task { get; set; }

        [Required]
        public DateTime date { get; set; }

        [Required]
        public bool accoplishment { get; set; }
    }
}
