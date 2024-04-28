using Formu_Listos_ATM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formu_Listos_ATM.Pages.Forms
{
    public class FormModel : PageModel
    {
        public FormsModelBD Form { get; set; }
        public List<Question> Questions { get; set; }
        public Dictionary<int,Answer> Answers  { get; set; }
        public void OnGet(int FormId)
        {
            Form = new FormsModelBD();
            Questions = new List<Question>();
            Answers = new Dictionary<int, Answer>();
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
                Answers.Add(question.QuestionID, new Answer());

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
                                new CatalogValue { 
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
        }

        public void OnPost(Dictionary<int, Answer> answers) {
            OnGet(1);
        }
    }
}
