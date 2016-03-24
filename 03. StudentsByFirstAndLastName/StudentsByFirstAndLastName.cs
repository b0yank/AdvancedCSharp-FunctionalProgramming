namespace _03.StudentsByFirstAndLastName
{
    using System;
    using System.Linq;
    using _01.Student;

    class StudentsByFirstAndLastName
    {
        static void Main()
        {
            var students = new StudentsList();

            var studentsByName =
                students.Students.Where(
                    student => String.CompareOrdinal(student.FirstName, student.LastName) < 0);

            foreach (var student in studentsByName)
            {
                Console.WriteLine(student);
            }
        }
    }
}
