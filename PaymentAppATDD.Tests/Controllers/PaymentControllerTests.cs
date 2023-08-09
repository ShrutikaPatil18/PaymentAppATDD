﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AutoFixture;
using FluentAssertions;
using PaymentAppATDD.API.Models;
using PaymentAppATDD.Tests.ApiClient;
using PaymentAppATDD.Tests.Factories;

namespace PaymentAppATDD.Tests.Controllers
{
	public class PaymentControllerTests : IClassFixture<PaymentAppATDDWebApplicationFactory>
	{
		private readonly PaymentAppATDDApiClient _apiClient;
		private readonly Fixture _fixture;

		public PaymentControllerTests(PaymentAppATDDWebApplicationFactory factory)
		{
			if (factory == null)
			{
				throw new ArgumentNullException(nameof(factory));

			}
			var client = factory.CreateClient();
			_apiClient= new PaymentAppATDDApiClient(client);
			_fixture = new Fixture();
		}

		[Theory]
		[InlineData(1)]
		[InlineData(10000)]
		public async Task CreatePayment_AmountIsValid_EnsureSuccessStatusCode(decimal amount)
		{
			//Arrange
			var request = new CreatePaymentApiModel
			{
				Amount= amount,
			};

			//Act
			var result = await _apiClient.CreatePaymentAsync(request);

			//Assert
			result.Should().NotBeNull();
			result.Should().Be(HttpStatusCode.OK);
			result.Should().Be(amount);
		}

		[Theory]
		[InlineData(0)]
		[InlineData(10001)]
		public async Task CreatePayment_AmountIsNotValid_EnsureBadRequestStatusCode(decimal amount)
		{
			//Arrange
			var request = new CreatePaymentApiModel
			{
				Amount= amount,
			};

			//Act
			var result = await _apiClient.CreatePaymentAsync(request);

			//Assert
			result.Should().NotBeNull();
			result.Should().Be(HttpStatusCode.BadRequest);
		}
	}
}


