namespace DataStructures
{
    public class LinkedList
    {
        private Node first;
        private Node last;

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