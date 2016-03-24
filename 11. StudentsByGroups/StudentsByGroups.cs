namespace _11.StudentsByGroups
{
    using System;
    using System.Linq;
    using _01.Student;

    class StudentsByGroups
    {
        static void Main()
        {
            var students = new StudentsList().Students;

            var groupedStudents = students.GroupBy(st => st.GroupName);

            foreach (var group in groupedStudents)
            {
                Console.WriteLine("Group: {0}", group.Key);
                Console.WriteLine(new string('=', 20));

                foreach (var student in group)
                {
                    Console.WriteLine(student);
                }
            }
        }
    }
}
