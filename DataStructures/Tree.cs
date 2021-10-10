using System;

namespace DataStructures
{
    public class Tree
    {
        public class Node
        {
            public int _value;
            public Node _leftChild;
            public Node _rightChild;

            public Node(int value)
            {
                _value = value;
            }

            public override string ToString()
            {
                return "Node=" + _value;
            }
        }

        private Node _root;

        public void insert(int value)
        {
            var node = new Node(value);

            if (_root == null)
            {
                _root = node;
                return;
            }

            var current = _root;

            while (true)
            {
                if (value < current._value)
                {
                    if (current._leftChild == null)
                    {
                        current._leftChild = node;
                        break;
                    }

                    current = current._leftChild;
                }
                else
                {
                    if (current._rightChild == null)
                    {
                        current._rightChild = node;
                        break;
                    }

                    current = current._rightChild;
                }

            }

        }

        public bool Find(int value)
        {
            var current = _root;

            while (current != null)
            {
                if (value < current._value)
                    current = current._leftChild;
                else if (value > current._value)
                    current = current._rightChild;
                else
                    return true;
            }

            return false;
        }

        public void TraversePreOrder()
        {
            TraversePreOrder(_root);
        }

        private void TraversePreOrder(Node root)
        {
            if (root == null)
                return;

            Console.WriteLine(root._value);
            TraversePreOrder(root._leftChild);
            TraversePreOrder(root._rightChild);
        }
    }

}