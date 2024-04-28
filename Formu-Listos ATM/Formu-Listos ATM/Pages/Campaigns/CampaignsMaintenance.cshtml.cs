using Formu_Listos_ATM.Functions;
using Formu_Listos_ATM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR.Protocol;
using Microsoft.Extensions.Caching.Memory;

namespace Formu_Listos_ATM.Pages.Campaigns
{
    public class campaignsMaintenanceModel : PageModel
    {
        public CampaignsMaintenance CampaignsMaintenance { get; set; }
        private readonly IMemoryCache _memoryCache;

        public string Message = string.Empty;

        public void OnGet(int? campaignId)
        {
            if (campaignId == null)
            {

                //Consulta de la campaña, editar
            }
            else
            {
                CampaignsMaintenance = new CampaignsMaintenance();
            }
        }

        public void OnPost(CampaignsMaintenance campaignsMaintenance)
        {
            if (!ModelState.IsValid)
            { 
                return ; 
            }

            CampaignsFunctions campaignsFunctions = new CampaignsFunctions(_memoryCache);

            if (campaignsMaintenance.CampannaId != 0)
            {
                // edit
                campaignsFunctions.add(campaignsMaintenance,out var outmessage);
                Message = outmessage;


            }
            else {
                // add
                campaignsFunctions.edit(campaignsMaintenance, out var outmessage);
                Message = outmessage;

            }


            CampaignsMaintenance = campaignsMaintenance;
        }
    }
}
