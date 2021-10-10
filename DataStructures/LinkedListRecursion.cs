namespace DataStructures
{
    public class LinkedListRecursion
    {
        private NodeR first;
        private NodeR last;

        public LinkedListRecursion()
        {
            first = null;
        }

        public void AddLast(int item) {
            var node =  new NodeR(item);
            
            if (first == null)
            {
                first = new NodeR(item);
            }
            else 
            {
                first.AddToEnd(item);
            }

        }

        public void AddFirst(int data) {

            if (first == null) {
                first = new NodeR(data);
            }
            else {
                var temp = new NodeR(data);
                temp.next = first;
                first = temp;
            }
        }
    }

    public class NodeR
    {
        public int value;
        public NodeR next;

        public NodeR(int item)
        {
            value = item;
            next = null;
        }

        public void AddToEnd(int data) {

            if (next == null)
            {
                next = new NodeR(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }

       
    }

    
}  