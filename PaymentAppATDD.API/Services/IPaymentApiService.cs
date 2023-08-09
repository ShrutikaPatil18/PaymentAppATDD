using PaymentAppATDD.API.Models;

namespace PaymentAppATDD.API.Services
{
	public interface IPaymentApiService
	{
		Task<PaymentApiModel> CreatePaymentAsync(CreatePaymentApiModel model);
	}
}
