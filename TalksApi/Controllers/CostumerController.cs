
using Microsoft.AspNetCore.Mvc;
using System.Linq;

using TalksApi.Entitie;
using TalksApi.Models.Contratos;
using TalksApi.Repository;

namespace TalksApi.Controllers

{

	[Route("api/[controller]")]
	[ApiController]
	
	public class CostumerController : ControllerBase
	{

		private readonly CostumerRepository _costumerRepository;

		public CostumerController()
		{
			_costumerRepository = new CostumerRepository();
		}

		[HttpPost]
		public IActionResult Post(CostumerRequest request)
		{

			var costumers = new Costumer(request);

			_costumerRepository.Save(costumers);

			var response = CreateResponse(costumers);

			return Ok();
		}

		[HttpGet]
		[Route("{id}")]
		public IActionResult Get(string id)
		{
			var costumers = _costumerRepository.GetById(id);

			if (costumers == null)
				return NotFound();
			return Ok(costumers);
		}

		[HttpGet]
		public IActionResult Get()
		{
			var costumers = _costumerRepository.Getall();

			if (costumers.Any() == false)
				return NotFound();

			return Ok(costumers);
		}

		[HttpPut]
		[Route("{id}")]

		public IActionResult Put(string id, CostumerRequest request)
		{
			if (ModelState.IsValid == false)
				return BadRequest();

			var costumer = _costumerRepository.GetById(id);

			if (costumer == null)
				return NotFound();

			costumer.Update(request);

			_costumerRepository.Update(costumer);

			return StatusCode(204);

		}

		[HttpDelete]
		[Route("{id}")]

		public IActionResult Delete(string id)
		{
			if (ModelState.IsValid == false)
				return BadRequest();

			var costumer = _costumerRepository.GetById(id);

			if (costumer == null)
				return NotFound();

			_costumerRepository.Delete(id);

			return StatusCode(204);

		}

		public CostumerResponse CreateResponse(Costumer costumer)
		{
			return new CostumerResponse()
			{
				Id = costumer.ExternalId,
				Name = costumer.Name,
				Email = costumer.Email,
				Document = costumer.Document,
				DocumentType = costumer.DocumentType

			};
		}
	}
}
