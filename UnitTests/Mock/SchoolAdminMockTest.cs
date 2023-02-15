namespace UnitTests.Mock
{
	public class StudentTest
	{
		[Fact]
		public void ShouldCloseLabWindowWhenFireIsDeclared()
		{
			//Arrange
			var schoolAdminMock = new SchoolAdminMock();

			//Act
			schoolAdminMock.CloseElementSchoolDueToAFire("LabWindow");

			//Assert
			Assert.Equal(1, schoolAdminMock.invocation("CloseElementSchoolDueToAFire"));
			Assert.Equal("LabWindow", schoolAdminMock.arguments("CloseElementSchoolDueToAFire","LabWindow", 1).getParams()[0]);
		}

        [Fact]
        public void ShouldCloseAllLabWindowsWhenFireIsDeclared()
        {
            //Arrange
            var schoolAdminMock = new SchoolAdminMock();
			var windowsToClose = new List<string> { "LabWindow1", "LabWindow2", "LabWindow3" };

            //Act
            schoolAdminMock.CloseElementsSchoolDueToAFire(windowsToClose);

            //Assert
            Assert.Equal(3, schoolAdminMock.invocation("CloseElementSchoolDueToAFire"));
            Assert.Equal("LabWindow1", schoolAdminMock.arguments("CloseElementSchoolDueToAFire", "LabWindow1", 1).getParams()[0]);
            Assert.Equal("LabWindow2", schoolAdminMock.arguments("CloseElementSchoolDueToAFire", "LabWindow2", 1).getParams()[0]);
            Assert.Equal("LabWindow3", schoolAdminMock.arguments("CloseElementSchoolDueToAFire", "LabWindow3", 1).getParams()[0]);
        }
    }
}

