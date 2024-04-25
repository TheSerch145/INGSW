using System.ComponentModel;

namespace Formu_Listos_ATM.Models
{
	public class CampaignsFilter
	{
		[DisplayName("Titulo de campaña")]
		public string? CampannaFullTitle { get; set; }

		public int Status { get; set; }

		public DateTime FechaInico { get; set; }

		public DateTime FechaFin { get; set; }

		public DateTime DateCreated { get; set; }

		public DateTime DateUpdated { get; set; }

	}
}
