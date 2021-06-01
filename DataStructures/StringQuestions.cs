using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class StringQuestions
    {
        public static int CountVowels(string str)
        {
            if (str == null)
                return 0;

            int count = 0;
            var vowels = "aeiou";

            foreach (var ch in str.ToLower().ToCharArray())
            {
                if (vowels.IndexOf(ch) != -1)
                    count++;
            }

            return count;
        }

        public static string ReverseString(string str)
        {

            var reversed = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed.Append(str.ToCharArray()[i]);
            }

            return reversed.ToString();
        }

        public static string ReverseWords(string sentence)
        {
            var words = sentence.Split(" ");

            var reversedWords = new StringBuilder();

            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversedWords.Append(words[i] + " ");
            }


            return reversedWords.ToString().TrimEnd();
        }

        public static bool AreRotations(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            if (!(str1 + str2).Contains(str2))
                return false;

            return true;
        }

        public static string RemoveDuplicates(string str)
        {
            var stringBuilder = new StringBuilder();

            var set = new HashSet<char>();

            var strArr = str.ToCharArray();

            foreach (var ch in strArr)
            {
                if (!(set.Contains(ch)) || ch.ToString() == " ")
                {
                    set.Add(ch);
                    stringBuilder.Append(ch);
                }
            }

            return stringBuilder.ToString();
        }

        public static string Capitalize(string sentence)
        {
            var words = sentence.Split(" ");

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1);
            }

            return String.Join(" ", words);
        }

        // public static bool IsPalindrome1(string word)
        // {
        //     var input = word.ToCharArray();

        //     Array.Reverse(input);

        //     return input.ToString().Equals(word);


        // }

        public static bool IsPalindrome(string word)
        {
            int left = 0;
            int right = word.Length - 1;

            while (left < right)
            {
                if (word[left] != word[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }

        public static bool AreAnagrams(string str1, string str2)
        {
            var string1 = str1.ToCharArray();
            Array.Sort(string1);

            var string2 = str2.ToCharArray();
            Array.Sort(string2);

            return Array.Equals(string1, string2);

        }

        public static string maxSubstring(string s)
        {
            string maxSub = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (maxSub.CompareTo(s.Substring(i)) <= 0)
                {
                    maxSub = s.Substring(i);
                }
            }

            return maxSub;
        }

        //using sliding window pattern
        public static int FindSubstringLength(int k, string str)
        {
            if (String.IsNullOrEmpty(str) || str.Length < k)
                throw new ArgumentException("string does not meet criteria");


            var map = new Dictionary<char, int>();
            // var mapC = new ConcurrentDictionary<char, int>();


            int windowStart = 0, maxLength = 0;

            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                var charValue = str[windowEnd];

                //add key and set value to dictionary
                if (map.TryGetValue(charValue, out var val))
                    map[charValue] = val + 1;
                else
                    map.Add(charValue, 1);

                //while distinct count greater than k
                while (map.Count > k)
                {
                    var checkCharValue = str[windowStart];
                    map[checkCharValue] = map[checkCharValue] - 1;

                    if (map[checkCharValue] == 0)
                        map.Remove(checkCharValue);

                    windowStart++;
                }

                maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
            }

            return maxLength;
        }

        public static int NoRepeatSubstring(string str)
        {
            int windowStart = 0;
            int maxLength = 0;

            var map = new Dictionary<char, int>();

            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                var charValue = str[windowEnd];

                //check if value exists and update index
                if (map.ContainsKey(charValue))
                {
                    windowStart = Math.Max(windowStart, map[charValue] + 1);
                    map[charValue] = windowEnd;
                }
                else
                {
                    map.Add(charValue, windowEnd);
                }

                maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);

            }

            return maxLength;

        }

        public static int LongestSubstringReplacement(string str, int k)
        {
            //length of a window = windowEnd - windowStart + 1
            //aabcc
            //2 1 2 

            int windowStart = 0;
            int maxLength = 0, maxRepeatLetterCount = 0;
            var map = new Dictionary<char, int>();

            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                var charValue = str[windowEnd];

                if (map.TryGetValue(charValue, out var val))
                    map[charValue] = val + 1;
                else
                    map.Add(charValue, 1);

                maxRepeatLetterCount = Math.Max(maxRepeatLetterCount, map[charValue]);

                if (windowEnd - windowStart + 1 - maxRepeatLetterCount > k)
                {
                    char leftChar = str[windowStart];
                    map[leftChar] = map[leftChar] - 1;
                    windowStart++;
                }

                int windowLength = windowEnd - windowStart + 1;

                maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
            }

            return maxLength;
        }



    }
}