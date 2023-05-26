using System;

public class ScriptureReference
{
// Define class attributes.
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;
    private List<int> verses = new List<int>();

    // private int _verseEnd;

    public ScriptureReference(string referenceText)
    {
        {
            string[] parts = referenceText.Split(" ");
            _book = parts[0]; 
            string[] subParts = parts[1].Split(":");
            _chapter = int.Parse(subParts[0]);
            try
            {
                string[]  subSubParts = subParts[1].Split("-");
                _verseStart = int.Parse(subSubParts[0]);
                _verseEnd = int.Parse(subSubParts[1]);
            }
            catch
            {
            _verseStart = int.Parse(subParts[1]);
            _verseEnd = int.Parse(subParts[1]);

            }
        }
    }

    // Create methods to access Scripture reference.
    public void AddVerseToVerses(int verseNumber)
    {
        verses.Add(verseNumber);
    }

    public void PrintTheReference()
    {
        Console.Write($"{_book} {_chapter}:{_verseStart}-{_verseEnd}  ");
    }
}