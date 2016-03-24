namespace _02.StudentByGroup
{
    using System;
    using System.Linq;
    using _01.Student;

    class StudentsByGroup
    {
        static void Main()
        {
            var students = new StudentsList();

            var studentsByGroup = students.Students
                .Where(student => student.GroupNumber == 2)
                .OrderBy(st => st.FirstName);

            Console.WriteLine(string.Join("\r\n", studentsByGroup));
        }
    }
}
