using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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

        public static bool FindPermutation(string str, string pattern)
        {
            int windowStart = 0, matched = 0;

            var patternMap = new Dictionary<char, int>();

            //add pattern to a map
            for (int i = 0; i < pattern.Length; i++)
                patternMap.Add(pattern[i], 1);

            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                var latestChar = str[windowEnd];
                //check if str exists in pattern map
                if (patternMap.ContainsKey(str[windowEnd]))
                {
                    //decrement frequency
                    patternMap[latestChar] = patternMap[latestChar] - 1;

                    //if the key is  = 0 that means it has been matched
                    if (patternMap[latestChar] == 0)
                        matched++;
                }

                if (matched == patternMap.Count)
                    return true;

                if (windowEnd >= pattern.Length - 1)
                {
                    var prevChar = str[windowStart];
                    windowStart++;

                    if (patternMap.ContainsKey(prevChar))
                    {
                        if (patternMap[prevChar] == 0)
                            matched--;

                        patternMap[prevChar] = patternMap[prevChar] + 1;
                    }
                }
            }

            return false;
        }

        public static List<int> PatternAnagrams(string str, string pattern)
        {
            var matchedIndexes = new List<int>();
            int windowStart = 0, matched = 0;

            var patternMap = new Dictionary<char, int>();
            for (int i = 0; i < pattern.Length; i++)
                patternMap.Add(pattern[i], 1);

            //ppqp

            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                var currentChar = str[windowEnd];

                if (patternMap.ContainsKey(currentChar))
                {
                    patternMap[currentChar] = patternMap[currentChar] - 1;

                    if (patternMap[currentChar] == 0)
                        matched++;
                }

                if (matched == patternMap.Count)
                    matchedIndexes.Add(windowStart);


                if (windowEnd >= pattern.Length - 1)
                {
                    var prevChar = str[windowStart];
                    windowStart++;

                    if (patternMap.ContainsKey(prevChar))
                    {
                        if (patternMap[prevChar] == 0)
                            matched--;

                        patternMap[prevChar] = patternMap[prevChar] + 1;
                    }
                }

            }

            return matchedIndexes;
        }

        public static string MinimumWindowSubstring(string str, string pattern)
        {
            var map = new Dictionary<char, int>();

            foreach (var item in pattern)
            {
                map.Add(item, 1);
            }

            int windowStart = 0, matched = 0, minLength = str.Length - 1, subStrStart = 0;

            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                var currentChar = str[windowEnd];

                if (map.ContainsKey(currentChar))
                {
                    map[currentChar] = map[currentChar] - 1;

                    if (map[currentChar] >= 0)
                        matched++;
                }

                while (matched == pattern.Length)
                {
                    if (minLength > windowEnd - windowStart + 1)
                    {
                        minLength = windowEnd - windowStart + 1;
                        subStrStart = windowStart;
                    }

                    var leftChar = str[windowEnd];
                    if (map.ContainsKey(leftChar))
                    {
                        if (map[leftChar] == 0)
                            matched--;

                        map[leftChar] = map[leftChar] + 1;
                    }
                }
            }


            return minLength > str.Length ? "" : str.Substring(subStrStart, subStrStart + minLength);
        }

        public static string RearrangeWords(string str = null)
        {
            str = "Four score and seven years ago our fathers brought forth upon this continent a new nation, conceived in liberty and dedicated to the proposition that all men are created equal";

            var splitWords = str.Split(' ');
            var sb = new StringBuilder();
            int lineLength = 0;

            for (int i = 0; i < splitWords.Length; i++)
            {
                var word = splitWords[i] + " ";

                if (lineLength + word.Length > 13 && word.Remove(word.Length - 1).Length + lineLength > 13)
                {

                    sb.Append("\n");
                    lineLength = 0;

                }

                sb.Append(word);
                lineLength += word.Length;
            }



            return sb.ToString();

        }

        public static List<int> ConcatenationWords(string s, string[] words)
        {
            var wordMap = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordMap.ContainsKey(word))
                    wordMap[word] += 1;
                else
                    wordMap.Add(word, 1);
            }
            //total words in array
            var wordsCount = words.Length;
            //length of individual word
            var wordLength = words[0].Length;
            int matchCount = 0;
            int windowStart = 0;

            for (int windowEnd = 0; windowEnd < s.Length; windowEnd++)
            {
                var sub = s.Substring(windowEnd, wordLength);

                if (wordMap.ContainsKey(sub))
                {
                    wordMap[sub] -= 1;
                    matchCount++;
                }

                while (matchCount < wordsCount)
                {
                    windowEnd += wordLength;


                }
            }
            // this question is hard abeg


            return new List<int>();
        }

        public static string LongestNiceSubstring(string s)
        {
            var map = new Dictionary<char, int>();
            //"abABB"
            // Input: s = "YazaAay"
            // Output: "aAa"

            //y, 0 --- s, e -> 0
            //a, 1 --- s = 0, e 1
            //z, 2
            //a, 3
            //A, 4
            //a, 5
            //y, 6

            //abABBc
            int windowStart = 0;

            for (int windowEnd = 0; windowEnd < s.Length; windowEnd++)
            {
                var rightChar = s[windowEnd];

                if (map.ContainsKey(rightChar))
                {
                    map[rightChar] = map[rightChar] + 1;
                }
                else
                {
                    map.Add(rightChar, 1);
                }

                // while ()
            }

            return "yes";
        }

        public static string PrintAllOdd(string input)
        {
            /**input 1 10 
                    40  50 **/
            var firstArr = new List<string>();
            var secondArr = new List<string>();

            var map = new Dictionary<int, List<string>>();

            string check = "1 10@40 50".Replace("@", System.Environment.NewLine);

            var arr = check.Split('\n');

            var firstRange = arr[0].Split(' ');
            var secondRange = arr[1].Split(' ');

            for (int i = int.Parse(firstRange[0]); i <= int.Parse(firstRange[1]); i++)
            {
                if (i % 2 != 0)
                    firstArr.Add(i.ToString());
            }

            map.Add(1, firstArr);

            for (int i = int.Parse(secondRange[0]); i <= int.Parse(secondRange[1]); i++)
            {
                if (i % 2 != 0)
                    secondArr.Add(i.ToString());
            }

            map.Add(2, secondArr);

            var rFirst = string.Join(" ", map[1]);
            var rSecond = string.Join(" ", map[2]);

            var resp = $"{rFirst} \n {rSecond}";

            Console.WriteLine(resp);

            return check;
        }

        public static string GetRecipient(string message, int position)
        {
            // Your code goes here
            var strSent = message.Split('@');

            if (strSent.Length < position)
                return "";

            var receipient = strSent[position];

            // var badCharcters = Regex.Matches(receipient, @"^[a-zA-Z0-9_-]*$");
            
            var badCharcters = Regex.Replace(receipient, @"[^a-zA-Z0-9_-]", "");//receipient.Replace("[^a-zA-Z0-9_-]", "");

            if(badCharcters.Count() > 0){
                var firstBadChar = badCharcters[0];

                return receipient.Substring(0);
            }else{
                return receipient;
            }
            

            return "";
            // var str = message.Split(" ");

            // var set = new HashSet<string>();

            // foreach (var item in str)
            // {
            //     if (item.Contains('@'))
            //     {
            //         set.Add(item.Substring(1, item.Length - 1).Trim());
            //     }
            // }

            return "";
        }






    }
}