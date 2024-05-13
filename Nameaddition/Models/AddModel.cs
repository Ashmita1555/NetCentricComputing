using System.ComponentModel.DataAnnotations;

namespace Nameaddition.Models
{
    public class AddModel
    {
        [Required(ErrorMessage = "Please enter the name")]
        public string Name { get; set; }


        public string Result { get; set; }

    }
}
