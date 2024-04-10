namespace DotNetOOPMasterClass.InterfaceSegregation
{
    public class Program
    {
        public static void Main()
        {
            Employee employee = new();
            Manager manager = new();

            Console.WriteLine($"Employee: \nLogAttendance() => {employee.LogAttendance()}\n");
            Console.WriteLine($"Manager: \nLogAttendance() => {manager.LogAttendance()}");
            Console.WriteLine($"ApproveLeaveRequest() => {manager.ApproveLeaveRequest()}");
        }
    }

    public interface IEmployee
    {
        string LogAttendance();
    }

    public interface IManager
    {
        string ApproveLeaveRequest();
    }

    public class Employee : IEmployee
    {
        public string LogAttendance()
        {
            return "Employee attendance logged";
        }
    }

    public class Manager : IEmployee, IManager
    {
        public string ApproveLeaveRequest()
        {
            return "Leave request approved by Manager.";
        }

        public string LogAttendance()
        {
            return "Manager attendace logged.";
        }
    }
}