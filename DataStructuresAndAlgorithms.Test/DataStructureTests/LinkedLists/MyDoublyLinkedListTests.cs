using DataStructures.Lib.Classes;
using DataStructures.Lib.LinkedLists;
using DataStructuresAndAlgorithms.Api.Services;
using System.Collections.Generic;
using Xunit;

namespace DataStructuresAndAlgorithms.Test.DataStructureTests.LinkedLists
{
    public class MyDoublyLinkedListTests
    {
        private readonly LinkedListService _linkedListService;
        public MyDoublyLinkedListTests()
        {
            _linkedListService = new LinkedListService();
        }

        [Fact]
        public void MyLinkedList_Equals_OriginalLinkedList()
        {
            LinkedList<int> originalLinkedList = _linkedListService.CreateLinkedList(new LinkedList<int>()) as LinkedList<int>;
            MyDoublyLinkedList<int> myLinkedList = _linkedListService.CreateLinkedList(new MyDoublyLinkedList<int>()) as MyDoublyLinkedList<int>;

            ArrangeAndActUponLinkedLists(originalLinkedList, myLinkedList);

            Assert.Equal(myLinkedList, originalLinkedList);
        }

        [Fact]
        public void MyLinkedList_NotEquals_OriginalLinkedList()
        {
            LinkedList<int> originalLinkedList = _linkedListService.CreateLinkedList(new LinkedList<int>()) as LinkedList<int>;
            MyDoublyLinkedList<int> myLinkedList = _linkedListService.CreateLinkedList(new MyDoublyLinkedList<int>()) as MyDoublyLinkedList<int>;

            ArrangeAndActUponLinkedLists(originalLinkedList, myLinkedList);
            myLinkedList.AddFirst(1);

            Assert.NotEqual(myLinkedList, originalLinkedList);
        }

        [Fact]
        public void MyLinkedList_Contains_ValueNine()
        {
            MyDoublyLinkedList<int> myLinkedList = _linkedListService.CreateLinkedList(new MyDoublyLinkedList<int>()) as MyDoublyLinkedList<int>;

            Assert.True(myLinkedList.Contains(9));
        }

        private void ArrangeAndActUponLinkedLists(LinkedList<int> originalLinkedList, MyDoublyLinkedList<int> myLinkedList)
        {
            LinkedListNode<int> fiveHundredListNode = new LinkedListNode<int>(500);
            LinkedListNode<int> tenListNode = new LinkedListNode<int>(10);
            LinkedListNode<int> last = new LinkedListNode<int>(666);

            MyLinkedListNode<int> myFiveHundredListNode = new MyLinkedListNode<int>(500);
            MyLinkedListNode<int> myTenListNode = new MyLinkedListNode<int>(10);
            MyLinkedListNode<int> myLast = new MyLinkedListNode<int>(666);

            originalLinkedList.AddFirst(tenListNode);
            originalLinkedList.AddBefore(tenListNode, 9);
            originalLinkedList.AddAfter(tenListNode, fiveHundredListNode);
            originalLinkedList.AddLast(last);
            originalLinkedList.Remove(10);
            originalLinkedList.AddAfter(last, 777);
            originalLinkedList.Remove(fiveHundredListNode);
            originalLinkedList.RemoveFirst();
            originalLinkedList.RemoveLast();
            originalLinkedList.Clear();
            originalLinkedList.AddLast(5);
            originalLinkedList.RemoveFirst();

            myLinkedList.AddFirst(myTenListNode);
            myLinkedList.AddBefore(myTenListNode, 9);
            myLinkedList.AddAfter(myTenListNode, myFiveHundredListNode);
            myLinkedList.AddLast(myLast);
            myLinkedList.Remove(10);
            myLinkedList.AddAfter(myLast, 777);
            myLinkedList.Remove(myFiveHundredListNode);
            myLinkedList.RemoveFirst();
            myLinkedList.RemoveLast();
            myLinkedList.Clear();
            myLinkedList.AddLast(5);
            myLinkedList.RemoveFirst();
        }
    }
}
