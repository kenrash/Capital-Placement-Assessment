using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AssessmentWebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProgramDetailsController : ControllerBase
	{
		// GET: api/<ProgramDetailsController>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<ProgramDetailsController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<ProgramDetailsController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<ProgramDetailsController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<ProgramDetailsController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
