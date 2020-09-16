namespace DataStructures
{
    public class DoublyLinkedList
    {
        private DoublyNode first;
        private DoublyNode last;
        private int size;

        public void AddLast(int item)
        {
            var node =  new DoublyNode(item);

            if (IsEmpty())
            {
                first = node;
                last = node;
            }
            else 
            {

                last.next = node;

                node.prev = last;

                last = node;

            }

            size++;
        }

        public void AddFirst(int item)
        {
            var node = new DoublyNode(item);

            if (IsEmpty())
            {
                first = node;
                last = node;
            }
            else
            {
                node.next = first;
                first.prev = node;

                first = node;
            }

            size++;
            
        }

        public void InsertAfter(int item, int position)
        {
            //1 -> 2 -> 4
            //1 -> 2 ->  * -> 4
            var node = new DoublyNode(item);

            int count = 1;

            

            var current = first; //1

            while (count < position)
            {
                current = current.next; //2

                count++;
            }

            //get next after current and store in temp
            var temp = current.next;

            //now set the next of current to the new node e.g 2 -> newnode(*)
            current.next = node;

            //set prev to 2
            node.prev = current;

            //set new node to the node after current
            node.next = temp;

            //set previous 
            node.next.prev = node;


        }
        
        public DoublyNode InsertIntoSorted(int item)
        {
            //1 -> 2 -> 4
            //1 -> 2 -> 3(*) -> 4
            //*    *

            var newNode = new DoublyNode(item);

            var current = first; // 1


            if (current == null) //when list is empty
            {
                first = newNode;
            }
            else if (current.value >= item)
            {
                current.prev = newNode;
                newNode.next = current;

                first = newNode;
            }
            else
            {
                while (current.next != null && current.next.value < item) //1 < 4, 2 < 4  , 4 < 4 = false 
                {
                    current = current.next; // 2 , 4 

                }
                
                  //current = 4

                newNode.next = current.next;

                if (current.next != null)
                    newNode.next.prev = newNode;

                current.next = newNode;  
                newNode.prev = current;
            }


            

          

            return first;


        }



        private bool IsEmpty()
        {
            return first == null;
        }        
    }

    public class DoublyNode 
    {
        public int value;
        public DoublyNode prev;
        public DoublyNode next;

        public DoublyNode(int item)
        {
            value = item;
        }
    }
}