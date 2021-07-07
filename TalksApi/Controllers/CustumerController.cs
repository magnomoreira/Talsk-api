
using Microsoft.AspNetCore.Mvc;
using System.Linq;

using TalksApi.Entitie;
using TalksApi.Models.Contratos;
using TalksApi.Repository;

namespace TalksApi.Controllers

{

	[Route("api/[controller]")]
	[ApiController]
	
	public class CustumerController : ControllerBase
	{

		private readonly CustumerRepository _custumerRepository;

		public CustumerController()
		{
			_custumerRepository = new CustumerRepository();
		}

		[HttpPost]
		public IActionResult Post(CustumerRequest request)
		{

			var custumers = new Custumer(request);

			_custumerRepository.Save(custumers);

			var response = CreateResponse(custumers);

			return Ok();
		}

		[HttpGet]
		[Route("{id}")]
		public IActionResult Get(string id)
		{
			var custumers = _custumerRepository.GetById(id);

			if (custumers == null)
				return NotFound();
			return Ok(custumers);
		}

		[HttpGet]
		public IActionResult Get()
		{
			var custumers = _custumerRepository.Getall();

			if (custumers.Any() == false)
				return NotFound();

			return Ok(custumers);
		}

		[HttpPut]
		[Route("{id}")]

		public IActionResult Put(string id, CustumerRequest request)
		{
			if (ModelState.IsValid == false)
				return BadRequest();

			var custumer = _custumerRepository.GetById(id);

			if (custumer == null)
				return NotFound();

			custumer.Update(request);

			_custumerRepository.Update(custumer);

			return StatusCode(204);

		}

		[HttpDelete]
		[Route("{id}")]

		public IActionResult Delete(string id)
		{
			if (ModelState.IsValid == false)
				return BadRequest();

			var custumer = _custumerRepository.GetById(id);

			if (custumer == null)
				return NotFound();

			_custumerRepository.Delete(id);

			return StatusCode(204);

		}

		public CustumerResponse CreateResponse(Custumer custumer)
		{
			return new CustumerResponse()
			{
				Id = custumer.ExternalId,
				Name = custumer.Name,
				Email = custumer.Email,
				Document = custumer.Document,
				DocumentType = custumer.DocumentType

			};
		}
	}
}
