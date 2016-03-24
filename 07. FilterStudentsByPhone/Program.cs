namespace _07.FilterStudentsByPhone
{
    using System;
    using System.Linq;
    using _01.Student;

    class Program
    {
        static void Main()
        {
            var students = new StudentsList().Students;

            var studentsByPhone =
                students.Where(
                    st => st.Phone.StartsWith("02") || 
                        st.Phone.StartsWith("+3592") || 
                        st.Phone.StartsWith("+359 2"));

            foreach (var student in studentsByPhone)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
        }
    }
}
