namespace MaximumdeletionConsecutiveChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string str=Console.ReadLine();
            //int maxcount = 0;
            int count = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == str[i + 1])
                {
                    count++;
                    //if (maxcount <= count)
                    //{
                    //    maxcount = count;
                    //}
                    i++;

                }
            }
            Console.WriteLine(count);
        }
    }
}
