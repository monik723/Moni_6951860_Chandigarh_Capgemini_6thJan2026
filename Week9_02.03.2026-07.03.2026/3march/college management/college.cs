using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    class CollageManagement
    {
        // student -> (subject -> marks)
        Dictionary<string, Dictionary<string, int>> studentRecords =
            new Dictionary<string, Dictionary<string, int>>();

        // subject -> insertion order of students
        Dictionary<string, LinkedList<KeyValuePair<string, int>>> subjectsStudentsOrder =
            new Dictionary<string, LinkedList<KeyValuePair<string, int>>>();

        // subject -> (student -> marks)
        Dictionary<string, Dictionary<string, int>> subjectsRecords =
            new Dictionary<string, Dictionary<string, int>>();

        public int AddStudent(string studentId, string subject, int marks)
        {
            // Create student if not exists
            if (!studentRecords.ContainsKey(studentId))
                studentRecords[studentId] = new Dictionary<string, int>();

            // Create subject if not exists
            if (!subjectsRecords.ContainsKey(subject))
                subjectsRecords[subject] = new Dictionary<string, int>();

            if (!subjectsStudentsOrder.ContainsKey(subject))
                subjectsStudentsOrder[subject] =
                    new LinkedList<KeyValuePair<string, int>>();

            // If already exists, update only if marks are higher
            if (studentRecords[studentId].ContainsKey(subject))
            {
                if (marks > studentRecords[studentId][subject])
                {
                    studentRecords[studentId][subject] = marks;
                    subjectsRecords[subject][studentId] = marks;

                    // update linked list value
                    var node = subjectsStudentsOrder[subject].First;
                    while (node != null)
                    {
                        if (node.Value.Key == studentId)
                        {
                            node.Value =
                                new KeyValuePair<string, int>(studentId, marks);
                            break;
                        }
                        node = node.Next;
                    }
                }
            }
            else
            {
                // New subject entry
                studentRecords[studentId][subject] = marks;
                subjectsRecords[subject][studentId] = marks;

                // maintain insertion order
                subjectsStudentsOrder[subject]
                    .AddLast(new KeyValuePair<string, int>(studentId, marks));
            }

            return 1;
        }

        public int RemoveStudent(string studentId)
        {
            if (!studentRecords.ContainsKey(studentId))
                return 0;

            // Remove from subject dictionaries
            foreach (var sub in studentRecords[studentId].Keys)
            {
                subjectsRecords[sub].Remove(studentId);

                // remove from insertion order list
                var node = subjectsStudentsOrder[sub].First;
                while (node != null)
                {
                    if (node.Value.Key == studentId)
                    {
                        subjectsStudentsOrder[sub].Remove(node);
                        break;
                    }
                    node = node.Next;
                }
            }

            studentRecords.Remove(studentId);
            return 1;
        }

        public string TopStudent(string subject)
        {
            if (!subjectsRecords.ContainsKey(subject) ||
                subjectsRecords[subject].Count == 0)
                return "";

            int maxMarks = subjectsRecords[subject].Values.Max();

            StringBuilder sb = new StringBuilder();

            // print in insertion order (tie rule)
            foreach (var pair in subjectsStudentsOrder[subject])
            {
                if (pair.Value == maxMarks)
                {
                    sb.AppendLine(pair.Key + " " + pair.Value);
                }
            }

            return sb.ToString().Trim();
        }

        public string Result()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var student in studentRecords)
            {
                double avg = student.Value.Values.Average();
                sb.AppendLine(student.Key + " " + avg.ToString("F2"));
            }

            return sb.ToString().Trim();
        }
    }

    public static void Main()
    {
        CollageManagement cm = new CollageManagement();

        // Sample Input Simulation
        cm.AddStudent("S1", "Math", 80);
        cm.AddStudent("S2", "Math", 90);
        cm.AddStudent("S3", "Math", 90);
        cm.AddStudent("S1", "Phy", 90);

        Console.WriteLine(cm.TopStudent("Math"));
        Console.WriteLine(cm.Result());

        cm.RemoveStudent("S1");
    }
}