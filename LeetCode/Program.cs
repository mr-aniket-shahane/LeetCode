using System.Drawing;
using System.Dynamic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

//**************************************************************************

//FindDifference([-80, -15, -81, -28, -61, 63, 14, -45, -35, -10], [-1, -40, -44, 41, 10, -43, 69, 10, 2]);
//FindDifference([1, 2, 3, 3], [1, 1, 2, 2]);
//IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
//{
//    var n1=nums1.ToList();
//    var n2=nums2.ToList();
//    var n1Ans=new List<int>();
//    for (int i = 0;i< n1.Count(); i++) { 
    
//        if(!n2.Contains(nums1[i]) && !n1Ans.Contains(nums1[i]))
//        {
//            n1Ans.Add(nums1[i]);
//        }
//    }
//    var n2Ans = new List<int>();
//    for (int i = 0; i < n2.Count(); i++)
//    {

//        if (!n1.Contains(nums2[i]) && !n2Ans.Contains(nums2[i]))
//        { 
//            n2Ans.Add(nums2[i]);
//        }
//    }
//    var ans = new List<IList<int>>();
//    ans.Add(n1Ans);
//    ans.Add(n2Ans);
//    return  ans;
//}
///*******************************************************************209. Minimum Size Subarray Sum
//Console.WriteLine(WordPattern("jquery", "jquery"));

//bool WordPattern(string pattern, string s)
//{
//    List<PatternClass> all = new List<PatternClass>();

//    List<char> pat = new List<char>(pattern);
//    List<char> pat_bk = new List<char>(pattern);

//    var allWords = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
//    for (int i = 0; i < pattern.Length; i++)
//    {
//        var d = all.Where(a => a.My_char == pattern[i]);
//        if (d.Count() == 0 && i< allWords.Count())
//        {
//            var dd = all.Where(a => a.My_word == allWords[i]);
//            if (dd.Count() == 0)
//            {
//                all.Add(new PatternClass { My_char = pattern[i], My_word = allWords[i] });
//            }
//        }
//    }
//    var ansWord = "";
//    for (int i = 0; i < pattern.Length; i++)
//    {
//        var d = all.Where(a => a.My_char == pattern[i]);
//        if (d.Count() > 0)
//        {
//            ansWord += all.First(a => a.My_char == pattern[i])?.My_word + " ";
//        }
//    }
//    if (ansWord.Trim().ToLower().Equals(s.Trim().ToLower()))
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}
//public class PatternClass
//{
//    public char My_char;
//    public string My_word;
//}
////*******************************************************************209. Minimum Size Subarray Sum
//Console.WriteLine(CanConstruct("bg", "efjbdfbdgfjhhaiigfhbaejahgfbbgbjagbddfgdiaigdadhcfcj"));
////Console.WriteLine(MinSubArrayLen(213, [12,28,83,4,25,26,25,2,25,25,25,12]));
//bool CanConstruct(string ransomNote, string magazine)
//{
//    var mg = magazine.ToCharArray();
//    List<char> rn_List = new (ransomNote.ToCharArray().ToList());
//    List<char> mg_List = new (magazine.ToCharArray().ToList());
//    for (int i = 0;i< mg.Length; i++)
//    {
//        if(rn_List.Contains(mg[i]))
//        {
//            var Count = rn_List.Count(a=>a==mg[i]);
//            var CountMG = mg_List.Count(a=>a==mg[i]);
//            if (Count == CountMG || Count < CountMG)
//            {
//                rn_List.RemoveAll(a=>a==mg[i]);
//            }
//        }    
//    }
//    if (rn_List.Count == 0)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}







//Console.WriteLine(CloseStrings("abc", "bca"));
//Console.WriteLine(CloseStrings("a", "aa"));
//Console.WriteLine(CloseStrings("cabbba", "abbccc"));
//Console.WriteLine(CloseStrings("uau", "ssx"));
//bool CloseStrings(string word1, string word2)
//{
//    List<char> a = word1.ToLower().ToCharArray().ToList().OrderBy(a => a).ToList();
//    List<char> a_bk = new List<char>(a);
//    var b = word2.ToLower().ToCharArray().ToList().OrderBy(a => a).ToList();
//    List<char> b_bk = new List<char>(b);
//    if (a.Count != b.Count)
//    {
//        return false;
//    }
//    else
//    {
//        var size = a.Count;
//        int unqSize = a.Distinct().Count();
//        List<int> aString = new();
//        List<int> bString = new();
//        foreach (var item in b_bk)
//        {
//            if (!a.Contains(item))
//            {
//                return false;
//            }
//        }
//        foreach (var item in a_bk)
//        {
//            if (a.Contains(item))
//            {
//                var unqcount = a.Where(s => s == item).Count();
//                aString.Add(unqcount);
//                a.RemoveAll(x => x == item);
//            }

