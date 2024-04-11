namespace DotNetOOPMasterClass.EncapsulationDemo
{
    public class Program
    {
        public static void Main()
        {
            var userObject = GetUserDetails();

            Console.WriteLine(userObject.PrintUserDetails());
        }

        public static Encapsulation GetUserDetails()
        {
            return new()
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 33
            };
        }
    }

    public class Encapsulation
    {
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private int _age;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string PrintUserDetails()
        {
            return
                $"===================\n" +
                $"Encapsulation Demo\n" +
                $"===================\n" +
                $"First Name: {FirstName}\n" +
                $"Last Name: {LastName}\n" +
                $"Age: {Age}";
        }
    }
}