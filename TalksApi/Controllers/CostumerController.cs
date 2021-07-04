using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TalksApi.Entitie;
using TalksApi.Models.Contratos;

namespace TalksApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CostumerController : ControllerBase
	{
		[HttpPost]
		public IActionResult Post(CostumerRequest request)
		{

			var costumer = new Costumer(request);
			return Ok();
		}
	}
}
