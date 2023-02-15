﻿namespace UnitTests.Stub
{
	public class StudentTest
	{
		[Fact]
		public void sendMessageToStudentWhenSuccessfullyEnrolledToClass()
		{
			//Arrange
			var mailServiceStub = new MailServiceStub();
			var student = new Student("Darth","Sponge", 30);
			var schoolClass = new SchoolClass("DarkSideClass", new List<Student> { student });

			var expectedMessage = "Message successfully sent for class DarkSideClass";

            //Act
            student.enrollToClass(mailServiceStub, schoolClass);

			//Assert
			Assert.Equal(expectedMessage, mailServiceStub.messageSent);
		}
	}
}

