using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using PaymentAppATDD.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace PaymentAppATDD.Tests.ApiClient
{
	public class PaymentAppATDDApiClient
	{
		private readonly HttpClient _client;

		public PaymentAppATDDApiClient(HttpClient client)
		{
			_client= client ?? throw new ArgumentNullException(nameof(client));
		}

		//public async Task ObjectResult<PaymentApiModel> CreatePaymentAsync(CreatePaymentApiModel model)
		//{
		//	if(model == null)
		//	{
		//		throw new ArgumentNullException(nameof(model));
		//	}
		//	var result= new ObjectResult<PaymentApiModel>();
		//	using var response = await _client.PostAsJsonAsync("payments", model);

		//	result.StatusCode = response.StatusCode;
		//	if(response.IsSuccessStatusCode)
		//	{
		//		result.Content =await response.Content.ReadFromJsonAsync<PaymentApiModel>();
		//	}
		//}

		public async Task<ActionResult<PaymentApiModel>> CreatePaymentAsync(CreatePaymentApiModel model)
		{
			if(model is null)
			{
				throw new ArgumentNullException(nameof(model));
			}
			
			var result = new PaymentApiModel();
			using var response = await _client.PostAsJsonAsync("payments",model);

			result.StatusCode = response.StatusCode;

			if(response.IsSuccessStatusCode)
			{
				result =await response.Content.ReadFromJsonAsync<PaymentApiModel>();
			}
			return result;
		}
		

	}
}
