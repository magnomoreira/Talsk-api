using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TalksApi.Entitie;

namespace TalksApi.Repository
{
	public class CostumerRepository
	{
		public static IList<Costumer> costumers = new List<Costumer>();

		public Costumer GetById(string id)
		{
			return costumers.FirstOrDefault(i => i.ExternalId == id);
		}

		public IList<Costumer> Getall()
		{
			return costumers;
		}

		public bool Save(Costumer costumer)
		{
			costumers.Add(costumer);
			return true;
		}
		public bool Update(Costumer costumer)
		{
			var costumerDelete = costumers.FirstOrDefault(x => x.ExternalId == costumer.ExternalId);
			costumers.Remove(costumerDelete);
			costumers.Add(costumer);
			return true;

		}

		public bool Delete(string id)
		{
			var costumerDelete = costumers.FirstOrDefault(x => x.ExternalId == id);
			costumers.Remove(costumerDelete);
			return true;

		}

	}
}
