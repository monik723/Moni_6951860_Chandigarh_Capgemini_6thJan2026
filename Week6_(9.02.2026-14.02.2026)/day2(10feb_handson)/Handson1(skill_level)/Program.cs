using System;
using System.Linq;

class Solution
{
    public static int MaxTeamStrength(int[] skills, int[] teamSizes)
    {
        // Step 1: Sort skills and team sizes
        Array.Sort(skills);
        Array.Sort(teamSizes);

        int left = 0;                    // smallest skill index
        int right = skills.Length - 1;   // largest skill index
        int totalStrength = 0;

        // Step 2: Form teams
        foreach (int size in teamSizes)
        {
            int maxSkill = skills[right];   // take highest skill
            right--;

            int minSkill = skills[left];    // take lowest skill

            // consume remaining (size - 1) employees
            left += (size - 1);

            totalStrength += (minSkill + maxSkill);
        }

        return totalStrength;
    }

    public static void Main()
    {
        int[] skills = { 1, 2, 3, 4, 5, 6 };
        int[] teamSizes = { 2, 4 };

        int result = MaxTeamStrength(skills, teamSizes);
        Console.WriteLine("Maximum Total Team Strength: " + result);
    }
}
