namespace Formu_Listos_ATM.Models
{
	public class Answer
	{
		public int AnswerId { get; set; }
		public int FormId { get; set; }
		public int QuestionId { get; set; }
		public string? answerData { get; set; }
		public int? answerDataInt { get; set; }
        public int? answerOptionId { get; set; }
        public bool answerBool { get; set; } = false;

    }
}
