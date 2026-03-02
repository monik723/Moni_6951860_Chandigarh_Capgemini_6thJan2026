using System;

class MultipleOfFive
{
    public double CalculateAvg(int[] arr, int size)
    {
        
        if (size < 0)
        {
            return -2;
        }

        
        for (int i = 0; i < size; i++)
        {
            if (arr[i] < 0)
            {
                return -1;
            }
        }

        int sum = 0;
        int count = 0;

        for (int i = 0; i < size; i++)
        {
            if (arr[i] % 5 == 0)
            {
                sum += arr[i];
                count++;
            }
        }

        if (count == 0)
        {
            return 0; 
        }

        double avg = (double)sum / count;
        return avg;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        MultipleOfFive obj = new MultipleOfFive();
        double result = obj.CalculateAvg(arr, size);

        Console.WriteLine("Output = " + result);
    }
}
