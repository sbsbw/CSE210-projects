using System;

class Journal
{
    public string _journalName;
    public List<JournalEntry> _journalEntries = new List<JournalEntry>();

    public void Display()
    {

        // Use a for loop to display jobs.
        foreach (JournalEntry entry in _journalEntries)
        {
            entry.EntryDisplay();
        }
    }
    public void Load(string fileName)
    {
        try
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            _journalEntries.Clear();
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                JournalEntry entry = new JournalEntry();
                entry._date = parts[0];
                entry._prompt = parts[1];
                entry._entryText = parts[2];
                _journalEntries.Add(entry);
            }
        }
        catch
        {
            Console.WriteLine("We could not find this file.");
        }

    }
    public void Save(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (JournalEntry entry in _journalEntries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._entryText}");
            }
        }
    }
}