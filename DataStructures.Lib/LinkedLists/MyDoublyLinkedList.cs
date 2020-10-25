using DataStructures.Lib.Classes;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.Lib.LinkedLists
{
    public class MyDoublyLinkedList<T> : IEnumerable<T>
    {
        public int Count { get; set; }
        public MyLinkedListNode<T> Head { get; set; }
        public MyLinkedListNode<T> Tail { get; set; }

        public void AddFirst(T value)
        {
            ThrowArgumentNullExceptionIfParameterIsNull(value);
            AddFirst(new MyLinkedListNode<T>(value));
        }

        public void AddFirst(MyLinkedListNode<T> node)
        {
            ThrowArgumentNullExceptionIfParameterIsNull(node);
            ThrowInvalidOperationExceptionIfNodeIsAlreadyInList(node);

            SetFirst(node);
            Count++;
        }

        public void AddLast(T value)
        {
            ThrowArgumentNullExceptionIfParameterIsNull(value);
            AddLast(new MyLinkedListNode<T>(value));
        }

        public void AddLast(MyLinkedListNode<T> node)
        {
            ThrowArgumentNullExceptionIfParameterIsNull(node);
            ThrowInvalidOperationExceptionIfNodeIsAlreadyInList(node);

            SetLast(node);
            Count++;
        }

        public void AddBefore(MyLinkedListNode<T> node, T value)
        {
            ThrowArgumentNullExceptionIfParameterIsNull(node);
            ThrowArgumentNullExceptionIfParameterIsNull(value);

            AddBefore(node, new MyLinkedListNode<T>(value));
        }

        public void AddBefore(MyLinkedListNode<T> node, MyLinkedListNode<T> newNode)
        {
            ThrowArgumentNullExceptionIfParameterIsNull(node);
            ThrowArgumentNullExceptionIfParameterIsNull(newNode);
            ThrowInvalidOperationExceptionIfNodeIsAlreadyInList(newNode);

            if (node.Previous is null) Head = newNode;

            newNode.Previous = node?.Previous;
            newNode.Next = node;
            node.Previous = newNode;

            Count++;
        }

        public void AddAfter(MyLinkedListNode<T> node, T value)
        {
            ThrowArgumentNullExceptionIfParameterIsNull(node);
            ThrowArgumentNullExceptionIfParameterIsNull(value);

            AddAfter(node, new MyLinkedListNode<T>(value));
        }

        public void AddAfter(MyLinkedListNode<T> node, MyLinkedListNode<T> newNode)
        {
            ThrowArgumentNullExceptionIfParameterIsNull(node);
            ThrowArgumentNullExceptionIfParameterIsNull(newNode);
            ThrowInvalidOperationExceptionIfNodeIsAlreadyInList(newNode);

            if (node.Next is null) Tail = newNode;

            newNode.Previous = node;
            newNode.Next = node.Next;
            node.Next = newNode;

            Count++;
        }

        public bool Contains(T value)
        {
            var current = Head;
            for (int i = 0; i < Count; i++)
            {
                if (current.Value.Equals(value)) return true;

                current = current.Next;
            }

            return false;
        }

        public void Remove(T value)
        {
            var current = Head;
            for (int i = 0; i < Count; i++)
            {
                if (current.Value.Equals(value))
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;

                    Count--;
                    break;
                }

                current = current.Next;
            }
        }

        public void RemoveFirst()
        {
            Head = Head.Next;
            Count--;
        }

        public void RemoveLast()
        {
            Tail = Tail.Previous;
            Count--;
        }

        public void Remove(MyLinkedListNode<T> node)
        {
            var current = Head;
            for (int i = 0; i < Count; i++)
            {
                if (current.Equals(node))
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;

                    Count--;
                    break;
                }

                current = current.Next;
            }
        }

        public void Clear()
        {
            var currentNode = Head;
            Head = null;

            for (int i = 0; i < Count; i++)
            {
                var oldNode = currentNode;
                currentNode = oldNode.Next;
                oldNode.Next = null;
                oldNode.Previous = null;
            }

            Tail = null;
            Count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            MyLinkedListNode<T> currentNode = Head;

            for (int i = 0; i < Count; i++)
            {
                currentNode = i == 0 ? Head : currentNode?.Next;
                yield return currentNode.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void ThrowArgumentNullExceptionIfParameterIsNull(object obj)
        {
            if (obj is null) throw new ArgumentNullException();
        }

        private void ThrowInvalidOperationExceptionIfNodeIsAlreadyInList(MyLinkedListNode<T> node)
        {
            if (node.Next != null && node.Previous != null || node == Head || node == Tail)
                throw new InvalidOperationException("The provided node already belongs to a list.");
        }

        private void SetLast(MyLinkedListNode<T> newTail)
        {
            if (Count == 0) Head = Tail = newTail;
            else
            {
                var oldTail = Tail;
                Tail = newTail;
                newTail.Previous = oldTail;
                oldTail.Next = Tail;
            }
        }

        private void SetFirst(MyLinkedListNode<T> newHead)
        {
            if (Count == 0) Head = Tail = newHead;
            else
            {
                var oldHead = Head;
                Head = newHead;
                oldHead.Previous = Head;
                Head.Next = oldHead;
            }
        }
    }
}
