using System;
using CodeExample.Interfaces;

namespace CodeExample
{
	public class MailServiceHotSpot: IMailService
	{
		public MailServiceHotSpot()
		{
            
		}

        public string sendConfirmationMessage(string emailAddress, string message)
        {
            throw new NotImplementedException();
        }
    }
}

