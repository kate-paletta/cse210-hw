using System;
using System.Collections.Generic;
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

    }
    public void LoadFromFile(string file)
    {
        
    }
}