using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TalksApi.Models.Contratos;

namespace TalksApi.Entitie
{
	public class Costumer
	{

		public Costumer(CostumerRequest request)
		{
			var randon = new Random();
			ExternalId = "" + randon.Next(9999999);
			Name = request.Name;
			Email = request.Email;
			Document = request.Document;
			DocumentType = request.DocumentType;


		}

		public string Id { get; set; }
		public string ExternalId { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Document { get; set; }
		public string DocumentType { get; set; }

		public void Update(CostumerRequest request)
		{
			Name = request.Name;
			Email = request.Email;
			Document = request.Document;
			DocumentType = request.DocumentType;

		}
	}
}
