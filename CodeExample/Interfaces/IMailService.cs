using System;
namespace CodeExample.Interfaces
{
	public interface IMailService
	{
        public Task<HttpResponseMessage> sendConfirmationMessage(string emailAddress, string message);

    }
}

