using System;
using System.Collections.Generic;
using System.IO;


//Called a utility or helper class. Using to load in from file and select random scripture
//before sending out variables to other classes.

public class ScriptureLoader //Called a utility or helper class
{
    public Scripture LoadRandomScripture(string filePath)
    {
        List<string> validLines = new List<string>();

        // Load lines from the file
        foreach (string line in File.ReadLines(filePath))
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = line.Split('|');
            if (parts.Length >= 5)
            {
                validLines.Add(line);
            }
        }

        // Safety net
        // if (validLines.Count == 0)
        // {
        //     throw new Exception("No valid scriptures found in file.");
        // }

        // Pick a random scripture line
        var random = new Random();
        int index = random.Next(validLines.Count);
        string selectedLine = validLines[index];

        // Parse the selected line
        string[] selectedParts = selectedLine.Split('|');
        string book = selectedParts[0];
        int chapter = int.Parse(selectedParts[1]);
        int verse = int.Parse(selectedParts[2]);
        string endVerseStr = selectedParts[3];
        string text = selectedParts[4];

        Reference reference;
        if (string.IsNullOrWhiteSpace(endVerseStr))
        {
            reference = new Reference(book, chapter, verse);
        }
        else
        {
            int endVerse = int.Parse(endVerseStr);
            reference = new Reference(book, chapter, verse, endVerse);
        }

        // Return the final Scripture object
        return new Scripture(reference, text);
    }
}
