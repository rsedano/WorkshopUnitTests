using System;
namespace CodeExample
{
	public class Student
	{
		string name;
		string surname;
		int age;
		public Student(string name, string surname, int age)
		{
			this.name = name;
			this.surname = surname;
			this.age = age;
		}

		public void enrollToClass(IMailService mailService, SchoolClass schoolClass)
		{
			// Should do a lot of more stuff
			mailService.sendConfirmationMessage(schoolClass.name);
		}
	}
}

