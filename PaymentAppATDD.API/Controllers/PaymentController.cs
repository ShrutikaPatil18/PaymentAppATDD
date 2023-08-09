using Microsoft.AspNetCore.Mvc;
using PaymentAppATDD.API.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PaymentAppATDD.API.Controllers
{
	[Route("payments")]
	[ApiController]
	public class PaymentController : ControllerBase
	{
		private readonly IPaymentApiService _apiService;

		public PaymentController(IPaymentApiService apiService)
		{
			_apiService = apiService;
		}
		// GET: api/<PaymentController>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<PaymentController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<PaymentController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<PaymentController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<PaymentController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
