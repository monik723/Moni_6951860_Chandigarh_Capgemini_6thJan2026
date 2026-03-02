using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Patient> patientList = new List<Patient>();
        PatientBO bo = new PatientBO();

        Console.WriteLine("Enter the number of patients");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Enter patient " + i + " details:");
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the illness");
            string illness = Console.ReadLine();

            Console.WriteLine("Enter the city");
            string city = Console.ReadLine();

            patientList.Add(new Patient(name, age, illness, city));
        }

        string choice = "Yes";

        while (choice.Equals("Yes", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Enter your choice:");
            Console.WriteLine("1)Display Patient Details");
            Console.WriteLine("2)Display Youngest Patient Details");
            Console.WriteLine("3)Display Patients from City");

            int ch = int.Parse(Console.ReadLine());

            if (ch == 1)
            {
                Console.WriteLine("Enter patient name:");
                string pname = Console.ReadLine();
                bo.DisplayPatientDetails(patientList, pname);
            }
            else if (ch == 2)
            {
                bo.DisplayYoungestPatientDetails(patientList);
            }
            else if (ch == 3)
            {
                Console.WriteLine("Enter city");
                string city = Console.ReadLine();
                bo.DisplayPatientsFromCity(patientList, city);
            }

            Console.WriteLine("Do you want to continue(Yes/No)?");
            choice = Console.ReadLine();
        }
    }
}
