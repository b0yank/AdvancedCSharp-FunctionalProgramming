namespace _08.ExcellentStudents
{
    using System;
    using System.Linq;
    using _01.Student;

    class ExcellentStudents
    {
        static void Main()
        {
            var students = new StudentsList().Students;

            var excellentStudents = students.Where(st => st.Marks.Contains(6))
                .Select(st => new
                    {
                        FullName = st.FirstName + " " + st.LastName,
                        st.Marks
                    });

            foreach (var excellentStudent in excellentStudents)
            {
                Console.WriteLine("Full name: {0}", excellentStudent.FullName);

                Console.WriteLine("Marks: ");
                Console.WriteLine(string.Join(", ", excellentStudent.Marks));

                if (excellentStudent.Marks.Count == 0)
                {
                    Console.WriteLine("None.");
                }

                Console.WriteLine();
            }
        }
    }
}
