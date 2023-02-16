using System;
namespace UnitTests.Coverage
{
	public class GradeCalculationTest
	{
		[Fact]
		public void GetGradeA()
		{
			//Arrange
			int mark = 90;
			string expectedGrade = "A";

			//Act
			var grade = GradeCalculation.getGrade(mark);

			//Assert
			Assert.Equal(expectedGrade, grade);
		}
	}
}

