public class Anagram
{
    private readonly string _targetOriginal;
    private readonly string _targetSorted;
    
    public Anagram(string baseWord)
    {
        _targetOriginal = baseWord.ToLower();

        _targetSorted = SortString(_targetOriginal);
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        var matches = new List<string>(); 
        
        foreach (var potentialMatch in potentialMatches)
        {
            var lower = potentialMatch.ToLower();

            if (lower == _targetOriginal) continue;

            var candidateSorted = SortString(lower);

            if (candidateSorted == _targetSorted)
            {
                matches.Add(potentialMatch);
            }
        }

        return matches.ToArray();
    }

    private static string SortString(string word)
    {
        var chars = word.ToArray();
        Array.Sort(chars);

        return new string(chars);
    }
}