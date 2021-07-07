using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TalksApi.Entitie;

namespace TalksApi.Repository
{
	public class CustumerRepository
	{
		public static IList<Custumer> costumers = new List<Custumer>();

		public Custumer GetById(string id)
		{
			return costumers.FirstOrDefault(i => i.ExternalId == id);
		}

		public IList<Custumer> Getall()
		{
			return costumers;
		}

		public bool Save(Custumer costumer)
		{
			costumers.Add(costumer);
			return true;
		}
		public bool Update(Custumer costumer)
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
