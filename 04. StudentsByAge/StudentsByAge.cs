namespace _04.StudentsByAge
{
    using System;
    using System.Linq;
    using _01.Student;

    class StudentsByAge
    {
        static void Main()
        {
            var students = new StudentsList();

            var youngStudents = students.Students
                .Where(st => st.Age >= 18 && st.Age <= 24)
                .Select(st => new
                    {
                        st.FirstName,
                        st.LastName,
                        st.Age
                    });

            foreach (var youngStudent in youngStudents)
            {
                Console.WriteLine("First name: {0}", youngStudent.FirstName);
                Console.WriteLine("Last name: {0}", youngStudent.LastName);
                Console.WriteLine("Age: {0}\r\n", youngStudent.Age);
            }
        }
    }
}
