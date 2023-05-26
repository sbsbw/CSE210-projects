using System;

public class Word
{
    // Define class attributes.
    private bool _hidden;
    private string _text;

    public Word(string text)
    {
        _hidden = false;
        _text = text;
    }
    
    // Create methods to manipulate the word.
    public void HideWord()
    {
        int _letters = _text.Length;
        char[] wordAsChars = _text.ToCharArray();
        List<string> wordAsUnderscores = new List<string>();
        foreach (char letter in wordAsChars)
        {
            int i = 0;
            wordAsUnderscores.Add("_");
            i++;
        }
        _text = String.Join("", wordAsUnderscores);
        _hidden = true;
    }

    public void PrintWord()
    {
        Console.Write($"{_text} ");
    }

    public bool IsHidden()
    {
        if (!_hidden)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

}