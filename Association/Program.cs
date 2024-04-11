namespace DotNetOOPMasterClass.ClassRelations.Association
{
    public class Program
    {
        public static void Main()
        {
            var studentObject = GetStudent();

            var displayStudentObject = PrintStudentDetails(studentObject);

            Console.WriteLine(displayStudentObject);
        }

        public static Student GetStudent()
        {
            return new()
            {
                StudentId = 123456,
                FirstName = "Livhuwani",
                LastName = "Masindi",
                CampusName = "TUT Campus",
                CourseName = "Software Development",
                CourseCode = "NDISF1"
            };
        }

        public static string PrintStudentDetails(Student obj)
        {
            return
                $"==================================\n" +
                $"Student Details\n" +
                $"==================================\n" +
                $"Student Id: {obj.StudentId}\n" +
                $"First Name: {obj.FirstName}\n" +
                $"Last Name: {obj.LastName}\n" +
                $"Campus Name: {obj.CampusName}\n" +
                $"Coourse Name: {obj.CourseName}\n" +
                $"Course Code: {obj.CourseCode}";
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string CampusName { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public string CourseCode { get; set; } = string.Empty;
    }
}