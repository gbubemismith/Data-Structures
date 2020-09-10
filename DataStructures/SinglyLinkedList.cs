using System;
using System.IO;

namespace DataStructures
{
    public class SinglyLinkedList
    {
        private Node first;
        private Node last;
        private int size;

        public void AddLast(int item) 
        {
            var node = new Node(item);

            if (IsEmpty()) {
                first = node;
                last = node;
            }
            else { 
                last.next = node;
                last = node;
            }

            size++;
            
        }

        public void AddFirst(int item) 
        {
            var node = new Node(item);

            if (IsEmpty()) {
                first = node;
                last = node;
            }
            else {
                node.next = first;
                first = node;
            }

            size++;
        }

        public int IndexOf(int item) 
        {
            var index = 0;

            var current = first;

            while(current != null) {

                if (current.value == item)
                {
                    return index;
                }

                current = current.next;
                index++;
            }

            return -1;

        }

        public bool Contains(int item) 
        {

            return IndexOf(item) != -1;
        }

        public void RemoveFirst()
        {
            // [10 -> 20 -> 30]
            /** 
                *get the second item
                *remove the link between the first and second
                *set the first item to the second
            **/

            if (IsEmpty())
                throw new InvalidOperationException();

            if (first == last) {
                first = last = null;
            }
            else
            {
                 var second = first.next;
                first.next = null;
                first = second;    

            }

            size--;
        }

        public void RemoveLast()
        {
            //[10 -> 40 -> 20 -> 25]
            //last -> 25 (get previous node and break the link)
            //previous -> 20 we want last to be 20, so we initialize last = previous and then break the link

            if (IsEmpty())
                throw new InvalidOperationException();

            if (first == last) {
                first = last = null;
            }
            else 
            {
                var previous = GetPrevious(last);

                last = previous;

                last.next = null;
            }

            size--;

        }

        public int Size()
        {
            return size;
        }

        public int[] ToArray()
        {
            var array = new int[size];

            var current = first;
            var index = 0;

            while (current != null)
            {
                array[index] = current.value;
                index++;
                current = current.next;

            }

            return array;

        }

        public void Reverse()
        {
            // 10 -> 40 -> 20 -> 25
            //10 <- 40 <- 20 <- 25

            if (IsEmpty()) return;

            var previous = first; //10

            var current = first.next; //40

            while (current != null){

                var next = current.next; //20 //25
                current.next = previous; //10 //
                previous = current; //40
                current = next; //20

            }

            last = first;
            last.next = null;
            first = previous;

        }

        public int GetKthFromTheEnd(int k) 
        {
            // 0      1    2      3  
            //[10 -> 40 -> 20 -> 25]
            //  *           *
            //create two pointers a and b

            if (IsEmpty())
                throw new InvalidOperationException();

            var a = first;
            var b = first;

            for (int i = 0; i < k - 1; i++) {
                b = b.next; //40 i
                if (b == null) {
                    throw new ArgumentOutOfRangeException();
                }
            }


            while (b != last) {
                a = a.next;
                b = b.next;
            }

            return a.value;
        }

        public int PrintMiddle()
        {
            //10 40 20 25
            //*     *

            //10 40 20 25
            //*   -    *  
            var a = first;

            var b = first;


            while (b != last && b.next != last)
            {
                b = b.next.next;
                a = a.next;
            }


            return a.value;

        }

        public Node InsertAt(int item, int position)
        {
            //16 -> 13 -> 7
            //16 -> 13 -> 1   7

            var node = new Node(item);

            var current = first; //16

            int count = 1;

            while (count < position) {
                current = current.next; //13
                count++;
            }

            var temp = current.next; //7

            current.next = node;

            current.next.next = temp;

            size++;

            return first;


        }

        private Node GetPrevious(Node node)
        {
            var current = first;

            while (current != null)
            {
                if (current.next == node) return current;

                current = current.next;
            }

            return null;
        }
  
        private bool IsEmpty() 
        {

            return first == null;
        }
    }

    public class Node
    {
        public int value;
        public Node next;

        public Node(int item)
        {
            value = item;

        }

       
    }
}