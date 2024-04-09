namespace DotNetOOPMasterClass.EncapsulationDemo
{
    public class Program
    {
        public static void Main()
        {
            Encapsulation obj = new()
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 33
            };

            Console.WriteLine(obj.PrintUserDetails());
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
            return string.Format($"First Name: {FirstName}\nLast Name: {LastName}\nAge: {Age}");
        }
    }
}