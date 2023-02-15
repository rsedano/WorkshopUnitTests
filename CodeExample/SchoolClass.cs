using System;
namespace CodeExample
{
	public class SchoolClass
	{
        List<Student> students;

        public string name { get; set; }

		public SchoolClass(string name, List<Student> students)
		{
			this.name = name;
			this.students = students;
		}
        public void addStudentToSchoolClass(Student student)
        {
			students.Add(student);
		}

		public int numberOfStudents()
		{
			return students.Count;
		}
    }
}

