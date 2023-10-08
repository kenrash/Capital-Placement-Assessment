using AssessmentWebAPI.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AssessmentWebAPI.Controllers
{
	//public private ApplicationForm AppForm();

	[Route("api/[controller]")]
	[ApiController]
	public class ApplicationFormController : ControllerBase
	{
		// GET: api/<ApplicationFormController>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<ApplicationFormController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<ApplicationFormController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<ApplicationFormController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<ApplicationFormController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
