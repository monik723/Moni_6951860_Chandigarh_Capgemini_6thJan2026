using System;
using System.Collections.Generic;

namespace HospitalManagement
{
    // ================= BASE CLASS =================
    class Person
    {
        protected int id;
        protected string name;

        public Person(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine("ID: " + id + ", Name: " + name);
        }
    }

    // ================= PATIENT =================
    class Patient : Person
    {
        private List<MedicalRecord> medicalHistory = new List<MedicalRecord>();

        public Patient(int id, string name) : base(id, name) { }

        public void AddMedicalRecord(MedicalRecord record)
        {
            medicalHistory.Add(record);
        }

        public void ShowMedicalHistory()
        {
            Console.WriteLine("\n--- Medical History of " + name + " ---");
            if (medicalHistory.Count == 0)
            {
                Console.WriteLine("No records found.");
                return;
            }

            foreach (var record in medicalHistory)
            {
                record.Display();
            }
        }

        public override void Display()
        {
            Console.WriteLine("Patient -> ID: " + id + ", Name: " + name);
        }
    }

    // ================= DOCTOR =================
    class Doctor : Person
    {
        public string Specialization { get; set; }

        public Doctor(int id, string name, string specialization) : base(id, name)
        {
            Specialization = specialization;
        }

        public override void Display()
        {
            Console.WriteLine("Doctor -> ID: " + id + ", Name: " + name + ", Specialization: " + Specialization);
        }
    }

    // ================= NURSE =================
    class Nurse : Person
    {
        public Nurse(int id, string name) : base(id, name) { }

        public override void Display()
        {
            Console.WriteLine("Nurse -> ID: " + id + ", Name: " + name);
        }
    }

    // ================= MEDICAL RECORD =================
    class MedicalRecord
    {
        // Encapsulation
        private string diagnosis;
        private string treatment;
        private DateTime date;

        public MedicalRecord(string diagnosis, string treatment)
        {
            this.diagnosis = diagnosis;
            this.treatment = treatment;
            this.date = DateTime.Now;
        }

        public void Display()
        {
            Console.WriteLine("Date: " + date.ToShortDateString());
            Console.WriteLine("Diagnosis: " + diagnosis);
            Console.WriteLine("Treatment: " + treatment);
            Console.WriteLine("-------------------------");
        }
    }

    // ================= APPOINTMENT =================
    class Appointment
    {
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime Date { get; set; }

        public Appointment(Patient p, Doctor d, DateTime date)
        {
            Patient = p;
            Doctor = d;
            Date = date;
        }

        public void Display()
        {
            Console.WriteLine($"Appointment -> Patient: {PatientName()}, Doctor: {DoctorName()}, Date: {Date}");
        }

        private string PatientName() => Patient != null ? Patient.GetType().GetField("name", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(Patient).ToString() : "";
        private string DoctorName() => Doctor != null ? Doctor.GetType().GetField("name", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(Doctor).ToString() : "";
    }

    // ================= MAIN CLASS =================
    class Program
    {
        static void Main(string[] args)
        {
            List<Patient> patients = new List<Patient>();
            List<Doctor> doctors = new List<Doctor>();
            List<Appointment> appointments = new List<Appointment>();

            int choice;
            do
            {
                Console.WriteLine("\n--- HOSPITAL MANAGEMENT MENU ---");
                Console.WriteLine("1. Register Patient");
                Console.WriteLine("2. Register Doctor");
                Console.WriteLine("3. Schedule Appointment");
                Console.WriteLine("4. Add Medical Record");
                Console.WriteLine("5. View Patient History");
                Console.WriteLine("6. View Appointments");
                Console.WriteLine("7. Exit");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Patient ID: ");
                        int pid = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Patient Name: ");
                        string pname = Console.ReadLine();
                        patients.Add(new Patient(pid, pname));
                        Console.WriteLine("Patient Registered!");
                        break;

                    case 2:
                        Console.Write("Enter Doctor ID: ");
                        int did = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Doctor Name: ");
                        string dname = Console.ReadLine();
                        Console.Write("Enter Specialization: ");
                        string spec = Console.ReadLine();
                        doctors.Add(new Doctor(did, dname, spec));
                        Console.WriteLine("Doctor Registered!");
                        break;

                    case 3:
                        if (patients.Count == 0 || doctors.Count == 0)
                        {
                            Console.WriteLine("Register patient and doctor first!");
                            break;
                        }

                        Console.Write("Enter Patient ID: ");
                        int psearch = Convert.ToInt32(Console.ReadLine());
                        Patient pObj = patients.Find(p => p.GetType() != null && psearch == p.GetHashCode() ? false : true);
                        pObj = patients.Find(p => true && psearch == (int)p.GetType().GetField("id", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(p));

                        Console.Write("Enter Doctor ID: ");
                        int dsearch = Convert.ToInt32(Console.ReadLine());
                        Doctor dObj = doctors.Find(d => dsearch == (int)d.GetType().GetField("id", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(d));

                        if (pObj != null && dObj != null)
                        {
                            Appointment app = new Appointment(pObj, dObj, DateTime.Now);
                            appointments.Add(app);
                            Console.WriteLine("Appointment Scheduled!");
                        }
                        else
                        {
                            Console.WriteLine("Patient or Doctor not found!");
                        }
                        break;

                    case 4:
                        Console.Write("Enter Patient ID: ");
                        int mid = Convert.ToInt32(Console.ReadLine());

                        Patient mp = patients.Find(p => mid == (int)p.GetType().GetField("id", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(p));

                        if (mp != null)
                        {
                            Console.Write("Enter Diagnosis: ");
                            string diag = Console.ReadLine();
                            Console.Write("Enter Treatment: ");
                            string treat = Console.ReadLine();

                            mp.AddMedicalRecord(new MedicalRecord(diag, treat));
                            Console.WriteLine("Medical record added!");
                        }
                        else
                        {
                            Console.WriteLine("Patient not found!");
                        }
                        break;

                    case 5:
                        Console.Write("Enter Patient ID: ");
                        int hid = Convert.ToInt32(Console.ReadLine());

                        Patient hp = patients.Find(p => hid == (int)p.GetType().GetField("id", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(p));

                        if (hp != null)
                            hp.ShowMedicalHistory();
                        else
                            Console.WriteLine("Patient not found!");
                        break;

                    case 6:
                        foreach (var a in appointments)
                            a.Display();
                        break;
                }

            } while (choice != 7);
        }
    }
}
