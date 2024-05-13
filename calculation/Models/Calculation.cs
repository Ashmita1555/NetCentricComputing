using System.ComponentModel.DataAnnotations;

namespace calculation.Models
{
    public class Calculation
    {

        [Required(ErrorMessage = "Please enter the first number")]
        public double n1 { get; set; }

        [Required(ErrorMessage = "Please enter the second number")]
        public double n2 { get; set; }

        public double result { get; set; }
    }
}
