using System.ComponentModel.DataAnnotations;

namespace MyFirstASP_Application.Models
{
	public class Person
	{
		public int id { get; set; }

		[Required(ErrorMessage = "Fill the gap")]
		[MaxLength(10, ErrorMessage = "Too many symbols")]
		public string? firstName { get; set; }

		[Required(ErrorMessage = "Fill the gap")]
		[MaxLength(10, ErrorMessage = "Too many symbols")]
		public string? secondName { get; set; }

		[Required(ErrorMessage = "Fill the gap")]
		public int age { get; set; }

		[Required(ErrorMessage = "Fill the gap")]
		[MaxLength(10, ErrorMessage = "Too many symbols")]
		public string? countryResidenship { get; set; }

	}
}
