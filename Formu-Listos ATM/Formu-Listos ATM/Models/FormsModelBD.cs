namespace Formu_Listos_ATM.Models
{
	public class FormsModelBD
    {
		public int FormularioId { get; set; }

		public int CampannaId { get; set; }

		public string FormTitle { get; set; } 

		public string FormDescription { get; set; } 

		public string FormNote { get; set; } 

		public string? Vigencia { get; set; }

		public DateTime DateStart { get; set; }

		public DateTime DateEnd { get; set; }

		public int IsActive { get; set; }

		public List<Question>? Questions { get; set; }

	}
}
