using System;
using System.IO;
using System.Xml.Serialization;

[Serializable]
public class Student
{
    public int Id;
    public string Name;
}

class Program
{
    static void Main()
    {
        Student s = new Student { Id = 101, Name = "John Doe" };

        // Create file stream
        FileStream fs = new FileStream("student.xml", FileMode.Create);

        // Create XML Serializer
        XmlSerializer serializer = new XmlSerializer(typeof(Student));

        // Serialize object
        serializer.Serialize(fs, s);

        fs.Close();

        Console.WriteLine("XML Serialization completed. File created: student.xml");
    }
}
