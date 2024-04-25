using Formu_Listos_ATM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formu_Listos_ATM.Pages.Campaigns
{
    public class campaignsMaintenanceModel : PageModel
    {
        public campaignsMaintenance campaignsMaintenance { get; set; }
        public void OnGet(int? campaignId)
        {
            if (campaignId == null)
            {

                //Consulta de la campaña, editar
            }
            else {
                campaignsMaintenance = new campaignsMaintenance();
            }
        }
    }
}
