namespace DotNetMasterClass.ClassRelations.Composition
{
    public class Program
    {
        public static void Main()
        {
            var personObject = GetPerson();

            var displayPersonObject = PrintPersonDetails(personObject);

            Console.WriteLine(displayPersonObject);
        }

        public static string PrintPersonDetails(Person obj)
        {
            return
                $"=======================\n" +
                $"Person Details\n" +
                $"=======================\n" +
                $"Person:\n" +
                $"-----------------------\n" +
                $"First Name: {obj.FirstName}\n" +
                $"Last Name: {obj.LastName}\n\n" +
                $"Vehicle:\n" +
                $"-----------------------\n" +
                $"Vin: {obj.Vehicle.Vin}\n" +
                $"Make: {obj.Vehicle.Make}\n" +
                $"Model: {obj.Vehicle.Model}\n" +
                $"Year: {obj.Vehicle.Year.Year}";
        }

        public static Person GetPerson()
        {
            return new()
            {
                FirstName = "John",
                LastName = "Doe",
                Vehicle = new()
                {
                    Vin = "PWNF1234",
                    Make = "Mercedes Benz",
                    Model = "W201",
                    Year = new DateTime(1993, 1, 1)
                }
            };
        }
    }

    public class Person
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public Vehicle Vehicle { get; set; } = new Vehicle();
    }

    public class Vehicle
    {
        public string Vin { get; set; } = string.Empty;
        public string Make { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public DateTime Year { get; set; }
    }
}