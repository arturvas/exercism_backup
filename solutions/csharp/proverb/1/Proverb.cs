public static class Proverb
{
    
    public static string[] Recite(string[] subjects)
    {
        if (subjects.Length == 0)
            return [];
        
        string[] words = new string[subjects.Length];
        
        for (int i = 0; i < subjects.Length - 1; i++)
        {
            words[i] = $"For want of a {subjects[i]} the {subjects[i+1]} was lost.";
        }
        
        words[^1] = $"And all for the want of a {subjects[0]}.";

        return words;
    }
}