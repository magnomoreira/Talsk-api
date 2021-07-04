

<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;

=======
>>>>>>> master
namespace TalksApi.Models.Contratos
{
	public class CostumerRequest
	{
<<<<<<< HEAD
		[Required(ErrorMessage ="Name is invalid")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Email is invalid")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Document is invalid")]
		public string Document { get; set; }
		[Required(ErrorMessage = "DocumentType is invalid")]
=======
		public string Name { get; set; }
		public string Email { get; set; }
		public string Document { get; set; }
>>>>>>> master
		public string DocumentType { get; set; }
	}
}
