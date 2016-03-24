namespace _09.WeakStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using _01.Student;

    public static class WeakStudents
    {
        static void Main()
        {
            var students = new StudentsList().Students;

            var weakStudents = students.GetWeakStudents();

            foreach (var weakStudent in weakStudents)
            {
                Console.WriteLine(weakStudent);
            }
        }

        public static IEnumerable<T> GetWeakStudents<T>(this IEnumerable<T> source)
            where T : Student
        {
            var weakStudents = source.Where(st =>
            {
                return st.Marks
                    .Count(mark => mark == 2) == 2;
            });

            return weakStudents;
        }
    }
}
