using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace LibraryManagementSystem
{
    class Program
    {
        static string connectionString =
            "Server=DESKTOP-PIVKDPU\\SQLEXPRESS;" +
            "Database=LibraryDB;" +
            "Integrated Security=True;" +
            "TrustServerCertificate=True;";

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== LIBRARY MANAGEMENT SYSTEM =====");
                Console.WriteLine("1. View Books");
                Console.WriteLine("2. Add Book");
                Console.WriteLine("3. Update Book");
                Console.WriteLine("4. Delete Book");
                Console.WriteLine("5. Exit");
                Console.Write("Enter Choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: ViewBooks(); break;
                    case 2: AddBook(); break;
                    case 3: UpdateBook(); break;
                    case 4: DeleteBook(); break;
                    case 5: return;
                    default: Console.WriteLine("Invalid Choice"); break;
                }
            }
        }

        static void ViewBooks()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("sp_GetAllBooks", con);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                DataTable table = ds.Tables[0];

                Console.WriteLine("\n--- BOOK LIST ---");

                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine(
                        row["BookId"] + " | " +
                        row["Title"] + " | " +
                        row["AuthorName"] + " | " +
                        row["PublishedYear"]);
                }
            }
        }

        static void AddBook()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand("sp_AddBook", con);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;

                Console.Write("Title: ");
                adapter.InsertCommand.Parameters.AddWithValue("@Title", Console.ReadLine());

                Console.Write("AuthorId: ");
                adapter.InsertCommand.Parameters.AddWithValue("@AuthorId", Convert.ToInt32(Console.ReadLine()));

                Console.Write("Published Year: ");
                adapter.InsertCommand.Parameters.AddWithValue("@PublishedYear", Convert.ToInt32(Console.ReadLine()));

                con.Open();
                adapter.InsertCommand.ExecuteNonQuery();
                Console.WriteLine("Book Added Successfully!");
            }
        }

        static void UpdateBook()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.UpdateCommand = new SqlCommand("sp_UpdateBook", con);
                adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;

                Console.Write("BookId: ");
                adapter.UpdateCommand.Parameters.AddWithValue("@BookId", Convert.ToInt32(Console.ReadLine()));

                Console.Write("Title: ");
                adapter.UpdateCommand.Parameters.AddWithValue("@Title", Console.ReadLine());

                Console.Write("AuthorId: ");
                adapter.UpdateCommand.Parameters.AddWithValue("@AuthorId", Convert.ToInt32(Console.ReadLine()));

                Console.Write("Published Year: ");
                adapter.UpdateCommand.Parameters.AddWithValue("@PublishedYear", Convert.ToInt32(Console.ReadLine()));

                con.Open();
                adapter.UpdateCommand.ExecuteNonQuery();
                Console.WriteLine("Book Updated Successfully!");
            }
        }

        static void DeleteBook()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.DeleteCommand = new SqlCommand("sp_DeleteBook", con);
                adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;

                Console.Write("BookId to Delete: ");
                adapter.DeleteCommand.Parameters.AddWithValue("@BookId", Convert.ToInt32(Console.ReadLine()));

                con.Open();
                adapter.DeleteCommand.ExecuteNonQuery();
                Console.WriteLine("Book Deleted Successfully!");
            }
        }
    }
}