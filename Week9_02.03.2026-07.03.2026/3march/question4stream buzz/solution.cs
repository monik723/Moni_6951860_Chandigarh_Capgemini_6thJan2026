using System;
using System.Collections.Generic;

public class CreatorStats
{
    public string CreatorName { get; set; }
    public double[] WeeklyLikes { get; set; }
}

public class Program
{
    public static List<CreatorStats> EngagementBoard = new List<CreatorStats>();

    public void RegisterCreator(CreatorStats record)
    {
        EngagementBoard.Add(record);
    }

    public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();
        bool anyMatch = false;

        foreach (var creator in records)
        {
            int count = 0;

            foreach (var likes in creator.WeeklyLikes)
            {
                if (likes >= likeThreshold)
                {
                    count++;
                    anyMatch = true;
                }
            }

            if (count > 0)
            {
                result[creator.CreatorName] = count;
            }
        }

        if (!anyMatch)
        {
            return new Dictionary<string, int>();
        }

        return result;
    }

    public double CalculateAverageLikes()
    {
        double sum = 0;
        int count = 0;

        foreach (var creator in EngagementBoard)
        {
            foreach (var likes in creator.WeeklyLikes)
            {
                sum += likes;
                count++;
            }
        }

        if (count == 0)
            return 0;

        return sum / count;
    }

    public static void Main(string[] args)
    {
        Program p = new Program();
        int choice;

        do
        {
            Console.WriteLine("1. Register Creator");
            Console.WriteLine("2. Show Top Posts");
            Console.WriteLine("3. Calculate Average Likes");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your choice:");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreatorStats cs = new CreatorStats();
                    Console.WriteLine("Enter Creator Name:");
                    cs.CreatorName = Console.ReadLine();

                    cs.WeeklyLikes = new double[4];
                    Console.WriteLine("Enter weekly likes (Week 1 to 4):");

                    for (int i = 0; i < 4; i++)
                    {
                        cs.WeeklyLikes[i] = double.Parse(Console.ReadLine());
                    }

                    p.RegisterCreator(cs);
                    Console.WriteLine("Creator registered successfully");
                    break;

                case 2:
                    Console.WriteLine("Enter like threshold:");
                    double threshold = double.Parse(Console.ReadLine());

                    var result = p.GetTopPostCounts(EngagementBoard, threshold);

                    if (result.Count == 0)
                    {
                        Console.WriteLine("No top-performing posts this week");
                    }
                    else
                    {
                        foreach (var item in result)
                        {
                            Console.WriteLine(item.Key + " - " + item.Value);
                        }
                    }
                    break;

                case 3:
                    double avg = p.CalculateAverageLikes();
                    Console.WriteLine("Overall average weekly likes: " + avg);
                    break;

                case 4:
                    Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
                    break;
            }

        } while (choice != 4);
    }
}