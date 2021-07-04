using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalksApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CostumerController : ControllerBase
	{
		[HttpPost]
		public IActionResult Post()
		{
			return Ok();
		}
	}
}
