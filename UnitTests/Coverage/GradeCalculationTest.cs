using System;
namespace UnitTests.Coverage
{
  public class GradeCalculationTest
  {
    [Fact]
    public void GetGradeA()
    {
      //Arrange
      int mark = 91;
      string expectedGrade = "A";

      //Act
      var grade = GradeCalculation.getGrade(mark);

      //Assert
      Assert.Equal(expectedGrade, grade);
    }
    [Fact]
    public void GetGradeB()
    {
      //Arrange
      int mark = 81;
      string expectedGrade = "B";

      //Act
      var grade = GradeCalculation.getGrade(mark);

      //Assert
      Assert.Equal(expectedGrade, grade);
    }
    [Fact]
    public void GetGradeC()
    {
      //Arrange
      int mark = 71;
      string expectedGrade = "C";

      //Act
      var grade = GradeCalculation.getGrade(mark);

      //Assert
      Assert.Equal(expectedGrade, grade);
    }
    [Fact]
    public void GetGradeD()
    {
      //Arrange
      int mark = 61;
      string expectedGrade = "D";

      //Act
      var grade = GradeCalculation.getGrade(mark);

      //Assert
      Assert.Equal(expectedGrade, grade);
    }
    [Fact]
    public void GetGradeF()
    {
      //Arrange
      int mark = 41;
      string expectedGrade = "Fail";

      //Act
      var grade = GradeCalculation.getGrade(mark);

      //Assert
      Assert.Equal(expectedGrade, grade);
    }
  }
}
