using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Random random;
    
    public Reference Reference { get; }
    public List<Word> Words { get; }
    
    public Scripture(Reference reference, string text)
    {
        random = new Random();
        Reference = reference;
        Words = CreateWordList(text);
    }
    
    private List<Word> CreateWordList(string text)
    {
        List<Word> words = new List<Word>();
        
        string[] wordArray = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        
        foreach (string wordText in wordArray)
        {
            Word word = new Word(wordText);
            words.Add(word);
        }
        
        return words;
    }
    
    public void HideRandomWord()
    {
        List<Word> visibleWords = Words.Where(w => w.IsHidden == false).ToList();

        if (visibleWords.Count > 0)
        {
            int randomIndex = random.Next(0, visibleWords.Count);
            visibleWords[randomIndex].IsHidden = true;
        }
    }
    
    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        
        foreach (Word word in Words)
        {
            string displayWord = word.IsHidden ? "_____" : word.Text;
            displayWords.Add(displayWord);
        }
        
        return string.Join(" ", displayWords);
    }
}
