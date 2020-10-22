using DataStructures.Lib.Classes;
using DataStructures.Lib.Queues;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Lib.Searching.BFSes
{
    public static class MyBFS
    {
        public static MyQueue BreadthFirstSearch<T>(this IEnumerable<T> collection, T startNode = default)
            where T : MyGraphNode<T>
        {
            if (collection is null) throw new ArgumentNullException();

            MyQueue bfsQueue = new MyQueue();
            MyQueue queue = new MyQueue();
            T[] array = collection.ToArray();

            foreach (var item in array)
            {
                item.IsVisited = false;
            }

            if (startNode == default) startNode = array[0];

            startNode.IsVisited = true;
            queue.Enqueue(startNode);

            while (queue.Count > 0)
            {
                T node = queue.Peek() as T;

                foreach (T vertex in node.Connections)
                {
                    if (!vertex.IsVisited)
                    {
                        queue.Enqueue(vertex);
                        vertex.IsVisited = true;
                    }
                }

                bfsQueue.Enqueue(queue.Dequeue());
            }

            return bfsQueue;
        }
    }
}
