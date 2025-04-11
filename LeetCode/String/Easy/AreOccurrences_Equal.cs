public class AreOccurrences_Equal
{
    public bool AreOccurrencesEqual(string s)
    {
        int a = s.Count(x => x == s[0]);
        var dist = s.Distinct();
        Console.Write(dist.Last());
        foreach (var l in dist)
        {
            if (a != s.Count(x => x == l))
            {
                return false;
            }
        }
        return true;
    }
}