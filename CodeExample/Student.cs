using System;
using CodeExample.Interfaces;

namespace CodeExample
{
	public class Student
	{
		string name;
		string surname;
		int age;
		string? studentEmail;
		string contactEmail;
		public Student(string name, string surname, int age, string? studentEmail, string contactEmail)
		{
			this.name = name;
			this.surname = surname;
			this.age = age;
			this.studentEmail = studentEmail;
			this.contactEmail = contactEmail;
		}

		public void enrollToClass(IMailService mailService, SchoolClass schoolClass)
		{
			// Should do a lot of more stuff
			string emailTo;
			if (this.studentEmail != null)
				emailTo = this.studentEmail;
			if (this.studentEmail != null)
                emailTo = this.contactEmail;
			else
				return;

            mailService.sendConfirmationMessage(emailTo, schoolClass.name);
		}
	}
}