//        }
//        foreach (var item in b_bk)
//        {
//            if (b.Contains(item))
//            {
//                var unqcount = b.Where(s => s == item).Count();
//                bString.Add(unqcount);
//                b.RemoveAll(x => x == item);
//            }
//        }
//        aString = aString.OrderByDescending(a => a).ToList();
//        bString = bString.OrderByDescending(a => a).ToList();
//        for (int i = 0; i < unqSize; i++)
//        {
//            if (aString[i] != bString[i])
//                return false;
//        }

//    }
//    return true;
//}
////*******************************************************************71. Simplify Path
//Console.WriteLine(SimplifyPath("/../"));
//string SimplifyPath(string path)
//{
//    var ar = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
//    Stack<string> paths = new Stack<string>();
//    for (int i = 0; i < ar.Length; i++)
//    {
//        if (ar[i] == ".." && paths.Count > 0)
//        {
//            paths.Pop();
//        }
//        else if (ar[i] != "." && ar[i] != "..")
//        {
//            paths.Push(ar[i]);
//        }
//    }
//    int newSize = paths.Count;
//    ar = new string[newSize];
//    for (int i = 0; i < newSize; i++)
//    {
//        ar[i] = "/"+paths.Pop();
//    }
//    var dd=  ar.ToList();
//    dd.Reverse();
//    string ans = "";
//    for (int i = 0; i < newSize; i++)
//    {
//         ans=ans + dd[i];
//    }
//    return ans;
//}

//AsteroidCollision([-2, 1, -2, -2]);
////AsteroidCollision([5, 10, -5]);
////AsteroidCollision([2, -1, -2, -2]);
////AsteroidCollision([10, 2, -5]);
////AsteroidCollision([-1, -2, 1, 2]);
////AsteroidCollision([1, -2, 10, -5]);

////*******************************************************************735. Asteroid Collision
//int[] AsteroidCollision(int[] asteroids)
//{
//    bool isInLoop = true;
//    List<int> list_bk = new List<int>(asteroids);
//    List<int> list = new List<int>();
//    while (isInLoop)
//    {
//        isInLoop = false;
//        if (list_bk.Count < 2)
//            break;
//        for (int i = 0; i < list_bk.Count; i++)
//        {
//            if (i == list_bk.Count - 1)
//            {
//                list.Add(list_bk[i]);
//            }
//            else
//            if (list_bk[i] < 0 || (list_bk[i] > 0 && list_bk[i + 1] > 0))
//            {

//                list.Add(list_bk[i]);
//                if (i + 1 == list_bk.Count - 1)
//                {
//                    list.Add(list_bk[i + 1]);
//                    break;
//                }
//                continue;
//            }
//            else
//            {
//                isInLoop = true;


//                if ((list_bk[i] == (list_bk[i + 1] * (-1))))
//                {
//                    i++;

//                    continue;

//                }
//                else if (list_bk[i] > (list_bk[i + 1] * (-1)))
//                {
//                    list.Add(list_bk[i]);
//                    i++;
//                }
//                else if (i + 1 == list_bk.Count)
//                {
//                    list.Add(list_bk[i]);
//                }
//                else
//                {
//                    list.Add(list_bk[i + 1]);
//                    i++;
//                }
//            }
//        }
//        list_bk = new();
//        list_bk = list;
//        list = new();
//    }
//    return list_bk.ToArray();
//}
//*******************************************************************202.Happy Number
//Console.WriteLine(IsHappy(10019));
//bool IsHappy(int n)
//{
//    int original = n;
//    int sq = 0;
//    while (sq != 1)
//    {
//        sq = getSq(n);
//        if (sq == 1)
//        {
//            return true;
//        }
//        else if (sq == 4)
//        {
//            return false;
//        }
//        else 
//        {
//            n = sq;
//        }
//    } 
//    return true;
//}
// int getSq(int n)
//{
//    int ans = 0;
//    var data = getintArray(n);
//    for (int i = 0; i < data.Length; i++)
//    { 
//        ans+= data[i]* data[i];
//    }
//        return ans;
//}
//int[] getintArray(int n)
//{
//    string s = n.ToString();
//    var a= s.ToCharArray();
//    int[] array = new int[a.Length];
//    for (int i = 0; i < a.Length; i++)
//    {
//        array[i] = Int32.Parse(a[i].ToString());
//    }

//    return array;
//}
//*******************************************************************394. Decode String
//Console.WriteLine(DecodeString("3[a]2[bc]"));
//Console.WriteLine(DecodeString("3[a2[c]]")); //accaccacc

//string DecodeString(string s)
//{

//    string ans = "";
//    string tempNum = "";
//    bool needPoP = false;
//    bool cal = true;
//    bool needActualPoP = false;
//    Stack<char> stack = new Stack<char>();
//    Stack<char> stack1 = new Stack<char>();
//    int counter = 0;
//    foreach (char c in s.Reverse())
//    {
//        cal = true;
//        counter++;
//        if (c != '[' && !needPoP)
//        {
//            stack.Push(c);
//        }
//        else if (c == '[')
//        {
//            needPoP = true;
//        }
//        else
//        {
//            tempNum += c;
//            var isNumeric = int.TryParse(tempNum, out _);

