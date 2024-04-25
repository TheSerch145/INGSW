using Formu_Listos_ATM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formu_Listos_ATM.Pages.Campaigns
{
    public class CampaignsModel : PageModel
    {
        public List<CampaignsModelBD> CampaignsList { get; set; }
        public void OnGet()
        {
            CampaignsList = new List<CampaignsModelBD>();
            CampaignsList.Add(new CampaignsModelBD { 
                CampannaId = 1,
                CampannaFullTitle = "test",
                Description = "test"
            });
        }
    }
}
