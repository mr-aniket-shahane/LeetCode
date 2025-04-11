public class MostWords_Found
{
    public int MostWordsFound(string[] sentences)
    {
        int totalWords = 0;
        foreach (string s in sentences)
        {
            totalWords = Math.Max(s.Split(" ").Count(), totalWords);
        }
        return totalWords;
    }
}