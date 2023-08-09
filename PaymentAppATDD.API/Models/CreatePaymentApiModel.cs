using System.ComponentModel.DataAnnotations;

namespace PaymentAppATDD.API.Models
{
	public class CreatePaymentApiModel
	{
		[Range(1,10000, ErrorMessage ="Payment amount should be between 1 to 10000")]
		public decimal Amount { get; set; }
	}
}
