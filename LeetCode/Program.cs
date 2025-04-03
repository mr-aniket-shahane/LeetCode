//Console.WriteLine(Candy([1, 0, 2]));
//Console.WriteLine(Candy([1, 2, 2]));
Console.WriteLine(Candy([60, 80, 100, 100, 100, 100, 100]));
int Candy(int[] ratings)
{
    List<int> result = new List<int>();
    int count = 0;
    for (int i = 0; i < ratings.Length; i++)
    {
        if (i == 0 )
        {
            if ( ratings[i + 1] < ratings[i])
            {
                result.Add(result[i-1]+1);
                count++;
            }
        }else if (i == ratings.Length-1)
        {
            if (ratings[i - 1] < ratings[i])
            {
                count++;
            }
        }
        else if (i-1>=0 && i + 1 <ratings.Length)
        {
            if (ratings[i - 1] < ratings[i] || ratings[i+1] < ratings[i])
            {
                count++;
            }
        }
        else
        {
            result.Add(1);
        }
    }
    return count+ ratings.Length;
}
//Console.WriteLine(IsSubsequence("abxc", "ahbgdc"));


//bool IsSubsequence(string s, string t)
//{


//    List<char> list = new List<char>(s.ToCharArray());
//    List<char> tList = new List<char>(t.ToCharArray());
//    int isfound = list.Count();
//    int counter = 0;
//    foreach (char c in tList)
//    {
//        if (counter < list.Count())
//        {
//            if (c == list[counter])
//            {
//                counter++;
//                isfound--;
//            }
//        }
//        if(isfound == 0)
//        {
//            return true;
//        }
//    }

//    return false;
//}