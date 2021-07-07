
using System.ComponentModel.DataAnnotations;

namespace TalksApi.Models.Contratos
{
	public class CustumerRequest
	{
		[Required(ErrorMessage ="Name is invalid")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Email is invalid")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Document is invalid")]
		public string Document { get; set; }
		[Required(ErrorMessage = "DocumentType is invalid")]

		public string DocumentType { get; set; }
	}
}
