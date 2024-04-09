namespace DotNetOOPMasterClass.SingleResponsibility
{
    public class Program
    {
        public static void Main()
        {

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

}