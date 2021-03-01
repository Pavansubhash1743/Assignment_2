using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2_DIS_Spring2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ShuffleArray(ar1, n1);
            Console.WriteLine("");

            //Question 2 
            Console.WriteLine("Question 2");
            int[] ar2 = { 0, 1, 0, 3, 12 };
            MoveZeroes(ar2);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            int[] ar4 = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum(ar4, target);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Question 5");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            RestoreString(s5, indices);
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            string s61 = "bulls";
            string s62 = "sunny";
            if (Isomorphic(s61, s62))
            {
                Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 19;
            if (HappyNumber(n8))
            {
                Console.WriteLine("{0} is a happy number", n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }

            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = Stocks(ar9);
            if (profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}", profit);
            }
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine();
        }
        private static void ShuffleArray(int[] nums, int n)
        {
            try
            {
                if (nums.Length % 2 == 0 && n > 0 && nums.Length / 2 == n)
                {
                    List<int> result = new List<int>();//creating new list
                    if (nums.Length == 2 * n)
                    {
                        for (int i = 0; i <= 2 * n - 1; i++)
                        {
                            if (i < n)
                            {
                                result.Add(nums[i]);//adding at ith position
                                result.Add(nums[i + n]);//adding at (i+n)th position
                            }
                        }
                    }
                    foreach (object v in result)
                    {
                        Console.Write(v);
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static void MoveZeroes(int[] ar2)
        {
            try
            {
                int count = 0;
                for (int i = 0; i <= ar2.Length - 1; i++)
                {
                    if (ar2[i] != 0)
                    {//checking if value not equal to zero and adding value to a different index count
                        ar2[count] = ar2[i];
                        count++;
                    }
                }
                for (int j = ar2.Length - 1; j >= count; j--)
                {//looping through ar2.length and assigning 0 to remaining indices
                    ar2[j] = 0;
                }
                foreach (object v in ar2)
                {
                    Console.Write(v);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static void CoolPairs(int[] nums)
        {
            try
            {
                Array.Sort(nums);
                int count = 0;
                int i = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])     //checking the same elements
                    {
                        count += j - i;         //incrementing the count
                    }
                    else
                    {
                        i = j;      //moving to the next position
                    }
                }
                Console.WriteLine(count);

            }
            catch (Exception)
            {

                throw;
            }
        }
        private static void TwoSum(int[] nums, int target)
        {
            try
            {
                int check = 0;
                Dictionary<int, int> result = new Dictionary<int, int>();//dictionary declaration
                for (int i = 0; i < nums.Length; i++)
                {
                    check = target - nums[i];//getting target variable
                    if (!result.ContainsKey(check))
                    {//if there is no key adding it key, index to dictionary
                        result.Add(nums[i], i);
                    }
                    else
                    {
                        Console.WriteLine((result[check], i));
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private static void RestoreString(string s, int[] indices)
        {
            try
            {
                //Store index with the string char 
                char[] cArr = new char[s.Length];
                for (int i = 0; i < s.Length; i++)
                {
                    cArr[indices[i]] = s[i];
                }
                Console.WriteLine(new string(cArr));
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static bool Isomorphic(string s1, string s2)
        {
            try
            {
                if (s1.Length != s2.Length)
                {
                    return false;
                }
                var dic1 = new Dictionary<char, char>();
                var dic2 = new Dictionary<char, char>();
                for (int i = 0; i < s1.Length; i++)
                {//checking each charecter against another charector and adding into dictionary
                    if (!dic1.ContainsKey(s1[i]))
                    {
                        dic1.Add(s1[i], s2[i]);
                        if (dic2.ContainsKey(s2[i]))
                        {
                            return false;
                        }
                        dic2.Add(s2[i], s1[i]);
                    }
                    else
                    {
                        if (dic1[s1[i]] != s2[i])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static void HighFive(int[,] items)
        {
            try
            {
                if (items.Length <= 1000 && items.Length >= 1)
                {
                    Dictionary<int, List<int>> some = new Dictionary<int, List<int>>();
                    for (int i = 0; i < items.GetLength(0); i++)
                    {
                        /*creating unique id as key and adding corresponding
                         into values in key,value*/
                        if (some.ContainsKey(items[i, 0]))
                        {
                            List<int> lListNew = some[items[i, 0]];
                            lListNew.Add(items[i, 1]);
                            some[items[i, 0]] = lListNew;
                        }
                        else
                        {
                            List<int> val = new List<int>();
                            val.Add(items[i, 1]);
                            some.Add(items[i, 0], val);
                        }
                    }
                    foreach (KeyValuePair<int, List<int>> entry in some)
                    {
                        var a = entry.Value;
                        a.Sort();
                        a.Reverse();
                        var b = a.GetRange(0, 5);
                        Console.WriteLine((entry.Key, b.Sum() / 5));
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static bool HappyNumber(int n)
        {
            try
            {
                 HashSet<int> p = new HashSet<int>() { n };//hashset declaration
                 while (n != 1)
                 {
                     int sum = 0;
                     while (n > 0)
                     {
                         int d = n % 10;//getting remainder
                         sum += d * d;//squaring the values
                         n = n / 10;//getting the next value
                     }
                     if (!p.Add(sum))//if not in hashset then return false
                     {
                        return false;
                     }
                     n = sum;
                 }
                 return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static int Stocks(int[] prices)
        {
            try
            {
                int max_profit = 0;
                int low = prices[0]; 
                int profit = 0;
                int max = 0;
                for (int i = 0; i < prices.Length; i++)
                {
                    /*comparing the current value with predefined low value*/
                    if (prices[i] < low)
                    {
                        low = prices[i];
                        max = 0;
                    }
                    else if (prices[i] > max)
                    {
                        //checking the value and updating the max value
                        max = prices[i];
                        profit = max - low;
                        max_profit = Math.Max(max_profit, profit);
                    }
                }
                return max_profit;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static void Stairs(int steps)
        {
            try
            {
                int[] sum = new int[steps + 2];
                sum[0] = 0;
                sum[1] = 1;
                for (int i = 2; i <= steps + 1; i++)
                {
                    sum[i] = sum[i - 1] + sum[i - 2];//formula for fibonacci series
                }
                Console.WriteLine("Sum = " + sum[steps + 1]);
            }
            catch (Exception)
            { 
                throw;
            }
        }
    }
}