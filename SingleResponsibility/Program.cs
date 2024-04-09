namespace DotNetOOPMasterClass.SingleResponsibility
{
    public class Program
    {
        public static void Main()
        {
            Shape parallelogram = new Parallelogram(8, 7);
            Shape trapezoid = new Trapezoid(4, 6, 5);

            AreaCalculator calculator = new();

            var areaParallelogram = calculator.CalculateArea(parallelogram);
            var areaTrapezoid = calculator.CalculateArea(trapezoid);

            AreaPrinter printer = new();

            var output =
                $"{printer.PrintArea(parallelogram, areaParallelogram)}\n" +
                $"{printer.PrintArea(trapezoid, areaTrapezoid)}";

            Console.WriteLine(output);
        }
    }

    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Parallelogram(double @base, double height) : Shape
    {
        public double Base { get; set; } = @base;
        public double Height { get; set; } = height;

        public override double Area()
        {
            return Base * Height;
        }
    }

    public class Trapezoid(double sideA, double sideB, double height) : Shape
    {
        public double SideA { get; set; } = sideA;
        public double SideB { get; set; } = sideB;
        public double Height { get; set; } = height;

        public override double Area()
        {
            return ((SideA + SideB) / 2) * Height;
        }
    }

    public class AreaPrinter
    {
        public string PrintArea(Shape shape, double area)
        {
            return $"The area for {shape.GetType().Name} is {area} mm.";
        }
    }

    public class AreaCalculator
    {
        public double CalculateArea(Shape shape)
        {
            return shape.Area();
        }
    }
}