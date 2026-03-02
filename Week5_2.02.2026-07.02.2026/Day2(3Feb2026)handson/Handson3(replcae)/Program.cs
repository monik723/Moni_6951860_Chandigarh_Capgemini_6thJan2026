using System;
using System.Text.RegularExpressions;

class InvoiceUpdate
{
    static void Main()
    {
        Console.WriteLine("Enter current invoice number:");
        string invoice = Console.ReadLine();   // e.g. CAP-HYD-1234

        Console.WriteLine("Enter new location code:");
        string newLocation = Console.ReadLine(); // e.g. BAN

        // Regex pattern:
        // Group 1: CAP-
        // Group 2: Location code (LOC)
        // Group 3: -XXXX (numeric part)
        string pattern = @"^(CAP-)([A-Z]{3})(-\d+)$";

        string updatedInvoice = Regex.Replace(
            invoice,
            pattern,
            "$1" + newLocation + "$3"
        );

        Console.WriteLine("Updated invoice number:");
        Console.WriteLine(updatedInvoice);
    }
}
