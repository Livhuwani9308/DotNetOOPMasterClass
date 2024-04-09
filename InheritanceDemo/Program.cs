namespace DotNetOOPMasterClass.InheritanceDemo
{
    public class Program
    {
        public static void Main()
        {
            Employee employee = new()
            {
                FirstName = "John",
                LastName = "Doe",
                EmployeeId = 411,
                CompanyName = "ABC Solutions",
                Role = "Developer"
            };

            string output =
                $"=============================\n" +
                $"Inheritance Demo\n" +
                $"=============================\n" +
                $"First Name: {employee.FirstName}\n" +
                $"Last Name: {employee.LastName}\n" +
                $"Employee ID: {employee.EmployeeId}\n" +
                $"Company Name: {employee.CompanyName}\n" +
                $"Employee Role: {employee.Role}";

            Console.WriteLine(output);
        }
    }

    class Person
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }

    class Employee : Person
    {
        public int EmployeeId { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
