using System;

class UserProgramCode
{
    public static int CheckVotingEligibility(int age)
    {
        if (age >= 18)
            return 1;   // Eligible
        else
            return -1;  // Not Eligible
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your age:");
        string input = Console.ReadLine();

        // Convert input to integer safely
        int age;
        if (int.TryParse(input, out age))
        {
            int result = UserProgramCode.CheckVotingEligibility(age);

            if (result == 1)
                Console.WriteLine("You are eligible to vote.");
            else
                Console.WriteLine("You are not eligible to vote.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer age.");
        }
    }
}
