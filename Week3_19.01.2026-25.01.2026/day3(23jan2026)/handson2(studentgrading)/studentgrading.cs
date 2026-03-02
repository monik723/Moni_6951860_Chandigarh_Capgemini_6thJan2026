using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<int, int> grades = new Dictionary<int, int>()
        {
            {101, 80},
            {102, 45},
            {103, 60},
            {104, 35}
        };

        // Func to calculate average
        Func<double> avg = () => grades.Values.Average();
        Console.WriteLine("Average Grade = " + avg());

        // Predicate to find risk students
        Predicate<int> isRisk = g => g < 40;

        Console.WriteLine("\nStudents at Risk:");
        foreach (var s in grades)
            if (isRisk(s.Value))
                Console.WriteLine("Roll: " + s.Key + " Grade: " + s.Value);

        // Update a student's grade
        grades[104] = 55;

        Console.WriteLine("\nAfter Updating Roll 104:\nStudents at Risk:");
        foreach (var s in grades)
            if (isRisk(s.Value))
                Console.WriteLine("Roll: " + s.Key + " Grade: " + s.Value);
    }
}