//            if (!isNumeric || (isNumeric && s.Length == counter))
//            {
//                tempNum.Remove(tempNum.Length - 1);
//                var r = tempNum.ToList();
//                if(!isNumeric)
//                    r.RemoveAt(r.Count - 1);
//                //.RemoveAt(tempNum.Length - 1);
//                string v = "";
//                while (cal)
//                {
//                    var vv = stack.Pop();
//                    if (vv == ']')
//                    {
//                        cal = false;
//                        tempNum = "";
//                    }
//                    else
//                    {
//                        v += vv;
//                        int my_num = Int32.Parse(new string(r.ToArray()));
//                        while (my_num > 0)
//                        {
//                            stack1.Push((char)vv);
//                            my_num--;
//                        }
//                    }
//                }
//                //;
//                stack.Push(c);

//            }
//        }
//    }
//    return ans;
//}

//string num = "";
//string chr = "";
//bool found_num = false;
//bool found_char = false;
//string ans = "";
//foreach (char c in s)
//{
//    if (!found_num && !found_char)
//    {
//        if (c != '[')
//        {
//            num += c;
//        }
//        else if (c == '[')
//        {
//            found_num = true;
//            found_char = false;
//            continue;
//        }
//    }
//    if (!found_char && found_num)
//    {
//        if (c != ']')
//        {
//            chr += c;
//        }
//        else if (c == ']')
//        {
//            found_char = true;
//            found_num = false;
//        }
//    }
//    if (found_char && !found_num)
//    {
//        int total = Int32.Parse(num);
//        while (total >0)
//        {
//            ans += chr;
//            total--;
//        }
//            found_char = false;
//        found_num = false;
//        num = "";chr = "";
//    }
//}
//    return ans;
//} 
/// *************************************************************************  1207. Unique Number of Occurrences
//Console.WriteLine(UniqueOccurrences([3, 0, 3]));
//Console.WriteLine(UniqueOccurrences([1, 2, 2, 1, 1, 3]));
//Console.WriteLine(UniqueOccurrences([1, 2]));
//Console.WriteLine(UniqueOccurrences([-3, 0, 1, -3, 1, 1, 1, -3, 10, 0]));

//bool UniqueOccurrences(int[] arr)
//{
//    List<int> a = new List<int>(arr);
//    List<int> a2 = new List<int>(arr);
//    List<int> app = new List<int>();
//    foreach (int i in a2)
//    {
//        if (a.Contains(i))
//        {
//            int count = a.Where(x => x == i).Count();
//            if (app.Contains(count))
//            {
//                return false;
//            }
//            else
//            {
//                app.Add(count);
//                a.RemoveAll(s => s == i);
//            }
//        }
//    }
//    return true;
//}
///// *************************************************************************42. Trapping Rain Water
//Console.WriteLine(RemoveStars("leet**cod*e"));
//Console.WriteLine(RemoveStars("erase*****"));
//string RemoveStars(string s)
//{
//    int size = s.Length;
//    int counter = -1;
//    List<char> list = new List<char>();
//    for (int i = 0; i < size; i++)
//    {
//        if(s[i] != '*')
//        {
//            list.Add(s[i]);
//            counter++;
//        }
//        else
//        {
//            list.RemoveAt(counter);
//            counter--;
//        }
//    }
//    return new string(list.ToArray());
//}
///
/// *************************************************************************42. Trapping Rain Water
//Console.WriteLine(Trap([3, 0, 3]));
//int Trap(int[] height)
//{
//    int highest = 0;
//    int highest_at = 0;
//    int ans = 0;
//    int size = height.Count();
//    for (int i = 0; i < size; i++)
//    {
//        if (i >= 2)
//        {
//            if(highest >= height[i])
//            {
//                if (i- highest_at>2)
//                {


//                }
//            }
//        }
//        else
//        {
//            if (highest < height[i])
//            {
//                highest_at = i;
//                highest = height[i];
//            }
//        }
//    }
//    return ans;
//}
/////**********************************************************************238. Product of Array Except Self
//for (int i = 0; i < d.Length; i++)
//{
//    Console.WriteLine(d[i]);
//}
//int[] ProductExceptSelf(int[] nums)
//{
//    int[] ar = new int[nums.Length];
//    List<DataProduct> dataProducts = new List<DataProduct>();

//    for (int i = 0; i < nums.Length; i++)
//    {
//        var data = dataProducts.FirstOrDefault(ar => ar.key == nums[i]);
//        if (data == null)
//        {
//            var list = nums.ToList();
//            list.RemoveAt(i); list.Remove(1);

