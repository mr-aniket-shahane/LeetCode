public class ArrayStringsAre_Equal
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        string wordstr1 = "";
        foreach (string word in word1)
        {
            wordstr1 += word;
        }
        string wordstr2 = "";
        foreach (string word in word2)
        {
            wordstr2 += word;

        }
        return wordstr1.Equals(wordstr2) ? true : false;
    }
}