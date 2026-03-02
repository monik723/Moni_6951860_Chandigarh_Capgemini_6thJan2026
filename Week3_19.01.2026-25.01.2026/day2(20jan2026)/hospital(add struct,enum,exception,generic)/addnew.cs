using System;

namespace ConsoleAppChandigarhUniversity
{
    // ================= ENUM =================
    // Enum is used to represent FIXED choices
    enum Department
    {
        Cardiology,
        Neurology,
        Orthopedics,
        Emergency
    }

    enum PaymentType
    {
        Cash,
        Card,
        UPI,
        Insurance
    }

    // ================= STRUCT =================
    // Struct is used to represent SMALL DATA OBJECT
    struct Patient
    {
        public int Id;
        public string Name;
        public int Age;
        public Department Dept;

        // Constructor to initialize patient
        public Patient(int id, string name, int age, Department dept)
        {
            Id = id;
            Name = name;
            Age = age;
            Dept = dept;
        }

        // Method to display patient info
        public void Display()
        {
            Console.WriteLine("\n----- Patient Details -----");
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Department: " + Dept);
        }
    }

    // ================= GENERIC CLASS =================
    // Generic class can store ANY TYPE of data
    class Storage<T>
    {
        private T data;   // T means any datatype

        public void Set(T value)
        {
            data = value;
        }

        public T Get()
        {
            return data;
        }
    }

    // ================= INTERFACE 1 =================
    interface IBilling
    {
        void GenerateBill(int amount, PaymentType mode);
    }

    // ================= INTERFACE 2 =================
    interface IManagement
    {
        void Admission();
    }

    // ================= BASE CLASS =================
    class Hospital
    {
        public virtual void Operation()
        {
            Console.WriteLine("Hospital is performing operations...");
        }

        public void Emergency()
        {
            Console.WriteLine("Emergency patients are being treated...");
        }
    }

    // ================= DERIVED CLASS 1 =================
    class Aims : Hospital, IBilling, IManagement
    {
        // Overriding parent method (Polymorphism)
        public override void Operation()
        {
            Console.WriteLine("AIMS Hospital performing advanced operations");
        }

        // Billing with exception handling
        public void GenerateBill(int amount, PaymentType mode)
        {
            try
            {
                // If amount is wrong, throw exception
                if (amount <= 0)
                    throw new Exception("Invalid bill amount!");

                Console.WriteLine("\nAIMS Bill Generated: ₹" + amount);
                Console.WriteLine("Payment Mode: " + mode);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Billing Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Billing process completed.");
            }
        }

        public void Admission()
        {
            Console.WriteLine("Patient admitted in AIMS hospital.");
        }
    }

    // ================= DERIVED CLASS 2 =================
    class Max : Hospital, IBilling, IManagement
    {
        public override void Operation()
        {
            Console.WriteLine("MAX Hospital performing robotic operations");
        }

        public void GenerateBill(int amount, PaymentType mode)
        {
            try
            {
                if (amount <= 0)
                    throw new Exception("Invalid bill amount!");

                Console.WriteLine("\nMAX Bill Generated: ₹" + amount);
                Console.WriteLine("Payment Mode: " + mode);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Billing Error: " + ex.Message);
            }
        }

        public void Admission()
        {
            Console.WriteLine("Patient admitted in MAX hospital.");
        }
    }

    // ================= MAIN CLASS =================
    class Program
    {
        static void Main()
        {
            // ----------- Taking Patient Input from User -----------
            Console.Write("Enter Patient ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Patient Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Patient Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Select Department: 0-Cardiology 1-Neurology 2-Orthopedics 3-Emergency");
            Department dept = (Department)int.Parse(Console.ReadLine());

            // Creating struct object
            Patient p1 = new Patient(id, name, age, dept);

            // Using GENERIC CLASS to store Patient
            Storage<Patient> store = new Storage<Patient>();
            store.Set(p1);

            // Getting patient back from generic class
            Patient storedPatient = store.Get();
            storedPatient.Display();

            // ----------- Selecting Hospital -----------
            Console.WriteLine("\nSelect Hospital: 1-AIMS  2-MAX");
            int choice = int.Parse(Console.ReadLine());

            Hospital hospital;
            IBilling billing;
            IManagement management;

            if (choice == 1)
            {
                hospital = new Aims();
                billing = new Aims();
                management = new Aims();
            }
            else
            {
                hospital = new Max();
                billing = new Max();
                management = new Max();
            }

            // ----------- Calling Methods using Polymorphism -----------
            management.Admission();
            hospital.Operation();
            hospital.Emergency();

            // ----------- Billing Section -----------
            Console.Write("\nEnter Bill Amount: ");
            int amount = int.Parse(Console.ReadLine());

            Console.WriteLine("Select Payment Mode: 0-Cash 1-Card 2-UPI 3-Insurance");
            PaymentType mode = (PaymentType)int.Parse(Console.ReadLine());

            billing.GenerateBill(amount, mode);

            Console.WriteLine("\nThank you for using Hospital Management System!");
            Console.ReadLine();
        }
    }
}