//            if (list.Contains(0))
//            {
//                ar[i] = 0;
//                dataProducts.Add(new DataProduct { key = nums[i], value = 0 });
//            }
//            else
//            {
//                ar[i] = list.Aggregate(1, (product, a) => product * a); ;
//                dataProducts.Add(new DataProduct { key = nums[i], value = ar[i] });
//            }
//        }
//        else
//        {
//            ar[i] = data.value;
//        }
//    }
//    return ar;
//}
//public class DataProduct
//{
//    public int key { get; set; }
//    public int value { get; set; }
//}

///////**********************************************************************334. Increasing Triplet Subsequence
//Console.WriteLine(IncreasingTriplet([1, 2, 1, 2, 1, 2, 1, 2, 1, 2]));
////Console.WriteLine(IncreasingTriplet([1, 5, 0, 4, 1, 3]));
////Console.WriteLine(IncreasingTriplet([1,5,0,4,1,3]));
////Console.WriteLine(IncreasingTriplet([1, 2, 3, 4, 5]));
////Console.WriteLine(IncreasingTriplet([5, 4, 3, 2, 1]));
////Console.WriteLine(IncreasingTriplet([2, 1, 5, 0, 4, 6]));
////Console.WriteLine(IncreasingTriplet([20, 100, 10, 12, 5, 13]));
////Console.WriteLine(IncreasingTriplet([1, 2, 1,2, 1, 2, 1, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1]));
//bool IncreasingTriplet(int[] nums)
//{
//    if (nums.Length < 3) return false;
//    else
//    {
//        List<int> i = new List<int>(nums);
//        var j = new List<int>(nums);
//        var k = new List<int>(nums);
//        var k_BK = new List<IJK>();
//        i.RemoveAt(nums.Length - 1);
//        i.RemoveAt(nums.Length - 2);

//        j.RemoveAt(nums.Length - 1);
//        j.RemoveAt(0);

//        k.RemoveAt(1);
//        k.RemoveAt(0);
//        for (int l = 0; l < nums.Length - 2; l++)
//        {
//            var data = j.Where(a => a > nums[l]).Distinct().ToList();
//            foreach (int aa in data)
//            {
//                if (data.Count > 0)
//                {
//                    var k_data = k.FirstOrDefault(a => a > aa);

//                    if (k_data > aa)
//                    {
//                        return true;
//                    }

//                }
//                k.RemoveAt(0);
//            }
//            j.RemoveAt(0);

//        }
//        return false;
//    }
//}
//public class IJK
//{
//    public int i { get; set; }
//    public int j { get; set; }
//    public int k { get; set; }
//}
//bool IncreasingTriplet(int[] nums)
//{
//    bool ans = false;
//    var size = nums.Length;
//    for (int i = 0; i < size - 2; i++)
//    {
//        for (int j = i + 1; j < size - 1; j++)
//        {
//            for (int k = j + 1; k < size; k++)
//            {
//                var temp = k;
//                if (nums[i] < nums[j] && nums[j] < nums[k])
//                {
//                    return true;
//                }
//                if (k + 1 < size - 1)
//                {
//                    while (nums[k] == nums[k + 1])
//                    {
//                        if (k + 1 < size - 1)
//                            k++;
//                        else
//                            break;
//                    }
//                }
//            }
//            if (j + 1 < size - 1)
//            {
//                while (nums[j] == nums[j + 1])
//                {
//                    if (j + 1 < size - 1)
//                        j++;
//                    else
//                        break;
//                }
//            }
//        }
//        if (i + 1 < size - 1)
//        {
//            while (nums[i] == nums[i + 1])
//            {
//                if (i + 1 < size - 1)
//                    i++;
//                else
//                    break;
//            }
//        }
//    }
//    return ans;
//}
///**********************************************************************Remove Duplicates from Sorted Array II
//Console.WriteLine(RemoveDuplicates([1, 1, 1, 1, 2, 2, 3]));
//Console.WriteLine(RemoveDuplicates([0, 0, 1, 1, 1, 1, 2, 3, 3]));

////[1,1,2,2,3]

//int RemoveDuplicates(int[] nums)
//{  
//    int current = 0; 
//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (i == 0 || i == 1 || nums[current - 2] != nums[i])
//        {
//            nums[current] = nums[i];
//            current++;
//        }

//    } 
//    return current;
//}

///**********************************************************************

//Console.WriteLine(Compress(['a', 'a', 'a','b', 'b', 'a', 'a',]));
//Console.WriteLine(Compress(['a',   'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b',  'b', 'b']));
//int Compress(char[] chars)
//{
//    if (chars.Length != 1)
//    {
//        List<char> result = new List<char>(chars);

