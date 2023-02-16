using System;
using CodeExample.Interfaces;

namespace CodeExample
{
	public class SchoolClass: ISchoolClass
	{
        readonly List<Student> students;
        readonly List<Teacher> teachers = new List<Teacher>();

        public string name { get; set; }

		public SchoolClass(string name, List<Student> students, List<Teacher> teachers)
		{
			this.name = name;
			this.students = students;
            this.teachers = teachers;
        }

        public void addStudentToSchoolClass(Student student)
        {
			students.Add(student);
		}

		public int numberOfStudents()
		{
			return students.Count;
		}

        public void addTeacherToSchoolClass(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public int numberOfTeachers()
        {
            return teachers.Count;
        }
    }
}

