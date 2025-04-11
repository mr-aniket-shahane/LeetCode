public class Truncate_Sentence
{
    public string TruncateSentence(string s, int k)
    {
        var ar = s.Split(" ");
        if (ar.Count() <= k)
        {
            return s;
        }
        else
        {
            string ans = "";
            int i = 0;
            while (i < k)
            {
                if (ans == "")
                {
                    ans += ar[i];
                    i++;
                }
                else
                {
                    ans += " " + ar[i];
                    i++;
                }
            }
            return ans;
        }
    }
}