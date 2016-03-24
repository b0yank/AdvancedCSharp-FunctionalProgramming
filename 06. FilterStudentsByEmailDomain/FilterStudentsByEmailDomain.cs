namespace _06.FilterStudentsByEmailDomain
{
    using System;
    using System.Linq;
    using _01.Student;

    class FilterStudentsByEmailDomain
    {
        static void Main()
        {
            var students = new StudentsList().Students;

            var studentsByEmail = students.Where(st => st.Email.EndsWith("@abv.bg"));

            foreach (var student in studentsByEmail)
            {
                Console.WriteLine(student);
            }
        }
    }
}
