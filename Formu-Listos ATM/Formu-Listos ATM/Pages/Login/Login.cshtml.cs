using Formu_Listos_ATM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formu_Listos_ATM.Pages
{
	public class LoginModel : PageModel
	{
		private readonly ILogger<PrivacyModel> _logger;

		public User User { get; set; }	

		public LoginModel(ILogger<PrivacyModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{
		}
	}

}
