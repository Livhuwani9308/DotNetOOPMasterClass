namespace DotNetOOPMasterClass.LiskovSubstitution
{
    public class Program
    {
        public static void Main()
        {
            Employee developer = new Developer();
            Employee manager = new Manager();

            HR hr = new();

            var output =
                $"===================================\n" +
                $"Liskov Substitution Principle Demo\n" +
                $"===================================\n" +
                $"Role 1:\n" +
                $"{hr.AssignRole(developer)}\n\n" +
                $"Role 2:\n" +
                $"{hr.AssignRole(manager)}";

            Console.WriteLine(output);
        }
    }

    public abstract class Employee
    {
        public abstract string GetRole();
        public abstract string PerformRoleSpecificTask();
    }

    public class Developer : Employee
    {
        public override string GetRole()
        {
            return "Developer";
        }

        public override string PerformRoleSpecificTask()
        {
            return "Writing code";
        }
    }

    public class Manager : Employee
    {
        public override string GetRole()
        {
            return "Manager";
        }

        public override string PerformRoleSpecificTask()
        {
            return "Managing the team";
        }
    }

    public class HR
    {
        public string AssignRole(Employee employee)
        {
            return
                $"Role: {employee.GetRole()}\nTask: {employee.PerformRoleSpecificTask()}";
        }
    }
}