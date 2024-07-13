using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    private Reference _reference;

    List<Word> _words;
    public Scripture(string name, int chapter, int verse, string text)
    {
        _reference = new Reference(name, chapter, verse);
        _words = new List<Word>();
        // this is spliting the list of words into single word base on space.
        string[] words = text.Split(' ');
        // This help me 
        foreach (string word in words)
        {
            Word tempWord = new Word(word);
            _words.Add(tempWord);
        }
    }

    private int RemainingWords()
    {
        int count = 0;

        for (int i = 0; i < _words.Count(); i++)
        {
            if (!_words[i].IsHidden())
            {
                count ++;
            }
        }
        return count;
    }
    public bool HideWords()
    {
        Random random = new Random();
        int HideLimit = 3;
        if (RemainingWords() < 3)
        {
            HideLimit = RemainingWords();
        }
        int j = 0;
        while (j < HideLimit)
        {
            int index = random.Next(0, _words.Count());
            if (!_words[index].IsHidden())
            {
                _words[index].HideWord();
                j++;
            }

        }
        for (int i = 0; i < _words.Count(); i++)
        {
            if (!_words[i].IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    public void ShowScripture()
    {
        Console.Write($"{_reference.GetScriptureReference()}: ");
        // _words[10].HideWord();

        foreach (Word word in _words)
        {
            // This is the process to space the word from each other 
            Console.Write($"{word.GetWord()} ");
        }


    }

}