using Formu_Listos_ATM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formu_Listos_ATM.Pages.Campaigns
{
    public class CampaignsAdministrationModel : PageModel
    {
        public CampaignsFilter campaignsFilter { get; set; }
        public List<CampaignsModelBD> CampaignsList { get; set; }
        public void OnGet()
        {
            CampaignsList = new List<CampaignsModelBD>();
            CampaignsList.Add(new CampaignsModelBD
            {
                CampannaId = 1,
                CampannaFullTitle = "test",
                Description = "test"
            });
        }
        public void OnPost(CampaignsFilter campaignsFilter)
        {
            CampaignsList = new List<CampaignsModelBD>();

        }
    }
}
