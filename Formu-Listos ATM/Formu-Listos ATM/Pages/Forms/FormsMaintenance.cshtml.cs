using Formu_Listos_ATM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formu_Listos_ATM.Pages.Forms
{
    public class FormsMaintenanceModel : PageModel
    {
        public FormsMaintenance FormsMaintenance { get; set; }

        public List<Question> questions { get; set; }
        public void OnGet()
        {
            FormsMaintenance = new FormsMaintenance();
        }

        public void OnPost(FormsMaintenance formsMaintenance)
        {
            FormsMaintenance = formsMaintenance;
        }

        public PartialViewResult OnGetQuestions(int FormID, int Plus = 0)
        {
            var model = new QuestionSharedPage();

            var Questions = new List<Question>();
            for (int i = 1; i <= 10; i++)
            {
                var question = new Question
                {
                    QuestionID = i,
                    QuestionDescription = $"Descripción de la pregunta {i}",
                    Sort = i,
                    QuestionTitle = $"Pregunta {i}",
                    IsRequired = true,
                    needGraphed = false
                };

                switch (i % 5)
                {
                    case 1:
                        question.QuestionTypeId = 1;
                        break;
                    case 2:
                        question.QuestionTypeId = 2;
                        question.Options = new List<CatalogValue>();
                        for (int j = 1; j <= 10; j++)
                        {
                            question.Options.Add(
                                new CatalogValue
                                {
                                    Id = j,
                                    Description = j.ToString()
                                }
                            );
                        }
                        break;
                    case 3:
                        question.QuestionTypeId = 3;
                        break;
                    case 4:
                        question.QuestionTypeId = 4;
                        break;
                    case 0:
                        question.QuestionTypeId = 5;
                        break;
                }

                Questions.Add(question);
            }

            foreach (var question in Questions.OrderBy(q => q.Sort))
            {
                model.questions.Add(question.QuestionID, new QuestionMaitenance
                {
                    QuestionID = question.QuestionID,
                    QuestionDescription = question.QuestionDescription,
                    Sort = question.Sort,
                    QuestionTypeId = question.QuestionTypeId,   
                    QuestionTitle = question.QuestionTitle,
                    ValidatorMessage = question.ValidatorMessage,
                    IsRequired = question.IsRequired,
                    needGraphed = question.needGraphed,
                    OptionID = question.OptionID,
                });
            }

            for (int i = 0; i > Plus; i++)
            {
                model.questions.Add(Questions.Count() + i + 1, new QuestionMaitenance());
            }


            return Partial("_Question", model);
        }

    }
}
