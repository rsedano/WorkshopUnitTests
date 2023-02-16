using System.Net;

namespace UnitTests.Stub
{
	public class MailServiceStub: IMailService
	{
        public string? messageSent
        {
            get; set;
        }

        public async Task<HttpResponseMessage> sendConfirmationMessage(string emailAddress, string message)
        {
            await Task.FromResult(0);
            messageSent = $"Message successfully sent for class {message}";
            return new HttpResponseMessage(HttpStatusCode.Accepted);
        }
    }
}

