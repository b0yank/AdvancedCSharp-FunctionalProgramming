namespace _05.SortStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using _01.Student;

    class SortStudents
    {
        static void Main()
        {
            var students = new StudentsList().Students;

            var sortedStudents = students
                .OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName);

            var querySortedStudents = from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            Console.WriteLine(sortedStudents.SequenceEqual(querySortedStudents));
        }
    }
}
