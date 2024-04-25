using Formu_Listos_ATM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formu_Listos_ATM.Pages.Forms
{
    public class FormsAdministrationModel : PageModel
    {
        public FormsFilter formsFilter { get; set; }
        public List<FormsModelBD> FormsList { get; set; }
        public void OnGet()
        {
            FormsList = new List<FormsModelBD>();

            FormsList.Add(new FormsModelBD
            {
                FormularioId = 1,
                FormTitle = "FormTest",
                FormDescription = "Description",
                IsActive = 1
            });
        }
        public void OnPost(CampaignsFilter campaignsFilter)
        {
            FormsList = new List<FormsModelBD>();

        }
    }
}