//        int counter = 0;
//        for (int i = 0; i < result.Count; i++)
//        {
//            chars[counter] = result[i];
//            Console.WriteLine(chars[counter]);
//            counter++;
//            int count = 1;
//             for (int j = i+1;j<result.Count; j++)
//            {
//                if (result[i] == result[j])
//                {
//                    count++;
//                    i++;
//                }
//                else
//                    break;
//            }
//            if (count > 1)
//            {
//                var d = (count).ToString().ToCharArray();
//                for (int k = 0; k < d.Length; k++)
//                {
//                    chars[counter] = d[k];
//                    Console.WriteLine(chars[counter]);
//                    counter++;
//                }
//            } 
//        }
//        chars = new string(chars).Remove(counter).ToCharArray();
//        return chars.Length;
//    }
//    else
//    {
//        return 1;
//    }
//}
////int Compress(char[] chars)
//{
//    if (chars.Length != 1)
//    {
//        List<char> result = new List<char>(chars);
//        List<char> uniqe = result.Distinct().ToList();

//        var size = uniqe.Count;
//        int counter = 0;
//        for (int i = 0; i < size; i++)
//        {
//            chars[counter] = uniqe[i];
//            Console.WriteLine(chars[counter]);
//            counter++;
//            var count = result.Where(x => x == uniqe[i]).Count();
//            if (count > 1)
//            {
//               var d = (count).ToString().ToCharArray();
//                for(int k=0; k < d.Length; k++)
//                {
//                    chars[counter] = d[k];
//                Console.WriteLine(chars[counter]);
//                    counter++;
//                }
//            }
//        }
//        chars = new string(chars).Remove(counter).ToCharArray();
//        return chars.Length;
//    }
//    else
//    {
//        return 1;
//    }
//}
///******************************************************* 88. Merge Sorted Array
///
//var r = IntToRoman(1994);
////Console.WriteLine(r);
//int[] nums1 = [-1, 1, 0, -3, 3] ;
//ProductExceptSelf(nums1);
//int[] ProductExceptSelf(int[] nums)
//{
//    int[] ar= new int[nums.Length];
//    for (int i = 0; i < nums.Length; i++)
//    {
//        var list =nums.ToList();
//         list.RemoveAt(i);
//        list.Remove(1); 
//        if (list.Contains(0))
//        {
//            ar[i] = 0;
//        }
//        else
//        { 
//            ar[i] = list.Aggregate(1, (product, a) => product * a); ;
//        }
//    }
//    return ar;
//}A
///******************************************************* 88. Merge Sorted Array
///
//var r = IntToRoman(1994);
//Console.WriteLine(r);
//int[] nums1 = [-1, 0, 0, 3, 3, 3, 0, 0, 0], nums2 = [1, 2, 2]; int m = 6, n = 3;
//Merge(nums1, m, nums2, n);
//void Merge(int[] nums1, int m, int[] nums2, int n){
//    List<int> l = new List<int>();
//    l.AddRange(nums1);
//    l.RemoveRange(m, nums1.Length - m);
//    l.AddRange(nums2);
//    l= l.OrderBy(x => x).ToList();
//    for (int i = 0; i < l.Count; i++) {
//        nums1[i] = l[i];
//        Console.WriteLine(nums1[i]);
//    }

//}

//void Merge(int[] nums1, int m, int[] nums2, int n)
//{
//    int nums2Counter = 0, temp = 0;
//    int nums1Counter = 0;
//    for (int i = 0; i < m + n; i++)
//    {
//        if (i >= m)
//        {
//            nums1[i] = nums2[nums2Counter];
//            nums2Counter++;
//        }
//        else if (n > 0)
//        {

//            if (nums1[nums1Counter] <= nums2[nums2Counter])
//            {
//                nums1Counter++;
//            }
//            else
//            {
//                temp = nums1[nums1Counter];
//                nums1[nums1Counter] = nums2[nums2Counter];
//                nums2[nums2Counter] = temp;

//            }
//        }
//    }
//    for (int i = 0; i < m + n; i++)
//    {
//        Console.WriteLine(nums1[i]);
//    }
//}
///******************************************************* 345. Reverse Vowels of a String
///

////0,1,2,3,4,5,6
////1,2,3,4,5,6,7
//Rotate([1, 2,3], 3);
//Rotate1([1, 2,3], 3);
////Console.WriteLine(r);
//void Rotate1(int[] nums, int k)
//{
//    var list_1st_part = new List<int>();
//    var list_2nd_part = new List<int>();

//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (i < nums.Length - k)
//        {
//            list_1st_part.Add(nums[i]);
//        }
//        else
//        {
//            list_2nd_part.Add(nums[i]);
//        }
//    }
//    list_2nd_part.AddRange(list_1st_part);
//    for (int i = 0; i < list_2nd_part.Count; i++)
//    {
//        nums[i] = list_2nd_part[i];
//    }
//    for (int i = 0; i < nums.Length; i++)
//    {
//        Console.WriteLine(nums[i]);
//    }
//}

