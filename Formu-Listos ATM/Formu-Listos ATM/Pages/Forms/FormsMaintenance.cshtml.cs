using Formu_Listos_ATM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formu_Listos_ATM.Pages.Forms
{
    public class FormsMaintenanceModel : PageModel
    {
        public FormsMaintenance formsMaintenance { get; set; }
        public void OnGet()
        {
            formsMaintenance = new FormsMaintenance();
        }

        public void OnPost()
        {
            formsMaintenance = new FormsMaintenance();
        }
        
    }
}
