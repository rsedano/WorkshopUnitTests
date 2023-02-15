namespace UnitTests.Stub
{
	public class MailServiceStub: IMailService
	{
        public string? messageSent
        {
            get; set;
        }

        public string sendConfirmationMessage(string emailTo, string message)
        {
            messageSent = $"Message successfully sent for class {message}";

            return messageSent;
        }
    }
}

