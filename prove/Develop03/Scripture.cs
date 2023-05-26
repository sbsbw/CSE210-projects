using System;

public class Scripture
{
    // Define class attributes.
    private ScriptureReference _reference;
    private List<Word> _words = new List<Word>();

    // Create the constructor.
        public Scripture(string reference)
    {
        try
        {
            string[] lines = System.IO.File.ReadAllLines(reference);
            int lineNumber = 0;
            foreach (string line in lines)
            {
                if (lineNumber == 0)
                {
                    _reference = new ScriptureReference(line);
                }
                else
                {
                    int wordCounter = 0;
                    string[] parts = line.Split(" ");
                    foreach(string part in parts)
                    {
                        if (wordCounter == 0)
                        {
                            _reference.AddVerseToVerses(int.Parse(part));
                        }
                        else
                        {
                            Word word = new Word(part);
                            _words.Add(word);
                        }
                        wordCounter++;
                    }
                }
                lineNumber++;
            }
        }
        catch
        {
            Console.WriteLine("Sorry, that reference is not in our files.");
        }
    }

    // Create a method to print the scripture.
    public void PrintTheScripture()
    {
        _reference.PrintTheReference();
        foreach (Word word in _words)
        {
            word.PrintWord();
        }
    }

    // Create a method to test if all words are hidden.
    public bool AllWordsHidden()
    {
        bool finished = true;
        foreach(Word word in _words)
        {
            if (!word.IsHidden())
            {
                finished = false;
            }
        }
        return finished;
    }

    private int CountHiddenWords()
    {
        int count = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                count++;
            }
        }
        return count - 1;
    }
    public void HideRandomWord()
    {
        // Get random number.
        Random rnd = new Random();
        int number = rnd.Next(_words.Count - CountHiddenWords());

        // Use random number to hide a random word.
        int wordCount = 1;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                if (wordCount == number)
                {
                    word.HideWord();
                }
                wordCount++;
            }
        }

    }
}
