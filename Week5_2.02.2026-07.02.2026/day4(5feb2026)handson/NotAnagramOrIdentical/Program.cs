namespace NotAnagramOrIdentical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter words separated by commas: ");
            string? input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            string[] words = input.Split(',', StringSplitOptions.RemoveEmptyEntries)
                                  .Select(w => w.Trim().ToLower())
                                  .ToArray();

            if (words.Length < 2)
            {
                Console.WriteLine("At least two words required.");
                return;
            }

            string firstSorted = SortString(words[0]);
            bool allAnagrams = words.All(w => SortString(w) == firstSorted);

            Console.WriteLine(allAnagrams ? "true" : "false");
        }

        static string SortString(string s)
        {
            return new string(s.OrderBy(c => c).ToArray());
        }
    }
    
}
