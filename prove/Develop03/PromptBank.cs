
public class PromptBank
{
    private static string[] journalPrompts = new string[]
    {
        "What are three things you're grateful for today, and why?",
        "Reflect on a recent accomplishment and describe how it made you feel.",
        "What are your short-term and long-term goals? How can you work towards them?",
        "Write about a challenge you faced recently. How did you overcome it, and what did you learn from the experience?",
        "Describe a person who has had a significant impact on your life. What lessons have you learned from them?",
        "Write about a book, article, or podcast that inspired you recently. What key takeaways did you gain from it?",
        "How do you practice self-care and maintain a healthy work-life balance?",
        "Reflect on a mistake or failure you experienced. What lessons did you learn, and how did you grow from it?",
        "Write about a place you've always wanted to visit. What attracts you to it, and what would you like to do there?",
        "How do you handle stress or difficult emotions? Share your coping strategies."
    };

    public static string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(0, journalPrompts.Length);
        return journalPrompts[index];
    }
}
