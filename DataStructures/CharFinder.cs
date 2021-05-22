using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    public class CharFinder
    {
        public static char FindFirstNonRepeatingChar(string sentence)
        {
            var map = new Dictionary<char, int>();

            var charArr = sentence.ToCharArray();

            foreach (var ch in charArr)
            {
                if (map.ContainsKey(ch))
                {
                    var count = map[ch];
                    map[ch] = count + 1;
                }
                else {
                    map.Add(ch, 1);
                }

            }

            foreach (var ch in charArr)
            {
                if (map[ch] == 1 && ch.ToString() != " ")
                    return ch;
            }

           return char.MinValue;
        }

        public static char FirstRecurring(string str)
        {
            var set = new HashSet<char>();

            var strArr = str.ToCharArray();

            foreach (var ch in strArr)
            {
                if (set.Contains(ch))
                    return ch;

                set.Add(ch);
                
            }

            return char.MinValue;
        }
    }
}