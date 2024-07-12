class JournalEntry
{
    private string _entry;
    public JournalEntry(string entry)
    {
        _entry = entry; 
    }
    public string GetEntry() 
    {
        return _entry;
    }
}
