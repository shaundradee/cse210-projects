using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        // Step 1: Create a list of visible (not hidden) words
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        Random random = new Random();

        // Hide 'numberToHide' words
        int wordsToHide = Math.Min(numberToHide, visibleWords.Count);
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); // Prevent hiding the same word twice
        }
    }
    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string wordsText = "";
        foreach (Word word in _words)
        {
            wordsText += word.GetDisplayText() + " ";
        }
        wordsText = wordsText.Trim();
        return $"{referenceText} {wordsText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true; //location..?

    }
}