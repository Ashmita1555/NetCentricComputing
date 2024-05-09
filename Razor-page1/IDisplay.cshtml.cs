using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor_page1.Pages
{
	public class IDisplayModel : PageModel
	{
		public string Result { get; set; } = "";
		public void OnGet()
		{
			Result = Request.Query["a"].ToString();
		}
	}
}
