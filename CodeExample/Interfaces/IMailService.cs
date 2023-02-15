using System;
namespace CodeExample.Interfaces
{
	public interface IMailService
	{
		public string sendConfirmationMessage(string enailTo, string message);
	}
}

