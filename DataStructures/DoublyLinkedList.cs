namespace DataStructures
{
    public class DoublyLinkedList
    {
        private DoublyNode first;
        private DoublyNode last;
        private int size;

        public void AddToEnd(int item)
        {
            
        }        
    }

    public class DoublyNode 
    {
        public int value;
        public Node prev;
        public Node next;

        public DoublyNode(int item)
        {
            value = item;
        }
    }
}