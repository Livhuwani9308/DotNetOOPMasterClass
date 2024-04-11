namespace DotNetOOPMasterClass.PolymorphismDemo
{
    public class Program
    {
        public static void Main()
        {
            Printer printer = new();

            var salaryModel = GetSalaryModel();

            var programmingHistory = printer.Print(1950);

            var famousQuote = printer.Print("Bjourne Stroustrup");

            var salaryDisplay = printer.Print(salaryModel);

            Console.WriteLine(printer.Print(programmingHistory, famousQuote, salaryDisplay));
        }

        public static SalaryModel GetSalaryModel()
        {
            return new()
            {
                Salary = 33000,
                Rate = 20,
                Overtime = 32
            };
        }
    }

    public class Printer
    {
        public string Print(int year)
        {
            return
                $"The history of programming dates back to the early 19th century when mathematician Ada Lovelace created an algorithm for Charles Babbage's Analytical Engine, which is considered the first computer. However, the first actual programming language was developed in the {year}s, called FORTRAN.";
        }

        public string Print(SalaryModel obj)
        {
            return
                $"Salary: R {obj.Salary:0.0}\n" +
                $"Rate: R {obj.Rate:0.0} p/hr\n" +
                $"Overtime: {obj.Overtime} hr\n" +
                $"-----------------\n" +
                $"Total: R {obj.GetWage():0.0}";
        }

        public string Print(string author)
        {
            return $"C makes it easy to shoot yourself in the foot; C++ makes it harder, but when you do, it blows away your whole leg.\n" +
                $"- {author}";
        }

        public string Print(string programmingHistory, string famousQuote, string salaryDisplay)
        {
            return
                $"==============================\n" +
                $"Polymorphism Demo\n" +
                $"==============================\n" +
                $"Example 1:\n" +
                $"{programmingHistory}\n\n" +
                $"Example 2:\n" +
                $"{famousQuote}\n\n" +
                $"Example 3:\n" +
                $"{salaryDisplay}";
        }
    }

    public class SalaryModel
    {
        public decimal Salary { get; set; }
        public decimal Rate { get; set; }
        public decimal Overtime { get; set; }

        public decimal GetWage()
        {
            return Salary + (Rate * Overtime);
        }
    }
}