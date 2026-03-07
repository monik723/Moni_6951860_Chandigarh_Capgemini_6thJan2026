namespace Number_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers:");
            int[] input1 = Console.ReadLine().Split(',').Select(x => int.Parse(x.Trim())).ToArray();
            Console.WriteLine("Enter array elements:");
            int[] input2 = Console.ReadLine().Split(',').Select(x => int.Parse(x.Trim())).ToArray();
            Dictionary<int, int> result = new Dictionary<int, int>();
            for(int i=0; i<input1.Length; i++)
            {
                int sum = 0;
                for(int j=0; j<input2.Length; j++)
                {
                    if (input2[j] == input1[i]) sum += input2[j];
                }
                result.Add(input1[i], sum);
            }
            foreach(var i in result)
            {
                Console.WriteLine(i.Key+"-"+i.Value);
            }
        }
    }
}
