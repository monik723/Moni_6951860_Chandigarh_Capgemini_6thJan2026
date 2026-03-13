namespace SumofDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int n=int.Parse(Console.ReadLine());
            int sum = 0;
            while (n > 0)
            {
                int x = n % 10;
                sum = sum + x;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
