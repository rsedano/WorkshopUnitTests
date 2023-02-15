using NSubstitute;

namespace UnitTests.Mock
{
	public class SchoolAdminTest
	{
		[Fact]
		public void ShouldCloseLabWindowWhenFireIsDeclared()
		{
			//Arrange
			var elementToClose = "LabWindow";
			var schoolBuilding = Substitute.For<ISchoolBuilding>();
			var schoolAdmin = new SchoolAdmin("Obi-Wan", "Kenobi", schoolBuilding);
			var elementStatusExpected = new elementStatus { elementName = elementToClose, status = "closed" };

			schoolBuilding.Close(Arg.Is<string>(elementToClose)).Returns<string>("closed");

			//Act
			var elementStatus = schoolAdmin.CloseElementSchoolDueToAFire(elementToClose);

            //Assert
            schoolBuilding.Received(1).Close(Arg.Is(elementToClose));
            schoolBuilding.DidNotReceive().Open(Arg.Is(elementToClose));
            Assert.Equal(elementStatusExpected, elementStatus);
        }

        [Fact]
        public void ShouldCloseLabWindowsWhenFireIsDeclared()
        {
            //Arrange
            var labWindow1Name = "LabWindow1";
            var labWindow2Name = "LabWindow2";
            var labWindow3Name = "LabWindow3";

            var elementsToClose = new List<string> { labWindow1Name, labWindow2Name, labWindow3Name };
            var schoolBuilding = Substitute.For<ISchoolBuilding>();
            var schoolAdmin = new SchoolAdmin("Obi-Wan", "Kenobi", schoolBuilding);

            var elementStatusExpected = new elementStatus { elementName = labWindow1Name, status = "closed" };

            schoolBuilding.Close(Arg.Is<string>(labWindow1Name)).Returns<string>("closed");
            schoolBuilding.Close(Arg.Is<string>(labWindow2Name)).Returns<string>("closed");
            schoolBuilding.Close(Arg.Is<string>(labWindow3Name)).Returns<string>("closed");

            //Act
            schoolAdmin.CloseElementsSchoolDueToAFire(elementsToClose);

            //Assert
            schoolBuilding.Received(3).Close(Arg.Any<string>());
            schoolBuilding.DidNotReceive().Open(Arg.Is(labWindow1Name));
        }

        [Fact]
        public void FailureToCloseLabWindowsWhenFireIsDeclared()
        {
            //Arrange
            var elementToClose = "LabWindow";
            var schoolBuilding = Substitute.For<ISchoolBuilding>();
            var schoolAdmin = new SchoolAdmin("Obi-Wan", "Kenobi", schoolBuilding);
            var elementStatusExpected = new elementStatus { elementName = elementToClose, status = "failure" };

            schoolBuilding.Close(Arg.Is<string>(elementToClose)).Returns(x => { throw new Exception(); });

            //Act
            var elementStatus = schoolAdmin.CloseElementSchoolDueToAFire(elementToClose);

            //Assert
            schoolBuilding.Received(1).Close(Arg.Is(elementToClose));
            schoolBuilding.DidNotReceive().Open(Arg.Is(elementToClose));
            Assert.Equal(elementStatusExpected, elementStatus);
        }
    }
}

