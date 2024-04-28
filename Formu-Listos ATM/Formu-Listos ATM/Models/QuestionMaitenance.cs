using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace Formu_Listos_ATM.Models
{
	public class QuestionMaitenance
	{
		public int QuestionID { get; set; }
        [DisplayName("Descripcion")]
        public string? QuestionDescription { get; set; }
        [DisplayName("Orden")]
        public int Sort { get; set; }
        [DisplayName("Tipo de pregunta")]
        public int QuestionTypeId { get; set; }
        [DisplayName("Titulo de pregunta")]
        public string QuestionTitle { get; set; }
        [DisplayName("Mensaje de validacion")]
        public string? ValidatorMessage { get; set; }
        [DisplayName("Requerido")]
        public bool IsRequired { get; set; }
        [DisplayName("Opciones")]
        public int OptionID{ get; set; }
		public bool needGraphed { get; set; }
	}
}
