using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppchadigarh_university
{
    internal class Hospital
    {
        int doctor;
        int nurse;
        public void operation()
        {
            Console.WriteLine("operation");
        }

        public void emergency()
        {
            Console.WriteLine("there are some emergent patients");
        }

        public void billing()
        {
            Console.WriteLine("billing for the pateints ");
        }
        static void Main(String[] args)
        {
            Hospital Aims = new Hospital();
            Hospital Max = new Hospital();   
            Aims.operation();
            Aims.emergency();
            Max.operation();
            Max.emergency();
            Aims.billing();
            Max.billing();
            
        }
    }
}

