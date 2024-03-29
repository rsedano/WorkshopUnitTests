﻿namespace UnitTests.Fake
{
	public class StudentRepositoryTest
	{
		[Fact]
		public void shouldAddNewStudentToRepository()
		{
			//Arrange
			var testStudent = new Student("Donald", "Duck", age: 30, "donal@duck.com", "someone@email.com");
			var fakeStudentRepository = new FakeStudentRepository();

			//Act
			fakeStudentRepository.addStudent(testStudent);

			//Assert
			Assert.Single(fakeStudentRepository.getStudents());
		}
	}
}

