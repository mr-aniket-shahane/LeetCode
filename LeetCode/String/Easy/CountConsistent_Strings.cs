public class CountConsistent_Strings
{
    public int CountConsistentStrings(string allowed, string[] words)
    {
        int ans = 0;
        foreach (string s in words)
        {
            bool isWrong = true;
            foreach (char c in s)
            {
                if (!allowed.Contains(c))
                {
                    isWrong = false;
                }
            }
            if (isWrong)
            {
                ans++;
            }
        }
        return ans;
    }
}