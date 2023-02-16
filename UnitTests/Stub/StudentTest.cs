namespace UnitTests.Stub
{
	public class StudentTest
	{
		[Fact]
		public void sendMessageToStudentWhenSuccessfullyEnrolledToClass()
		{
			//Arrange
			var mailServiceStub = new MailServiceStub();
			var student = new Student("Darth","Vader", 30, "darth.vader@darkside.sw", "shmi.skywalker@tattoine.sw");
			var schoolClass = new SchoolClass("DarkSideClass", new List<Student> { student }, new List<Teacher> { });

			var expectedMessage = "Message successfully sent for class DarkSideClass";

            //Act
            student.enrollToClass(mailServiceStub, schoolClass);

			//Assert
			Assert.Equal(expectedMessage, mailServiceStub.messageSent);
		}
	}
}

