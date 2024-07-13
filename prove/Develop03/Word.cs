class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }
    public void HideWord()
    {
        _hidden = true;
    }
    public string GetWord()
    {
        if (!_hidden)
        {
            return _word;
        }
        else
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