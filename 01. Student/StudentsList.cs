namespace _01.Student
{
    using System.Collections.Generic;

    public class StudentsList
    {
        public StudentsList()
        {
            this.Students = new List<Student>
            {
                new Student("Koko", "Dinev", 58, "456715", "0885456654", "kdinev@yahoo.com", 1, "English", new List<int>{3, 4, 5, 2, 2}),
                new Student("Kolio", "Mamata", 63, "153714", "02654781", "kmama@abv.bg", 2, "Math", new List<int>{3, 6, 4}),
                new Student("Toni", "Storaro", 55, "413614", "0886666666", "tstoro@yahoo.com", 1, "English", new List<int>{6, 6, 6}),
                new Student("Fiki", "Storaro", 23, "161318", "0885555555", "jivotbezkraka@abv.com", 3, "Physics", new List<int>{3, 5, 5}),
                new Student("Valeri", "Bojinov", 30, "561613", "0889123456", "kittykitty@gmail.com", 3, "Physics", new List<int>{3, 3, 2, 2}),
                new Student("Stenli", "Royce", 68, "719616", "02456654", "drylife@gmail.com", 1, "English", new List<int>{5, 4, 5}),
                new Student("Bacho", "Kolio", 24, "651314", "0876139464", "batkolio@abv.bg", 2, "Math", new List<int>{6, 4, 2}),
                new Student("Dinko", "Kaloyanov", 14, "810310", "+3592573939", "dinkoman@abv.bg", 2, "Math", new List<int>{2, 2, 4}),
                new Student("Geshenk", "Stamatov", 22, "195914", "0885793710", "schinken@gmail.com", 3, "Physics", new List<int>{4, 4, 3}),
            };
        }

        public IList<Student> Students { get; set; }

        static void Main()
        {
        }
    }
}
