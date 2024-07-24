using System;

class Program
{
    static public string[] ReadFile()
    {
        string[] lines = { };
        string FileName = "stud.txt";
        if (File.Exists(FileName))
        {
            lines = File.ReadAllLines(FileName);
        }
        return lines;
    }
    static void Main(string[] args)
    {
        List<Student> students = new List<Student> { };
        string[] lines = ReadFile();
        foreach (string line in lines)
        {
            Student student = new Student(line);
            students.Add(student);
        }
        foreach(Student student in students)
        {
            student.Dispplay();
        }
    }
}
