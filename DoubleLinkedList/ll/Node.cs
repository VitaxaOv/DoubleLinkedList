using System;

namespace DataDataStructures.LL
{
    public class Node
    {
        public int Value{get;set;}
        public Node Next { get; set; }
        public Node Previous { get; set; }
        public Node()
        {
            Next = null;
            Previous = null;
        }
        public Node(int value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }
    }
}
