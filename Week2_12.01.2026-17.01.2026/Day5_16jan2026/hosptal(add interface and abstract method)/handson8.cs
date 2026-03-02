using System;

namespace ConsoleAppChandigarhUniversity
{
    // INTERFACE 1
    interface IBilling
    {
        void GenerateBill();
        void Insurance();
        void Discount();
        void PaymentMode();
        void Refund();
        void BillingReport();
    }

    // INTERFACE 2
    interface IManagement
    {
        void Admission();
        void Discharge();
        void StaffManagement();
        void RoomAllocation();
        void Inventory();
        void Reports();
    }

    // BASE CLASS
    class Hospital
    {
        private int doctors;
        private int nurses;

        public int Doctors
        {
            get { return doctors; }
            set { doctors = value; }
        }

        public int Nurses
        {
            get { return nurses; }
            set { nurses = value; }
        }

        public Hospital(int d, int n)
        {
            doctors = d;
            nurses = n;
        }

        public virtual void Operation()
        {
            Console.WriteLine("Hospital is performing operations");
        }

        public void Emergency()
        {
            Console.WriteLine("Emergency patients are being treated");
        }
    }

    // DERIVED CLASS 1
    class Aims : Hospital, IBilling, IManagement
    {
        public Aims(int d, int n) : base(d, n) { }

        public override void Operation()
        {
            Console.WriteLine("AIMS Hospital performing advanced operations");
        }

        // IBilling Methods
        public void GenerateBill() { Console.WriteLine("AIMS: Bill Generated"); }
        public void Insurance() { Console.WriteLine("AIMS: Insurance Applied"); }
        public void Discount() { Console.WriteLine("AIMS: Discount Given"); }
        public void PaymentMode() { Console.WriteLine("AIMS: Payment by Card/Cash"); }
        public void Refund() { Console.WriteLine("AIMS: Refund Processed"); }
        public void BillingReport() { Console.WriteLine("AIMS: Billing Report Generated"); }

        // IManagement Methods
        public void Admission() { Console.WriteLine("AIMS: Patient Admitted"); }
        public void Discharge() { Console.WriteLine("AIMS: Patient Discharged"); }
        public void StaffManagement() { Console.WriteLine("AIMS: Staff Managed"); }
        public void RoomAllocation() { Console.WriteLine("AIMS: Room Allocated"); }
        public void Inventory() { Console.WriteLine("AIMS: Inventory Checked"); }
        public void Reports() { Console.WriteLine("AIMS: Management Report Generated"); }
    }

    // DERIVED CLASS 2
    class Max : Hospital, IBilling, IManagement
    {
        public Max(int d, int n) : base(d, n) { }

        public override void Operation()
        {
            Console.WriteLine("MAX Hospital performing robotic operations");
        }

        // IBilling Methods
        public void GenerateBill() { Console.WriteLine("MAX: Bill Generated"); }
        public void Insurance() { Console.WriteLine("MAX: Insurance Applied"); }
        public void Discount() { Console.WriteLine("MAX: Discount Given"); }
        public void PaymentMode() { Console.WriteLine("MAX: Payment by UPI/Card"); }
        public void Refund() { Console.WriteLine("MAX: Refund Processed"); }
        public void BillingReport() { Console.WriteLine("MAX: Billing Report Generated"); }

        // IManagement Methods
        public void Admission() { Console.WriteLine("MAX: Patient Admitted"); }
        public void Discharge() { Console.WriteLine("MAX: Patient Discharged"); }
        public void StaffManagement() { Console.WriteLine("MAX: Staff Managed"); }
        public void RoomAllocation() { Console.WriteLine("MAX: Room Allocated"); }
        public void Inventory() { Console.WriteLine("MAX: Inventory Checked"); }
        public void Reports() { Console.WriteLine("MAX: Management Report Generated"); }
    }

    // MAIN CLASS
    class Program
    {
        static void Main(string[] args)
        {
            Hospital h1 = new Aims(10, 20);
            Hospital h2 = new Max(15, 25);

            Console.WriteLine("---- AIMS ----");
            h1.Operation();
            h1.Emergency();

            IBilling b1 = (IBilling)h1;
            b1.GenerateBill();
            b1.Insurance();

            IManagement m1 = (IManagement)h1;
            m1.Admission();
            m1.RoomAllocation();

            Console.WriteLine("\n---- MAX ----");
            h2.Operation();
            h2.Emergency();

            IBilling b2 = (IBilling)h2;
            b2.GenerateBill();
            b2.PaymentMode();

            IManagement m2 = (IManagement)h2;
            m2.Admission();
            m2.Inventory();

            Console.ReadLine();
        }
    }
}
