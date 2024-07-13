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

    public void ShowScripture()
    {
        Console.Write($"{_reference.GetScriptureReference()}: ");
        _words[10].HideWord();
        
        foreach(Word word in _words)
        {
            // This is the process to space the word from each other 
            Console.Write($"{word.GetWord()} ");
        }


    }

}