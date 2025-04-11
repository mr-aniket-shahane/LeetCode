public class Reverse_Prefix
{
    public string ReversePrefix(string word, char ch)
    {
        string fStr = "";
        bool isFirst = false;
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] != ch || isFirst)
            {
                fStr += word[i];
            }
            else if (!isFirst)
            {
                fStr += word[i];
                string ans = "";
                for (int j = fStr.Length - 1; j >= 0; j--)
                {
                    ans += fStr[j];
                }
                isFirst = true;
                fStr = ans;
            }
        }
        return fStr;
    }
}