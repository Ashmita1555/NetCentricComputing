using System.ComponentModel.DataAnnotations;

namespace calculation.Models
{
    public class Calculation
    {
        [Required(ErrorMessage ="Please enter the first number")]
        public int n1 { get; set; }

        [Required(ErrorMessage = "Please enter the second number")]
        public int n2 { get; set; }
        public int result { get; set; }

    }
}
