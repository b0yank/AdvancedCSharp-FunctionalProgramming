namespace _01.Student
{
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public Student(
            string firstName,
            string lastName,
            int age,
            string facultyNumber,
            string phone,
            string email,
            int groupNumber,
            string groupName,
            IList<int> marks = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.GroupName = groupName;

            if (marks == null)
            {
                this.Marks = new List<int>();
            }

            else
            {
                this.Marks = marks;
            }
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string FacultyNumber { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public IList<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public string GroupName { get; set; }

        public override string ToString()
        {
            var infoCollection = new List<string>(16)
            {
                string.Format("Name: {0} {1}", this.FirstName, this.LastName),
                string.Format("Age: {0}", this.Age),
                string.Format("Group number: {0}", this.GroupNumber),
                string.Format("Phone: {0}", this.Phone),
                string.Format("Email: {0}", this.Email),
                string.Format("Faculty number: {0}", this.FacultyNumber)
            };

            if (this.Marks.Any())
            {
                infoCollection.Add("Marks:");
                infoCollection.Add(string.Join(", ", this.Marks));
            }

            else
            {
                infoCollection.Add("No marks.");
            }

            var result = string.Join("\r\n", infoCollection);
            result += "\r\n";

            return result;
        }
    }
}
