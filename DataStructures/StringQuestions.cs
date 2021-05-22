using System;
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



    }
}