using System.ComponentModel;
using System.Dynamic;

class Reference
{
    private String _bookname;
    private int _chapter;
    private int _verse;


    public Reference(string name, int chapter, int verse)
    {
        _bookname = name;
        _chapter = chapter;
        _verse = verse;
    }

    public string GetScriptureReference()
    {
        return $"{_bookname} {_chapter}:{_verse}";
    }

} 