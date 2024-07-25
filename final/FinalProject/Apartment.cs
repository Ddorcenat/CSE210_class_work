using System.Buffers.Binary;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic.FileIO;

class Apartment
{
    public int _unitnum;
    public bool _petAllow;
    public int _maxNumbeofoccupants;
    public int _numberofoccuants;
    public bool _maleOrFemale;
    public bool _disability;

    public Apartment(string apartmentInfo)
    {
        string[] unit = apartmentInfo.Split("#");
        _unitnum = int.Parse(unit[0]);
        _maxNumbeofoccupants = int.Parse(unit[1]);
        _maleOrFemale = false;
        if (unit[2] != "Female")
        {
            _maleOrFemale = true;
        }
        _petAllow = false;
        if (unit[3] != "No Pet")
        {
            _petAllow = true;
        }
        _disability = false;
        if (unit[4] != "None")
        {
            _disability = true;
        }
        _numberofoccuants = 0;
        Console.WriteLine($"{_unitnum} {_maxNumbeofoccupants} {_maleOrFemale} {_petAllow} {_disability}");
    }
}