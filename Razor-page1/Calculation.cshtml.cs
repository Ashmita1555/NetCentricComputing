using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor_page1.Pages
{
    public class CalculationModel : PageModel
    {
		public int number1 { get; set; }
		public int number2 { get; set; }
		public int result { get; set; }
        public string Title { get; set; } = "";
        public void OnGet()
        {
			Title = "Academia College";
			number1 = 0;
		}
		public void onPostAdd()
		{
			result = number1 + number2;
			//Display?result=10

			Response.Redirect("/Display?a=" + result);
			
		}
		public void onPostSubtract()
		{
			result = number1 - number2;
			//Display?result=10

			Response.Redirect("/Display?a=" + result);

		}

	}
}
