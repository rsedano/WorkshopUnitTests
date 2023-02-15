namespace UnitTests.Dummy
{
	public class ClassTest
	{
		[Fact]
		public void shouldAddNewStudentToClass()
		{
			//Arrange
			var schoolClass = new SchoolClass("newClass", new List<Student>());

			//Act
			//Pass a dummy student to comply with the method's signature
			schoolClass.addStudentToSchoolClass(new DummyStudent());

            //Assert
            Assert.Equal(1, schoolClass.numberOfStudents());
		}
	}
}

