namespace NearestSquarenumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num=int.Parse(Console.ReadLine());
            int sq = 1;
            int mindiff = num;
            int i = 0;
            List<int> list = new List<int>();
            while (true)
            {
                int diff = sq * sq > num ? sq * sq - num : num - sq * sq;
                if (mindiff > diff) { mindiff = diff; }
                //if (mindiff == diff) { break; }
                //int i = 0;
                list.Add(mindiff);
                if (list.Count > 1)
                {
                    if (list[i] == list[i + 1]) { sq--; break; }
                    else { i++; }
                }

                sq++;

            }
            Console.WriteLine(sq * sq);
        }
    }
}
