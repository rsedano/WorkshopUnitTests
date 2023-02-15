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
                return "A";
            else if (mark > 70)
                return "A";
            else if (mark > 50)
                return "A";
            else
                return "Fail";
		}
	}
}

