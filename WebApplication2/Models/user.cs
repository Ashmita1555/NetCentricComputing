using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Models
{
	[BindProperties]
	public class user

	{
		public int ID { get; set; }
		public string username { get; set; }
		public string password { get; set; }
		public string email { get; set; }
	}
}
