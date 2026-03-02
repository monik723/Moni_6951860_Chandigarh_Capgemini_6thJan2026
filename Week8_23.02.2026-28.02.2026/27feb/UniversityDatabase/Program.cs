using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace UniversityManagementSystem
{
    class Program
    {
        static string connectionString =
            "Server=DESKTOP-PIVKDPU\\SQLEXPRESS;" +
            "Database=UniversityDB;" +
            "Integrated Security=True;" +
            "TrustServerCertificate=True;";

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== UNIVERSITY MANAGEMENT SYSTEM =====");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");
                Console.Write("Enter Choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddStudent(); break;
                    case 2: ViewStudents(); break;
                    case 3: UpdateStudent(); break;
                    case 4: DeleteStudent(); break;
                    case 5: return;
                    default: Console.WriteLine("Invalid Choice"); break;
                }
            }
        }

        static void AddStudent()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_AddStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;

                Console.Write("First Name: ");
                cmd.Parameters.AddWithValue("@FirstName", Console.ReadLine());

                Console.Write("Last Name: ");
                cmd.Parameters.AddWithValue("@LastName", Console.ReadLine());

                Console.Write("Email: ");
                cmd.Parameters.AddWithValue("@Email", Console.ReadLine());

                Console.Write("Department Id: ");
                cmd.Parameters.AddWithValue("@DeptId", Convert.ToInt32(Console.ReadLine()));

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Student Added Successfully!");
            }
        }

        static void ViewStudents()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_GetAllStudents", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("\n--- STUDENT LIST ---");

                while (reader.Read())
                {
                    Console.WriteLine(
                        reader["StudentId"] + " | " +
                        reader["FirstName"] + " " +
                        reader["LastName"] + " | " +
                        reader["Email"] + " | " +
                        reader["DeptName"]);
                }
            }
        }

        static void UpdateStudent()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;

                Console.Write("Student Id: ");
                cmd.Parameters.AddWithValue("@StudentId", Convert.ToInt32(Console.ReadLine()));

                Console.Write("First Name: ");
                cmd.Parameters.AddWithValue("@FirstName", Console.ReadLine());

                Console.Write("Last Name: ");
                cmd.Parameters.AddWithValue("@LastName", Console.ReadLine());

                Console.Write("Email: ");
                cmd.Parameters.AddWithValue("@Email", Console.ReadLine());

                Console.Write("Department Id: ");
                cmd.Parameters.AddWithValue("@DeptId", Convert.ToInt32(Console.ReadLine()));

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Student Updated Successfully!");
            }
        }

        static void DeleteStudent()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_DeleteStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;

                Console.Write("Student Id to Delete: ");
                cmd.Parameters.AddWithValue("@StudentId", Convert.ToInt32(Console.ReadLine()));

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Student Deleted Successfully!");
            }
        }
    }
}