//void Rotate(int[] nums, int k)
//{
//    for (int j = 0; j < k; j++)
//    {
//        var temp = 0;
//        var isTrue = true;
//        for (int i = nums.Length - 1; i >= 0; i--)
//        {
//            if (isTrue)
//            {
//                temp = nums[i];
//                isTrue = false;
//            }
//            if (i == 0)
//            {
//                nums[i] = temp;
//            }
//            else
//            {
//                nums[i] = nums[i - 1];
//            }
//        }
//    }
//    for (int i = 0; i < nums.Length; i++)
//    {
//        Console.WriteLine(nums[i]);
//    }
//}

///******************************************************* 345. Reverse Vowels of a String
///
//var r = IntToRoman(1994);
//Console.WriteLine(r);

//string IntToRoman(int num)
//{
//    var resp = "";
//    List<Roman> sd = new List<Roman> { new Roman { Key= "I", value = 1 },
//            new Roman { Key= "V", value = 5 },
//            new Roman { Key= "X", value = 10 },
//            new Roman { Key= "L", value = 50},
//            new Roman { Key= "C", value = 100 },
//            new Roman { Key= "D", value = 500 },
//            new Roman { Key= "M", value = 1000 },
//            new Roman { Key= "IV", value = 4 },
//            new Roman { Key= "IX", value = 9 },
//            new Roman { Key= "XL", value = 40 },
//            new Roman { Key= "XC", value = 90 },
//            new Roman { Key= "CD", value = 400 },
//            new Roman { Key= "CM", value = 900 },
//        };
//    sd = sd.OrderByDescending(a => a.value).ToList();
//    Console.WriteLine(sd);
//    for (int i = 0; i < sd.Count; i++)
//    {
//        if (num >= sd[i].value)
//        {
//            var no = num / sd[i].value;
//            while (no > 0)
//            {
//                num=num-sd[i].value;
//                resp += sd[i].Key;
//                no--;
//            }

//        }
//        else
//        {
//            continue;
//        }
//    } 

//    return resp;

//}
//public class Roman
//{
//    public int value { get; set; }
//    public string Key { get; set; }
//}
///******************************************************* 345. Reverse Vowels of a String
///
//var r  = ReverseVowels("IceCreAm");
//Console.WriteLine(r);
//string ReverseVowels(string s)
//{
//    List<char> list = new List<char>(['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U']);
//    List<char> currentChar = new List<char>();

//    int totalVovels = 0;
//    for (int i = 0; i < s.Length; i++)
//    {
//        if (list.Contains(s[i]))
//        {
//            totalVovels++;
//            currentChar.Add(s[i]); 
//        }
//    } 
//    var ch=s.ToCharArray();
//    for (int i = 0; i < ch.Length; i++)
//    {
//        if (list.Contains(ch[i]))
//        {
//            if (totalVovels> 0)
//            {
//                ch[i] = currentChar[totalVovels-1];
//                totalVovels--;
//            } 
//        }
//    }
//    return new string(ch);
//}
///******************************************************* 605. Can Place Flowers

//Console.WriteLine(CanPlaceFlowers([0,0,0,0], 3));
//bool CanPlaceFlowers(int[] flowerbed, int n)
//{
//    int noOfPlant = 0;

//    if (flowerbed.Length > 1)
//    {
//        if (flowerbed.Length > n)
//        {
//            for (int i = 0; i < flowerbed.Length; i++)
//            {
//                if (flowerbed[i] == 0)
//                {
//                    if (i - 1 >= 0 && i + 1 < flowerbed.Length)
//                    {
//                        if (flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
//                        {
//                            flowerbed[i] = 1;
//                            noOfPlant += 1;
//                            i++;
//                        }
//                    }
//                    else
//                    {
//                        if (i == 0)
//                        {
//                            if (flowerbed[i + 1] == 0)
//                            {
//                                flowerbed[i] = 1;
//                                noOfPlant += 1;
//                                i++;
//                            }
//                            //noOfPlant = flowerbed[i + 1] == 0 ? noOfPlant + 1 : noOfPlant;
//                        }
//                        if (i == flowerbed.Length - 1)
//                        {
//                            noOfPlant = flowerbed[i - 1] == 0 ? noOfPlant + 1 : noOfPlant;
//                        }
//                    }
//                }
//            }
//        }

//    }
//    else
//    {
//        if (flowerbed[0] == 0)
//        {
//            noOfPlant++;
//        }
//    }
//    return noOfPlant >= n ? true : false;
//}



//******************************************************** 1071. Greatest Common Divisor of Strings

//using System.Numerics;

