using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplicationRazorpage.Pages
{
	public class AddModel : PageModel
	{
		public int number1 { get; set; }
		public int number2 { get; set; }
		public int result { get; set; }
		public string Title { get; set; } = "";
		public void OnGet()
		{
			Title = "Calculator";
			number1 = 0;
		}
		public void OnPostAdd()
		{
			result = number1 + number2;
			//Display?result=10
			Response.Redirect("/ Display ? a = " + result);
		}
		public void OnPostSubtract()
		{
			result = number1 - number2;
			Response.Redirect("/ Display ? a = " + result);
		}
	}
}
