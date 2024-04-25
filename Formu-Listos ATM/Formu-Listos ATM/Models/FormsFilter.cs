namespace Formu_Listos_ATM.Models
{
	public class FormsFilter
    {
		public int CampannaId { get; set; }
		public string FormTitle { get; set; } 
		public DateTime DateStart { get; set; }
		public DateTime DateEnd { get; set; }
		public int Status { get; set; }

	}
}
