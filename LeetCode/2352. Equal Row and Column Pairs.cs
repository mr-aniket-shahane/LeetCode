//Console.WriteLine(EqualPairs([[13, 13], [13, 13]]));
//Console.WriteLine(EqualPairs([[3, 1, 2, 2], [1, 4, 4, 4], [2, 4, 2, 2], [2, 5, 2, 2]]));
//Console.WriteLine(EqualPairs([[3, 1, 2, 2], [1, 4, 4, 5], [2, 4, 2, 2], [2, 4, 2, 2]]));
//Console.WriteLine(EqualPairs([[3, 2, 1], [1, 7, 6], [2, 7, 7]]));
//Console.WriteLine(EqualPairs([[11, 1], [1, 11]]));

//int EqualPairs(int[][] grid)
//{
//    List<string> rows = new List<string>();
//    List<string> cols = new List<string>();
//    for (int i = 0; i < grid.Length; i++)
//    {
//        var str = "";
//        for (int j = 0; j < grid.Length; j++)
//        {
//            str += grid[i][j].ToString()+",";
//        }
//        rows.Add(str);
//         str = "";
//        for (int j = 0; j < grid.Length; j++)
//        {
//            str += grid[j][i].ToString()+",";
//        }
//        cols.Add(str);
//    }
//    int total = 0;
//    for (int j = 0; j < rows.Count; j++)
//    {
//        if (cols.Contains(rows[j])){
//            total += cols.Count(s => s == rows[j]);
//        }
//    }
//    return total;
//}