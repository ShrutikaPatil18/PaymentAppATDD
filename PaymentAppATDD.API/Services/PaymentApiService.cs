using PaymentAppATDD.API.Models;

namespace PaymentAppATDD.API.Services
{
	public class PaymentApiService : IPaymentApiService
	{
		public PaymentApiModel CreatePayment(CreatePaymentApiModel model)
		{
			if(model is null)
			{
				throw new ArgumentNullException(nameof(model));
			}
			return new PaymentApiModel
			{
				PaymentId=Guid.NewGuid(),
				Amount=model.Amount,
			};
		}

		public Task<PaymentApiModel> CreatePaymentAsync(CreatePaymentApiModel model)
		{
			throw new NotImplementedException();
		}
	}
}
