public class Decode_Message
{
    public string DecodeMessage(string key, string message)
    {
        char ch = 'a';
        string ans = "";
        List<Map> Map = new List<Map>();
        foreach (var item in key)
        {
            if (item != ' ' && Map.FirstOrDefault(x => x.key == item) == null)
            {
                Map.Add(new Map { key = item, val = ch });
                ch++;
            }
        }
        foreach (var item in message)
        {
            if (item == ' ')
            {
                ans += item;
            }
            else
            {
                ans += Map.FirstOrDefault(x => x.key == item).val;
            }
        }
        return ans;
    }
}

public class Map
{
    public char key { get; set; }
    public char val { get; set; }
}