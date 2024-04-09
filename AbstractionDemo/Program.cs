namespace DotNetOOPMasterClass.AbstractionDemo
{
    public class Program
    {
        public static void Main()
        {
            Triangle triangle = new(22, 4);
            Circle circle = new(6);
            Square square = new(10);

            string output =
                $"=================================\n" +
                $"Abstraction Demo\n" +
                $"=================================\n" +
                $"Calculation for triangle: {triangle.Area()} cm\n" +
                $"Calculation for circle: {Math.Round(circle.Area(), 2)} cm\n" +
                $"Calculation fro square: {square.Area()} cm";

            Console.WriteLine(output);
        }
    }

    public abstract class IShape
    {
        public abstract double Area();
    }

    public class Circle(double radius) : IShape
    {
        public double Radius { get; set; } = radius;

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Triangle(double tbase, double height) : IShape
    {
        public double Tbase { get; set; } = tbase;
        public double Height { get; set; } = height;

        public override double Area()
        {
            return 0.5 * Height * Tbase;
        }
    }

    public class Square(double side) : IShape
    {
        public double Side { get; set; } = side;

        public override double Area()
        {
            return Side * Side;
        }
    }
}