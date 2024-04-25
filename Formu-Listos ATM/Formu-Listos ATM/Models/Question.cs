using Microsoft.AspNetCore.Mvc.Rendering;

namespace Formu_Listos_ATM.Models
{
	public class Question
	{
		public int QuestionID { get; set; }

		public string? QuestionDescription { get; set; }

		public int Sort { get; set; }

		public int QuestionTypeId { get; set; }

		public string QuestionTitle { get; set; }

		public string? ValidatorMessage { get; set; }

		public int IsRequired { get; set; }

		public int OptionID{ get; set; }
		public string OptionValue{ get; set; }
		public bool OptionBool { get; set; } = false;
        public List<CatalogValue>? Options { get; set; }

		public bool needGraphed { get; set; }
	}
}
