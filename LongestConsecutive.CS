using System;

public class Class1
{
	public Class1()
	{
        Console.WriteLine(LongestConsecutive([1, 0, 1, 2]));
        Console.WriteLine("Hello, World!");
        int LongestConsecutive(int[] nums)

        {
            var list = new List<int>(nums);
            var sortedList = list.OrderBy(x => x);
            int counter = 0;
            int prev_counter = 0;
            int prev = 0;
            foreach (var n in sortedList)
            {
                if (counter == 0)
                {
                    counter++;
                    prev = n;
                    continue;

                }
                else if (prev + 1 == n)
                {
                    prev = n;
                    counter++;
                }
                else
                {

                    prev_counter = prev_counter <= counter ? counter : prev_counter;
                    prev = n;
                    counter = 1;

                }
            }

            return prev_counter <= counter ? counter : prev_counter;

        }
    }
}
