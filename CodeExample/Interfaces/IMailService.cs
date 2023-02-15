using System;
namespace CodeExample
{
	public interface IMailService
	{
		public string sendConfirmationMessage(string enailTo, string message);
	}
}

