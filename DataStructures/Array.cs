using System;

namespace DataStructures
{
    public class Array
    {
        private int[] items;
        private int count;
        public Array(int length)
        {
            items = new int[length];
        }

        public void Print() 
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(items[i]);
        }

        public void Insert(int item)
        {
            //if the array is full, resize it
            ResizeIfRequired();

            //add a new item at the end of teh array, count is initially 0
            items[count++] = item;
         

        }

        public void ResizeIfRequired()
        {
            if (items.Length == count)
            {
                //create a new array (twice the size)
                var newItems = new int[count * 2];

                //copy all existing items into new array
                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }

                //set items array to new array
                items = newItems;
            }
        }

        public void RemoveAt(int index)
        {
            Console.WriteLine("Count:" + count);

            //validate array index
            if (index < 0 || index >= count)
                throw  new IndexOutOfRangeException();

            //2 3 5 4
            //shift items to the left to fill the hole
            for (int i = index; i < count; i++) {
                items[i] = items[i + 1];
               
            }
                
             count--;

        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < count; i++)
                if (items[i] == item)
                    return i;


            return -1;
        }

        public int Max() 
        {   
            //0(n)
            int max = 0;

            for (int i = 0; i < count; i++)
            {
                if (items[i] > max)
                {
                    max = items[i];
                }
            }

            return  max;
                
        }

        public Array Intersect(Array other)
        {
            var intersection = new Array(count);

            foreach (var item in items)
            {
                if (other.IndexOf(item) >= 0)
                {
                    intersection.Insert(item);
                }
            }

            return intersection;
        }

        public int[] Reverse()
        {

            var reversed = new int[count];

            for (int i = 0; i < count; i++)
            {
                int rIndex = count - 1;

                reversed[i] = items[rIndex - i];
            }

            return reversed;

            
        }

        public void InsertAt(int item, int index) 
        {
            //validate array
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException();

            //increase size by 1
            var newItems = new int[count + 1];

            //count = 4 , index 2
            //copy to new array
            for (int i = 0; i < count; i++)
            {
                newItems[i] = items[i];
            }

               //1 2 3 4 *
            items = newItems;


            for (int i = count - 1; i >= index; i--)
            {
                items[i + 1] = items[i];
            }

            items[index] = item;

            count++;
        }
    }
}