using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new();
    public PromptGen _pgen = new();

    public void AddEntry()
    {
        Entry entry = new();
        entry._dateTxt = DateTime.Now.ToShortDateString();
        entry._prompt = _pgen.GetRandomPrompt();
        Console.WriteLine(entry._prompt);
        entry._userEntry = Console.ReadLine();
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry item in _entries)
        {
            Console.WriteLine(item.DisplayEntry());
        }
    }
    
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._dateTxt}|{entry._prompt}|{entry._userEntry}");
            }
            Console.WriteLine("Journal saved to file successfully.");
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        using (StreamReader reader = new StreamReader(file))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split("|");
                Entry entry = new();
                entry._dateTxt = parts[0];
                entry._prompt = parts[1];
                entry._userEntry = parts[2];
                _entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded from file successfully.");
    }
}