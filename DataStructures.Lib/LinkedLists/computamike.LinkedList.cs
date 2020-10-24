using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DataStructures.Lib.LinkedLists
{
    /// <summary>
    /// An implementation of a Doubly Linked list - I'll be honest I 
    /// probably wasn't payhing attention when I was a Uni... 
    /// but... Thank goodness for Wikipedia
    /// https://en.wikipedia.org/wiki/Doubly_linked_list#:~:text=In%20computer%20science%2C%20a%20doubly,sequentially%20linked%20records%20called%20nodes.&text=The%20beginning%20and%20ending%20nodes,facilitate%20traversal%20of%20the%20list.
    /// </summary>
    public class DoublyLinkedListDataStructure
    {
        public DoublyLinkedListNode FirstNode { get; set; }
        public DoublyLinkedListNode LastNode { get; set; }

        /// <summary>
        /// Add a Node to the end of the list.
        /// </summary>
        /// <param name="doublyLinkedListNode"></param>
        public void Add(DoublyLinkedListNode doublyLinkedListNode)
        {
            if (FirstNode == null)
            {
                doublyLinkedListNode.Next = null;
                doublyLinkedListNode.Prev = null;
                FirstNode = doublyLinkedListNode;
                LastNode = doublyLinkedListNode;
            }
            else if(LastNode != null)
            {
                LastNode.Next = doublyLinkedListNode;
                doublyLinkedListNode.Prev = LastNode;
                LastNode = doublyLinkedListNode;
            }

        }

        public void Add(int index, DoublyLinkedListNode doublyLinkedListNode)
        {
            // Find insertion point.
            var insertno = this[index];
            doublyLinkedListNode.Next = insertno.Next;
            insertno.Next = doublyLinkedListNode;
            doublyLinkedListNode.Prev = insertno;
        }


        public DoublyLinkedListNode this[int key]
        {
            get
            {
                var ReturnedElement = FirstNode;
                for (int i = 0; i < key; i++)
                {
                    ReturnedElement = ReturnedElement.Next;
                }
                return ReturnedElement;
            }
        }


        public void RemoveAt(int v)
        {
            var p = this[v].Prev;
            var n = this[v].Next;
            p.Next = n;
            n.Prev = p;
        }
    }

    public class DoublyLinkedListNode
    {
        public DoublyLinkedListNode Next{ get; set; }
        public DoublyLinkedListNode Prev { get; set; }
        public object Data { get; set; }
    }

}