//Console.WriteLine(GcdOfStrings("ABCDEF", "ABC"));
//string GcdOfStrings(string str1, string str2)
//{
//    string my_sub = ""; 
//    string my_sub2 = "";
//    char[] my_str = str2.ToCharArray();
//    for (int i = 0; i < my_str.Length; i++)
//    {
//        my_sub += my_str[i];
//        var sub = str1.Split(my_sub);
//        var sub1 = str2.Split(my_sub);
//        if (sub[0] == str1)
//        {
//            my_sub = "";
//            break;
//        }
//        if (sub.Count(s => s != "")==0 && sub1.Count(s => s != "") == 0)
//        {
//            my_sub2 = my_sub;
//        }
//        else if (sub.Count(s => s != "") == 0 || sub1.Count(s => s != "") == 0)
//        {
//            my_sub = "";
//        }

//    } 
//    return my_sub2;
//}

////******************************************************* Merge Strings Alternately
//using System.Net.Http.Headers;

//string word1 = "abc", word2 = "q";
//MergeAlternately(word1, word2);
//string MergeAlternately(string word1, string word2)
//{
//    int size = Math.Max(word2.Length, word1.Length);


//    char[] chars = word1.ToCharArray();
//    char[] chars2 = word2.ToCharArray();
//    int counter = 0;
//    string resp = "";
//    for (int i = 0; i < size; i++)
//    {
//        if (i < word1.Length)
//        {
//            resp+=(chars[i]);
//        }
//        if (i < word2.Length)
//        {
//            resp += (chars2[i]);
//        }
//    } 
//    Console.WriteLine(resp);
//    return resp;
//}


//*************************************************** ZigZag Convert
//using System.ComponentModel.DataAnnotations;

//string s = "AB"; int numRows = 1;
//Convert(s, numRows);
//string Convert(string s, int numRows)
//{
//    string resp = "";
//    if (numRows > 1)
//    {
//        var ar = s.ToCharArray();

//        int skip = ((numRows - 1) + (numRows - 2)) + 1;
//        int max_Skip = skip;

//        int f_skip = 0; int l_skip = 0;
//        bool isSkipped = false;
//        for (int i = 0; i < numRows; i++)
//        {
//            isSkipped = false;
//            if (i == 0 || i == numRows - 1)
//            {
//                l_skip = f_skip = max_Skip;
//                skip = i;
//                //Console.WriteLine(f_skip + "-" + l_skip);
//                for (int j = i; j < ar.Length; j++)
//                {
//                    if (j == skip)
//                    {
//                        resp += ar[j];
//                        skip = isSkipped ? j + l_skip : j + f_skip;
//                        isSkipped = !isSkipped;
//                        //Console.WriteLine(ar[i]);
//                    }
//                }
//            }
//            else
//            {
//                f_skip = max_Skip - i;
//                l_skip = 2 * i == 0 ? f_skip : 2 * i;
//                skip = i;
//                //Console.WriteLine(f_skip + "-" + l_skip);
//                for (int j = i; j < ar.Length; j++)
//                {
//                    if (j == skip)
//                    {
//                        resp += ar[j];
//                        skip = isSkipped ? j + l_skip : j + f_skip - i;
//                        isSkipped = !isSkipped;
//                        //Console.WriteLine(ar[i]);
//                    }
//                }
//            }

//        }
//    }
//    else
//        resp = s;
//    Console.WriteLine(resp);
//    return resp;
//}

//s = "PAYPALISHIRING", numRows = 3
//      P  I
//      A LS
//      YA H
//      P  I

//*************************************************** Pro
//int[] citations =
//[-1, 1, 0, -3, 3];
//productExceptSelf(citations);

//int[] productExceptSelf(int[] nums)
//{

//    int n = nums.Length;
//    int[] ans = new int[n];
//    int prodcut = 1;
//    for (int i=0;i<n;i++){
//        if (nums[i] != 0)
//            prodcut *= nums[i];
//    }
//    for (int i = 0; i < n; i++)
//    {
//        if (nums[i] !=0)
//            ans[i] = prodcut / nums[i];
//        else
//            ans[i] = 0;
//        Console.WriteLine(ans[i]);
//    }
//    return ans;
//} 


//*************************************************** H index

//int[] citations = [3, 0, 6, 1, 5];
//HIndex(citations);
//int HIndex(int[] citations)
//{
//    var f = 0;
//    var cit = 0;
//    List<int> result = new List<int>();
//    result.AddRange(citations);
//    for (int i = 0; i < citations.Length; i++)
//    {
//        cit=Math.Max(cit, citations[i]);
//        var a = citations[i];
//        var found = result.FindAll(x => x >= a).Count;
//        if(found> citations.Length / 2)
//        {
//            if (a >= cit) { 
//            f=a;
//        Console.WriteLine(f);
//            }
//        }
//    }

//    return f;
//}



///************************************************ Jump 2
///  
//int[] nums = [2, 1, 1, 1, 4];
//Console.WriteLine(Jump(nums));
//int Jump(int[] nums)
//{
//    int MaxR = 0;
//    int totalJump = 0;
//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (i > MaxR)
//        {
//            return 0;
//        }
//        MaxR += nums[i];
//        if (MaxR >= nums.Length - 1)
//        {
//            return totalJump;
//        }
//            totalJump++;
//    }
//    return 0;
//}


