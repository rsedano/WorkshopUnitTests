using System;
using System.Net;
using NSubstitute.Callbacks;

namespace UnitTests.Integration
{
	public class MailServiceHotSpotTest
	{
		[Fact]
		public async Task SendEmailNotification()
		{
			//Arrange
			var httpclient = new HttpClient();
			var emailService = new MailServiceHotSpot(httpclient);

			//Act
			var response = await emailService.sendConfirmationMessage("google@answer.com", "What is Baby Yoda's real name?");

            //Assert
            Assert.NotNull(response);
			Assert.Equal(HttpStatusCode.Created, response.StatusCode);
		}
	}
}

