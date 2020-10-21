using System;

namespace DataStructuresAndAlgorithms.Api.Services
{
    public class LinkedListService : BaseService
    {
        /// <summary>
        /// Performs some predefined actions on a Linked List or any type that implements the Linked List data structure.
        /// </summary>
        /// <param name="linkedList">The Linked List to perform some actions upon.</param>
        /// <returns>
        /// The provided Linked List with some pre defined values.
        /// </returns>
        public object CreateLinkedList(dynamic linkedList)
        {
            if (linkedList is null)
                throw new ArgumentNullException(nameof(linkedList), "The parameter can not be null");

            ThrowInValidOperationExceptionIfAnyMethodNotFoundOfTheGivenMethods(linkedList, "AddFirst", "AddLast", "AddBefore", "AddAfter", "Clear");

            linkedList.AddFirst(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddFirst(4);
            linkedList.AddFirst(5);
            linkedList.Clear();
            linkedList.AddFirst(4);
            linkedList.AddFirst(5);
            linkedList.AddLast(9);
            //linkedList.Remove(3);
            //linkedList.Clear();
            //linkedList.Add(1000);
            //linkedList.Add(2000);
            //linkedList.Add(3000);
            //linkedList[1] = 5;
            //linkedList.RemoveAt(2);

            return linkedList;
        }
    }
}
