using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace LeetCode
{
    public class Solution
    {
        /// <summary>
        /// Given an array of integers, a lucky integer is an integer that has a frequency in the array equal to its value
        /// </summary>
        /// <param name="arr">Array of integers</param>
        /// <returns>The lucky number or -1 if there is none</returns>
        public int FindLucky(int[] arr)
        {
            Dictionary<int,int> dict = new Dictionary<int,int>();
            for (int i = 0;i<arr.Length;i++)
            {
                dict[arr[i]] = dict.GetValueOrDefault(arr[i],0)+1;
            }

            var sortedDictionary = (from entry in dict orderby entry.Value descending select entry).ToDictionary();
            foreach (var key in sortedDictionary.Keys)
            {
                if (dict.GetValueOrDefault(key) == key)
                {
                    return key;
                }
            }
            return -1;
        }

        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        /// </summary>
        /// <param name="arr">Array of integers</param>
        /// <param name="target">Target sum for the array integers</param>
        /// <returns>the index of the two integers that add up to the target value</returns>
        public int[] TwoSum(int[] arr, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++) 
            {
                int complementaryNumber = target - arr[i];
                if (dict.ContainsKey(complementaryNumber))
                {
                    return [dict[complementaryNumber],i];
                }
                dict[arr[i]] = i;
            }
            return [];
        }

        public LinkedList<int> AddTwoNumbers(LinkedList<int> list1, LinkedList<int> list2)
        {
            string number1="";
            list1.Reverse().ToList().ForEach(x => number1 += x.ToString());
            int  sum1 = int.Parse(number1);
            string number2 = "";
            list2.Reverse().ToList().ForEach (x => number2 += x.ToString());
            int sum2 = int.Parse(number2);
            int total=sum1 + sum2;
            LinkedList<int> ret = new LinkedList<int>();
            foreach(char c in total.ToString())
            {
                ret.AddLast(int.Parse(c+""));
            }
            return ret;
        }

        /// <summary>
        /// Given a string str, find the length of the longest substring without duplicate characters
        /// </summary>
        /// <param name="str">string</param>
        /// <returns>the length of the longest substring</returns>
        public int LengthOfLongestSubstring(string str)
        {
            int maxLength = 0;
            int currentLength = 0;
            Dictionary<char,int> dict = new Dictionary<char,int>();
            for (int i = 0; i<str.Length;i++)
            {
                if (dict.ContainsKey(str[i]))
                {
                    i= dict[str[i]];
                    dict = new Dictionary<char, int>();                 
                    currentLength = 0;
                }
                else
                {
                    currentLength++;
                    dict.Add(str[i], i);
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                }
            }
            return maxLength;
        }


        /// <summary>
        /// Given a string str returns the longest palindromic substring in str
        /// </summary>
        /// <param name="str">string</param>
        /// <returns>longest palindromic string</returns>
        public string LongestPalindrome(string str)
        {
            string longestPalindrome = str[0]+"";
            for (int i = 0; i < str.Length; i++)
            {
                for(int j = str.Length-1; j > i; j--)
                {
                    if (str[i] == str[j])
                    {
                        string substring = str.Substring(i, j+1-i);
                        if (IsStringAPalindrome(substring) && substring.Length > longestPalindrome.Length)
                        {
                            longestPalindrome = substring;
                        }
                    }
                }
            }
            return longestPalindrome;
        }

        public bool IsStringAPalindrome(string str)
        {    
            for (int i = 0;i < str.Length/2;i++)
            {
                if (str[i] != str[str.Length-1-i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
