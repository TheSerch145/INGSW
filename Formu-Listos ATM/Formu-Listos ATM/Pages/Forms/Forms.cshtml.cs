using Formu_Listos_ATM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formu_Listos_ATM.Pages.Campaigns
{
    public class FormsModel : PageModel
    {
        public List<FormsModelBD> formsList;
        public void OnGet(int campaignId)
        {
            formsList = new List<FormsModelBD>();

            formsList.Add(new FormsModelBD{
                FormularioId = 1,
                FormTitle = "FormTest",
                FormDescription = "Description",
                IsActive = 1
            });
        }
    }
}
