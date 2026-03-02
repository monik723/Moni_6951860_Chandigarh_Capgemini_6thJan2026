using System;

namespace ConsoleAppChandigarhUniversity
{
    interface IBilling
    {
        void Billing();
    }

    
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
            Console.WriteLine("There are some emergency patients");
        }
    }

    
    class Aims : Hospital, IBilling
    {
        public Aims(int d, int n) : base(d, n)
        {
        }

        public override void Operation()
        {
            Console.WriteLine("AIMS Hospital performing advanced operations");
        }

        public void Billing()
        {
            Console.WriteLine("AIMS Billing Department");
        }
    }

    
    class Max : Hospital, IBilling
    {
        public Max(int d, int n) : base(d, n)
        {
        }

        public override void Operation()
        {
            Console.WriteLine("MAX Hospital performing robotic operations");
        }

        public void Billing()
        {
            Console.WriteLine("MAX Billing Department");
        }
    }

    
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
            b1.Billing();

            Console.WriteLine("\n---- MAX ----");
            h2.Operation();
            h2.Emergency();

            IBilling b2 = (IBilling)h2;
            b2.Billing();

            Console.ReadLine();
        }
    }
}
