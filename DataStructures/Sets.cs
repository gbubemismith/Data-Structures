using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class Sets
    {
        public static void Test()
        {
            var set = new HashSet<int>();

            int[] numbers = {1, 2, 3, 3, 4, 5, 5, 6};

            foreach (var number in numbers)
            {
                set.Add(number);
            }

            var check = set;
        }

    public static string firstRepeatedWord(string sentence)
    {
        var senArr = sentence.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

    
        var map = new HashSet<string>();
        
        foreach (var word in senArr)
        {
            if (map.Contains(word))
            {
                return word;
            }
            
            map.Add(word);
        }
        
        return "";
    }

    


    }
}