namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.WriteLine($"Addition: {calc.Add(10, 2)}");
            Console.WriteLine($"Subtraction: {calc.Subtract(10, 2)}");
            Console.WriteLine($"Multiplication: {calc.Multiply(10, 2)}");
            Console.WriteLine($"Divition: {calc.Division(10, 2)}");
        }
    }
}
