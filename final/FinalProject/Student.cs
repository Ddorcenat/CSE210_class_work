using System.Data.Common;
using System.Formats.Asn1;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

class Student
{
    private string _name;
    private string _gender;
    private int _age;
    private bool _allergy;
    private bool _petOwner; 
    private string _major;
    private bool _handicap;

    public Student(string StudentInfo)
    {
        string[] parts = StudentInfo.Split("#");
        _name = parts[0];
        _gender = parts[1];
        _age = int.Parse(parts[2]);
        _petOwner = false;
        if (parts[3] != "None")
        {
            _petOwner = true;
        }
        _allergy = false;
        if (parts[4]!= "None")
        {
            _allergy = true;
        }
        _handicap = false;
        if (parts[5] != "None")
        {
            _handicap = true;
        }
        _major = parts[6];
    }
    public void Dispplay() // Idsplay function
    {
        Console.WriteLine($"{_name} {_gender} {_age} {_allergy} {_petOwner} {_major} {_handicap}");
    }

}
