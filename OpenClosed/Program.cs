namespace DotNetOOpMasterClass.OpenClosed
{
    public class Program
    {
        public static void Main()
        {
            StandardShipping standardShipping = new();
            ExpressShipping expressShipping = new();

            OrderProcessor orderProcessor = new();

            Order order1 = new(1, 2000);
            Order order2 = new(2, 3000);

            var orderShipping1 = orderProcessor.ProcessOrder(order1, standardShipping);
            var orderShipping2 = orderProcessor.ProcessOrder(order2, expressShipping);

            var output =
                $"=================================\n" +
                $"Open/Closed Principle Demo\n" +
                $"=================================\n" +
                $"Order 1:\nTotal: R {order1.TotalAmount:0.0}\nShipping Fee: R {orderShipping1:0.0}\n\n" +
                $"Order 2:\nTotal: R {order2.TotalAmount:0.0}\nShipping Fee: R {orderShipping2:0.0}\n";

            Console.WriteLine(output);
        }
    }

    public class Order(int id, double amount)
    {
        public int OrderId { get; set; } = id;
        public double TotalAmount { get; set; } = amount;
    }

    public class OrderProcessor
    {
        public double ProcessOrder(Order order, IShippingCalculator shippingCalculator)
        {
            return shippingCalculator.CalculateShipping(order);
        }
    }

    public interface IShippingCalculator
    {
        double CalculateShipping(Order order);
    }

    public class StandardShipping : IShippingCalculator
    {
        public double CalculateShipping(Order order)
        {
            return order.TotalAmount * 0.1;
        }
    }

    public class ExpressShipping : IShippingCalculator
    {
        public double CalculateShipping(Order order)
        {
            return order.TotalAmount * 0.2;
        }
    }
}