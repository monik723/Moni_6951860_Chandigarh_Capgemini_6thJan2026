using System;
using System.Collections.Generic;

namespace CollegeManagement
{
    // ================= BASE CLASS =================
    class Person
    {
        // Encapsulation
        private int id;
        private string name;

        public Person(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int GetId() => id;
        public string GetName() => name;

        public virtual void Display()
        {
            Console.WriteLine("ID: " + id + ", Name: " + name);
        }
    }

    // ================= STUDENT =================
    class Student : Person
    {
        public string Course { get; set; }

        public Student(int id, string name, string course) : base(id, name)
        {
            Course = course;
        }

        public override void Display()
        {
            Console.WriteLine("Student -> ID: " + GetId() + ", Name: " + GetName() + ", Course: " + Course);
        }
    }

    // ================= PROFESSOR =================
    class Professor : Person
    {
        public List<Course> AssignedCourses = new List<Course>();

        public Professor(int id, string name) : base(id, name) { }

        public void AssignCourse(Course c)
        {
            AssignedCourses.Add(c);
        }

        public override void Display()
        {
            Console.WriteLine("Professor -> ID: " + GetId() + ", Name: " + GetName());
            Console.WriteLine("Assigned Courses:");
            if (AssignedCourses.Count == 0)
                Console.WriteLine("None");
            else
                foreach (var c in AssignedCourses)
                    Console.WriteLine("- " + c.CourseName);
        }
    }

    // ================= STAFF =================
    class Staff : Person
    {
        public string Department { get; set; }

        public Staff(int id, string name, string dept) : base(id, name)
        {
            Department = dept;
        }

        public override void Display()
        {
            Console.WriteLine("Staff -> ID: " + GetId() + ", Name: " + GetName() + ", Department: " + Department);
        }
    }

    // ================= COURSE =================
    class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public Course(int id, string name)
        {
            CourseId = id;
            CourseName = name;
        }

        public void Display()
        {
            Console.WriteLine("Course ID: " + CourseId + ", Name: " + CourseName);
        }
    }

    // ================= DEPARTMENT =================
    class Department
    {
        public string DeptName { get; set; }

        public Department(string name)
        {
            DeptName = name;
        }
    }

    // ================= MAIN CLASS =================
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<Professor> professors = new List<Professor>();
            List<Staff> staffList = new List<Staff>();
            List<Course> courses = new List<Course>();

            // Sample courses
            courses.Add(new Course(1, "C# Programming"));
            courses.Add(new Course(2, "Data Structures"));
            courses.Add(new Course(3, "DBMS"));

            int choice;
            do
            {
                Console.WriteLine("\n--- COLLEGE MANAGEMENT MENU ---");
                Console.WriteLine("1. Register Student");
                Console.WriteLine("2. Register Professor");
                Console.WriteLine("3. Register Staff");
                Console.WriteLine("4. Assign Course to Professor");
                Console.WriteLine("5. View All Profiles");
                Console.WriteLine("6. Exit");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Student ID: ");
                        int sid = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        string sname = Console.ReadLine();
                        Console.Write("Enter Course Name: ");
                        string scourse = Console.ReadLine();

                        students.Add(new Student(sid, sname, scourse));
                        Console.WriteLine("Student Registered!");
                        break;

                    case 2:
                        Console.Write("Enter Professor ID: ");
                        int pid = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        string pname = Console.ReadLine();

                        professors.Add(new Professor(pid, pname));
                        Console.WriteLine("Professor Registered!");
                        break;

                    case 3:
                        Console.Write("Enter Staff ID: ");
                        int stid = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        string stname = Console.ReadLine();
                        Console.Write("Enter Department: ");
                        string dept = Console.ReadLine();

                        staffList.Add(new Staff(stid, stname, dept));
                        Console.WriteLine("Staff Registered!");
                        break;

                    case 4:
                        if (professors.Count == 0)
                        {
                            Console.WriteLine("No professors available!");
                            break;
                        }

                        Console.WriteLine("Available Courses:");
                        foreach (var c in courses)
                            c.Display();

                        Console.Write("Enter Professor ID: ");
                        int psearch = Convert.ToInt32(Console.ReadLine());

                        Professor prof = professors.Find(p => p.GetId() == psearch);

                        if (prof != null)
                        {
                            Console.Write("Enter Course ID to assign: ");
                            int cid = Convert.ToInt32(Console.ReadLine());

                            Course course = courses.Find(c => c.CourseId == cid);

                            if (course != null)
                            {
                                prof.AssignCourse(course);
                                Console.WriteLine("Course Assigned!");
                            }
                            else
                                Console.WriteLine("Course not found!");
                        }
                        else
                        {
                            Console.WriteLine("Professor not found!");
                        }
                        break;

                    case 5:
                        Console.WriteLine("\n--- STUDENTS ---");
                        foreach (var s in students) s.Display();

                        Console.WriteLine("\n--- PROFESSORS ---");
                        foreach (var p in professors) p.Display();

                        Console.WriteLine("\n--- STAFF ---");
                        foreach (var st in staffList) st.Display();
                        break;
                }

            } while (choice != 6);
        }
    }
}
