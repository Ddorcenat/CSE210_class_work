using System;

class Program
{
    static public string[] ReadFile() //student code
    {
        string[] lines = { };
        string FileName = "stud.txt";
        if (File.Exists(FileName))
        {
            lines = File.ReadAllLines(FileName);
        }
        return lines;
    }
    static public string[] ReadaptFile()// new code apartment code - Completly separate variable therefore the lines of code down doens't afftect the value title I use for my code later 
    {
        string[] lines = { };
        string aptnumfilename = "Aptnumber.txt";
        if (File.Exists(aptnumfilename))
        {
            lines = File.ReadAllLines(aptnumfilename);
        }
        return lines;
    }
    static void Main(string[] args)
    {
        List<Student> students = new List<Student> { };// student text files 
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
        List<Apartment> apartments = new List<Apartment> {};//apartment text file 
        string[] placement = ReadaptFile();
        foreach (string line in placement)
        {
            Apartment apartment = new Apartment(line);
            apartments.Add(apartment);
        }
    }
}
