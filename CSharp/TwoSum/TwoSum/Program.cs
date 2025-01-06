using System;
using System.Collections.Generic;

namespace TwoSumApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 2, 7, 11, 15 };
            int target = 9;
            // 實作 two-sum function
            int[] result = TwoSum(numbers, target);

            Console.WriteLine($"numbers = [{string.Join(", ", numbers)}], target = {target}");
            if (result.Length == 0)
            {
                Console.WriteLine("No solution found.");
            }
            else
            {
                Console.WriteLine($"result = [{string.Join(", ", result)}]");
            }
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                int complement = target - numbers[i];
                if (dict.ContainsKey(complement))
                {
                    return new int[] { dict[complement], i };
                }
                dict[numbers[i]] = i;
            }
            return new int[] { };
        }
    }
}
