using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    public List<string> _entries = new List<string>();
    public string _entryItem;
    public void AddEntry(string entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (string item in _entries)
        {
            Console.WriteLine(item);
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (string entry in _entries)
            {
                writer.WriteLine(entry);
            }
            Console.WriteLine("Journal saved to file successfully.");
        }
    }
    public void LoadFromFile(string file)
    {
        using (StreamReader reader = new StreamReader(file))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                _entries.Add(line);
            }
        }
        Console.WriteLine("Journal loaded from file successfully.");
    }
}