///*************************************************** jump
///
//int[] nums = [2,  0, 0];
//Console.WriteLine(CanJump(nums));
//bool CanJump(int[] nums)
//{
//    int MaxR = 0;
//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (i > MaxR)
//        {
//            return false;
//        }
//        MaxR = Math.Max(MaxR, i + nums[i]);
//        if (MaxR >= nums.Length-1)
//        {
//            return true;
//        }
//    }
//    return false;
//}




///  *************************************************189. Rotate Array

//int[] nums = [-1, -100, 3, 99]; int k = 2;
//Rotate(nums, k);
//void Rotate(int[] nums, int k)
//{
//    List<int> list = new List<int>();
//    int rotateTill = nums.Length;
//    for (int i = k + 1; i < rotateTill; i++)
//    {
//        list.Add(nums[i]);
//        Console.WriteLine(nums[i]);
//        if (i == rotateTill - 1 && rotateTill != k+1)
//        {
//            i = -1;
//            rotateTill = k + 1;
//        }
//    }
//    nums = [];
//    nums = list.ToArray();
//}








//MaxProfit([2, 1, 2, 0, 1]);

//int MaxProfit(int[] prices)
//{
//    int maxprofit = 0;

//    // 从第二个元素开始考虑,
//    for (int i = 1; i < prices.Length; i++)
//    {
//        //
//        if (prices[i] > prices[i - 1])
//        {
//            // 只要能产生利润, 快速交易
//            maxprofit += prices[i] - prices[i - 1];
//        }
//    }
//    Console.WriteLine(maxprofit);
//    //
//    return maxprofit;
//}
//    int profit = 0;
//    int buy = -1;
//    int sell = -1;
//    for (int i = 0; i < prices.Length; i++)
//    {
//        if (i != prices.Length - 1)
//        {
//            if (buy == -1)
//            {
//                if (prices[i] < prices[i + 1])
//                {
//                    buy = prices[i];
//                }
//                else
//                {
//                    continue;
//                }
//            }
//            else
//            {
//                if (prices[i] > prices[i + 1])
//                {
//                    sell = prices[i];
//                    profit += sell - buy;
//                    buy = -1;
//                }
//                else { continue; }
//            }
//        }

//        else if(buy!= -1){
//                sell = prices[i];
//                profit += sell - buy;
//                buy = -1;
//        }
//    }
//    Console.WriteLine(profit);
//    return profit;
//}

//MostCommonWord(
//"a, a, a, a, b,b,b,c, c",
//["a"]);
//string MostCommonWord(string paragraph, string[] banned)
//{
//    paragraph = paragraph.Trim().Replace(",", " ");
//    paragraph = paragraph.Trim().Replace("?", " ");
//    paragraph = paragraph.Trim().Replace("','", " ");
//    paragraph = paragraph.Trim().Replace(".", " ");
//    paragraph = paragraph.Trim().Replace("!", " ");
//    Console.WriteLine(paragraph);
//    var sArray = paragraph.Split(" ");
//    var MaxCount = 0;
//    char a = '.';
//    char.IsPunctuation(a);

//    var word = "";
//    for (int i = 0; i < sArray.Length; i++)
//    {
//        if (sArray[i].Trim().Length > 0)
//        {
//            sArray[i] = checkPunctualtion(sArray[i].Trim());


//            if (!banned.Contains(sArray[i]))
//            {
//                var count = sArray.Where(a => a.ToLower() == (sArray[i].ToLower())).Count();
//                if (MaxCount < count)
//                {
//                    MaxCount = count;
//                    word = sArray[i];
//                }
//            }
//            else
//            {
//                continue;
//            }
//        }
//    }
//    Console.WriteLine(word);
//    return word.ToLower();

//}
//string checkPunctualtion(string a)
//{

//    if (char.IsPunctuation(a[a.Length - 1]))
//    {
//        return a.Remove(a.Length - 1).ToLower();
//    }
//    return a.ToLower();
//}

//int[] nums = [0, 0, 1, 1, 1, 1, 2, 3, 3];
//int[] nums1 = [0, 0, 1, 1, 2, 3, 3];
//RemoveDuplicates(nums);

//int RemoveDuplicates(int[] nums)
//{
//    List<int> result = new List<int>();
//    var unq = nums.Distinct().ToList();
//    foreach (var item in unq)
//    {
//        var allElement = nums.Where(i => i == item);

//        var count = allElement.Count();
//        if (count > 2)
//        {
//            result.AddRange(allElement.Take(2));
//        }
//        else
//        {
//            result.AddRange(allElement);
//        }
//    }
//    nums = new int[result.Count()];
//    var d = result.ToArray();
//    Array.Copy(d, nums, result.Count());
//    Console.WriteLine(nums.Count());
//    Console.WriteLine(string.Join(", ", nums));
//    return 0;

//}