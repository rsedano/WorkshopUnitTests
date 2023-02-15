namespace UnitTests.Fake
{
    public class FakeStudentRepository: IStudentRepository
    {
        List<Student> students;
        public FakeStudentRepository() {
            students = new List<Student>();
        }

        public void addStudent(Student student)
        {
            //We don't interact with a database, just use memory
            students.Add(student);
        }

        public Student getStudentByName(string name)
        {
            foreach (var student in students)
            {
                if (student.Equals(name))
                {
                    return student;
                }
            };

            return null;
        }

        public List<Student> getStudents()
        {
            return students;
        }
    }
}

