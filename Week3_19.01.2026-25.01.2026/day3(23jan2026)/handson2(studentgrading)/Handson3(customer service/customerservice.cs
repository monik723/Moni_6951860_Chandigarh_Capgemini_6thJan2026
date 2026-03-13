using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Queue for incoming tickets
        Queue<string> tickets = new Queue<string>();
        tickets.Enqueue("Ticket 1");
        tickets.Enqueue("Ticket 2");
        tickets.Enqueue("Ticket 3");

        // Stack for agent actions (undo)
        Stack<string> actions = new Stack<string>();

        // Process 3 tickets
        for (int i = 0; i < 3; i++)
        {
            string t = tickets.Dequeue();
            Console.WriteLine("Processing " + t);

            actions.Push("Reply sent for " + t);
            actions.Push("Status updated for " + t);
        }

        // Undo last action
        Console.WriteLine("\nUndo: " + actions.Pop());

        // Show remaining tickets
        Console.WriteLine("\nRemaining Tickets in Queue:");
        foreach (var t in tickets)
            Console.WriteLine(t);
    }
}
