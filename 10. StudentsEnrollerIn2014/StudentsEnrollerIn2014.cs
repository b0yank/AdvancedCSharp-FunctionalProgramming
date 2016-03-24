namespace _10.StudentsEnrollerIn2014
{
    using System;
    using System.Linq;
    using _01.Student;

    class StudentsEnrollerIn2014
    {
        static void Main()
        {
            var students = new StudentsList().Students;

            var secondYearStudentsMarks = students
                .Where(st => st.FacultyNumber[4] == '1' && st.FacultyNumber[5] == '4')
                .Select(st => st.Marks);

            foreach (var studentMarks in secondYearStudentsMarks)
            {
                Console.WriteLine(string.Join(", ", studentMarks));
            }
        }
    }
}
