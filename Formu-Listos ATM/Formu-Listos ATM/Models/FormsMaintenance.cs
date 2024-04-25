using System.ComponentModel;

namespace Formu_Listos_ATM.Models
{
	public class FormsMaintenance
    {
		public int? FormularioId { get; set; }

		[DisplayName("Titulo de formulario")]
		public string FormTitle { get; set; }
        [DisplayName("Descripcion del formulario")]
        public string FormDescription { get; set; } 
		[DisplayName("Notas del formulario")]

		public string FormNote { get; set; } 

		public string? Vigencia { get; set; }
        [DisplayName("Fecha de formulario")]

        public DateTime DateStart { get; set; }
        [DisplayName("")]

        public DateTime DateEnd { get; set; }

		public bool IsActive { get; set; }

	}
}
