using Microsoft.AspNetCore.Mvc;

namespace Formu_Listos_ATM.Controllers
{
    public class QuestionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetQuestions()
        {
            return PartialView("_Question");
        }

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
