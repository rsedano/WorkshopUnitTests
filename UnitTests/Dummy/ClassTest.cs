namespace UnitTests.Dummy
{
	public class ClassTest
	{
		[Fact]
		public void shouldAddNewStudentToClass()
		{
			//Arrange
			var schoolClass = new SchoolClass("newClass", new List<Student>(), new List<Teacher>());

			//Act
			//Pass a dummy student to comply with the method's signature
			schoolClass.addStudentToSchoolClass(new DummyStudent());

            //Assert
            Assert.Equal(1, schoolClass.numberOfStudents());
		}

		[Fact]
		public void shouldAddNewTeacherToClass()
		{
			//Arrange
			var schoolClass = new SchoolClass("newClass", new List<Student>(),  new List<Teacher>());

			//Act
			//Pass a dummy student to comply with the method's signature
			schoolClass.addTeacherToSchoolClass(new DummyTeacher());

            //Assert
            Assert.Equal(1, schoolClass.numberOfTeachers());
		}
	}
}


