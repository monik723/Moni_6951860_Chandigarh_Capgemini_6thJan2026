using System;
using System.Collections.Generic;

public class PatientBO
{
    public void DisplayPatientDetails(List<Patient> patientList, string name)
    {
        bool found = false;

        foreach (Patient p in patientList)
        {
            if (p.Name.Equals(name))
            {
                if (!found)
                {
                    Console.WriteLine("Name                 Age   Illness          City");
                }
                Console.WriteLine(p);
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Patient named " + name + " not found");
        }
    }

    public void DisplayYoungestPatientDetails(List<Patient> patientList)
    {
        Patient youngest = patientList[0];

        foreach (Patient p in patientList)
        {
            if (p.Age < youngest.Age)
            {
                youngest = p;
            }
        }

        Console.WriteLine("The Youngest Patient Details");
        Console.WriteLine("Name                 Age   Illness          City");
        Console.WriteLine(youngest);
    }

    public void DisplayPatientsFromCity(List<Patient> patientList, string cname)
    {
        bool found = false;

        foreach (Patient p in patientList)
        {
            if (p.City.Equals(cname))
            {
                if (!found)
                {
                    Console.WriteLine("Name                 Age   Illness          City");
                }
                Console.WriteLine(p);
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("City named " + cname + " not found");
        }
    }
}
