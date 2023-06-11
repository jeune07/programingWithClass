using System;
using System.Collections.Generic;
using System.Linq;

class ScriptureManager
{
    private List<string> hiddenWords;
    private Random random;

    public ScriptureManager()
    {
        hiddenWords = new List<string>();
        random = new Random();
    }

    public void HideRandomWords(Scripture scripture)
    {
        List<string> words = scripture.Text.Split(' ').ToList();
        List<string> visibleWords = words.Except(hiddenWords).ToList();

        if (visibleWords.Count == 0)
            return;

        string wordToHide = visibleWords[random.Next(visibleWords.Count)];
        hiddenWords.Add(wordToHide);
    }

    public bool AreAllWordsHidden(Scripture scripture)
    {
        List<string> words = scripture.Text.Split(' ').ToList();
        return words.All(word => hiddenWords.Contains(word));
    }
}