namespace SumofCoupleInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size: ");
            int n=int.Parse(Console.ReadLine());
            int[] arr= new int[n];
            int count = 0;
            Console.WriteLine("Enter elements:");
            for(int i=0; i<n; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            for(int i=0;i<arr.Length-1; i++)
            {
                if ((arr[i] + arr[i + 1]) % n == 0) { count++; }
            }
            Console.WriteLine(count);
        }
    }
}
