using System;
using NSubstitute;
using UnitTests.Mock;

namespace UnitTests.Spy
{
	public class SchoolAdminSpyTest
	{
		[Fact]
		public void CloseElementsSchoolDueToAFire()
		{
            //Arrange
            var schoolBuilding = Substitute.For<ISchoolBuilding>();
            var schoolAdmin = Substitute.ForPartsOf<SchoolAdmin>("", "", schoolBuilding);
            var windowsToClose = new List<string> { "LabWindow1", "LabWindow2", "LabWindow3" };

            schoolAdmin.WhenForAnyArgs(x => x.CloseElementSchoolDueToAFire(default)).DoNotCallBase();

            //Act
            schoolAdmin.CloseElementsSchoolDueToAFire(windowsToClose);

            //Assert
            schoolAdmin.Received(1).CloseElementSchoolDueToAFire("LabWindow1");
            schoolAdmin.Received(1).CloseElementSchoolDueToAFire("LabWindow2");
            schoolAdmin.Received(1).CloseElementSchoolDueToAFire("LabWindow3");
        }
    }
}

