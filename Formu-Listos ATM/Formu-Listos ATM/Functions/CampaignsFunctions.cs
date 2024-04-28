using Formu_Listos_ATM.Models;
using Microsoft.Extensions.Caching.Memory;

namespace Formu_Listos_ATM.Functions
{
    public class CampaignsFunctions : UserFunctions
    {
		private readonly IConfiguration _configuration;

        private readonly IMemoryCache _memoryCache;

        public CampaignsFunctions(IMemoryCache memoryCache) : base(memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public bool add(CampaignsMaintenance campaignsMaintenance, out string message) {


            message = string.Empty;
            if (!UserValid()) {
                return false;

            }



            return false;
        }

        public bool edit(CampaignsMaintenance campaignsMaintenance, out string message)
        {
            message = string.Empty;

            return false;

        }
    }
}
