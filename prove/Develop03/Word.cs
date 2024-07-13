class Word
{
    private string _word;
    // it's call flag, if true the word is hidden
    private bool _hidden;

    // This is small constructor 
    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    // This is a method that hide the word and tell if it's hidden
    public bool IsHidden()
    {
        return _hidden;
    }
    public void HideWord()
    {
        _hidden = true;
    }

    // This is a loggic, if the word is not hidden return the word.
    public string GetWord()
    {
        if (!_hidden) // word not hidden so return word
        {
            return _word;
        }
        else // word is hidden so return "_"
        {
            string hiddenword = "";
            for (int i = 0; i < _word.Count(); i++)
            {
                hiddenword += '_';
            }
            return hiddenword;
        }
    }

}