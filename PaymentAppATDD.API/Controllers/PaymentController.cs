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
	}
}
