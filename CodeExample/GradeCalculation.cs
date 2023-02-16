using System;
namespace CodeExample
{
  public static class GradeCalculation
  {
    public static string getGrade(int mark)
    {
      if (mark > 90)
        return "A";
      else if (mark > 80)
        return "B";
      else if (mark > 70)
        return "C";
      else if (mark > 50)
        return "D";
      else
        return "Fail";
    }
  }
}
