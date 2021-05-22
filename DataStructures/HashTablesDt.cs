using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    public class HashTablesDt
    {
       public static string RansomNote(string magazine, string note)
       {
           //mag give me one grand today night
            //note give one grand today

            var magArr = magazine.Split(" ");

            var noteArr = note.Split(" ");

            var map = new Dictionary<string, int>();

            //add magazine words to the hash table
            foreach (var magItem in magArr)
            {
                if (map.ContainsKey(magItem))
                {
                    var count = map[magItem];
                    map[magItem] = count + 1;
                }
                else 
                {
                    map.Add(magItem, 1);
                }
            }

            foreach (var noteItem in noteArr)
            {
                if (!map.ContainsKey(noteItem))
                {
                    return "No";
                }

                var count = map[noteItem];

                if (count > 0)
                {
                  map[noteItem] = count - 1;  
                }
                else
                {
                    return "No";
                }
            }

            return "Yes";
       }

       public static int deleteProducts(List<int> ids, int m)
        {
            
            var map = new Dictionary<int, int>();
            
            int[] newArr = new int[ids.Count + 1];
            
            int count = 0;
            int size = 0;
            
            for (int i = 0; i < ids.Count; i++)
            {
                if (!(map.ContainsKey(ids[i])))
                {
                    map.Add(ids[i], 1);
                    size++;
                }
                else
                {
                    var check = map[ids[i]];
                    map[ids[i]] = check + 1;
                }
            }
            
            foreach(int item in map.Values)
            {
                newArr[item]++;
            }
            
            
            var result = map.Count;
            
            
            for (int i = 1; i <= ids.Count; i++)
            {
                var temp = newArr[i];
                
                if (temp == 0)
                    continue;
                    
                int times = Math.Min(temp, m/i);
                result -= times;
                m -= i * times;
            }
            
            
            return result;
            
        }
    }
}