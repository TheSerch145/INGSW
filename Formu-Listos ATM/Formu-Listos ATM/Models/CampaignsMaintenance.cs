﻿namespace Formu_Listos_ATM.Models
{
	public class campaignsMaintenance
	{
		public int CampannaId { get; set; }
		public string? CampannaFullTitle { get; set; }
		public string? Description { get; set; }
        public bool IsActive { get; set; }
		public DateTime FechaInico { get; set; }
		public DateTime FechaFin { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime DateUpdated { get; set; }
	}
}
