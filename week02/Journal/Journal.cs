using System;


public class Journal
{
    //changed to "private" b/c this class is the only class that should be accessing it
    private List<Entry> _entries = new List<Entry>(); 
    
    //"Entries" is a property for json, so not conformed to the normal naming advised "_"
    public List<Entry> Entries { get { return _entries; } set { _entries = value; } }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
}