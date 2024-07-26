using System.Buffers.Binary;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic.FileIO;

class Apartment
{
    private int _unitnum;
    private bool _petAllow;
    private int _maxNumbeofoccupants;
    private int _numberofoccupants;
    private bool _maleOrFemale;
    private bool _disability;
    private List<string> _occupantNames; 

    

    public Apartment(string apartmentInfo)
    {
        _occupantNames = new List<string>();
        string[] unit = apartmentInfo.Split("#");
        _unitnum = int.Parse(unit[0]);
        _maxNumbeofoccupants = int.Parse(unit[1]);
        _maleOrFemale = false;
        if (unit[2] != "Female")
        {
            _maleOrFemale = true;
        }
        _petAllow = false;
        if (unit[3] != "No")
        {
            _petAllow = true;
        }
        _disability = false;
        if (unit[4] != "None")
        {
            _disability = true;
        }
        _numberofoccupants = 0;
        // Console.WriteLine($"{_unitnum} {_maxNumbeofoccupants} {_maleOrFemale} {_petAllow} {_disability}");
    }
    // public void DisplayApartment()
    // {
    //     Console.WriteLine($" This is the Apartment number: {_unitnum}");
    //     int count = 1;
    //     foreach(string occupant in _occupantNames)
    //     {
    //         Console.WriteLine($"{count++} {occupant}");
    //     }
    // }

public void DisplayApartment()// New code after 10Pm
{
    Console.WriteLine($"This is the Apartment number: {_unitnum}");
    if (IsEmpty())
    {
        Console.WriteLine("No occupants.");
    }
    else
    {
        int count = 1;
        foreach (string occupant in _occupantNames)
        {
            Console.WriteLine($"{count++} {occupant}");
        }
    }
}

    
    // Need a method to check for avaibility 
    public bool Fullapartment() // Logic was required her becasue it had to make a decision 
    {
        if (_numberofoccupants < _maxNumbeofoccupants)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public bool IaDisableFriendly() // Meanwhile logic is not required here becaue in the lines above disability was already taking care.
    {
        return _disability;
    }
    public bool IsPetAllow()
    {
        return _petAllow;
    }
    public bool IsGenderFeOrMa()
    {
        return _maleOrFemale;
    }
    public void AddPersonToAprt(string name)
    {
        _occupantNames.Add(name);
        _numberofoccupants++;
    }
    public bool IsEmpty()
    {
        return _occupantNames.Count == 0;
    }
}
