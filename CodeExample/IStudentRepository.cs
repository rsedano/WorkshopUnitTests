using System;
namespace CodeExample
{
	public interface IStudentRepository
	{
		public void addStudent(Student student);
		public Student getStudentByName(string name);
		public List<Student> getStudents();

    }
}

