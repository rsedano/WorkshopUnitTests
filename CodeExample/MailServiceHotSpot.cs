using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;
using CodeExample.Interfaces;

namespace CodeExample
{
	public class MailServiceHotSpot: IMailService
	{
        readonly HttpClient httpClient;
		public MailServiceHotSpot(HttpClient httpClient)
		{
            this.httpClient = httpClient;
            this.httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
        }

        public async Task<HttpResponseMessage> sendConfirmationMessage(string emailAddress, string message)
        {
            using StringContent jsonContent = new(
                JsonSerializer.Serialize(new {
                    emailAddress,
                    message
                }),
                Encoding.UTF8,
                "application/json");

            using HttpResponseMessage response = await this.httpClient.PostAsync(
            "posts",
            jsonContent);

            return response.EnsureSuccessStatusCode();
        }
    }
}

