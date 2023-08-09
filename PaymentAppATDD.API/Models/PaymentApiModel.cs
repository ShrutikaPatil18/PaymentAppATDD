using System.Net;

namespace PaymentAppATDD.API.Models
{
	public class PaymentApiModel
	{
		public Guid PaymentId { get; set; }
		public decimal Amount { get; set; }
		public HttpStatusCode StatusCode { get; set; }
	}
}
