namespace DotNetOOPMasterClass.InheritanceDemo
{
    public class Program
    {
        public static void Main()
        {
            var employeeObject = GetEmployee();

            string printEmployeeObject = PrintEmployeeDetails(employeeObject);

            Console.WriteLine(printEmployeeObject);
        }

        public static string PrintEmployeeDetails(Employee obj)
        {
            return
                $"=============================\n" +
                $"Inheritance Demo\n" +
                $"=============================\n" +
                $"First Name: {obj.FirstName}\n" +
                $"Last Name: {obj.LastName}\n" +
                $"Employee ID: {obj.EmployeeId}\n" +
                $"Company Name: {obj.CompanyName}\n" +
                $"Employee Role: {obj.Role}";
        }

        public static Employee GetEmployee()
        {
            return new()
            {
                FirstName = "John",
                LastName = "Doe",
                EmployeeId = 411,
                CompanyName = "ABC Solutions",
                Role = "Developer"
            };
        }
    }

    public class Person
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }

    public class Employee : Person
    {
        public int EmployeeId { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
