using DataStructures.Lib.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Lib.Graphs
{
    public class MyGraph<TNode> : IEnumerable<TNode>
        where TNode : MyGraphNode<TNode>
    {
        public int Count => _nodes.Length;

        private TNode[] _nodes;

        public TNode this[int index]
        {
            get => _nodes[index];
            set => _nodes[index] = value;
        }


        public MyGraph()
        {
            _nodes = new TNode[0];
        }

        public MyGraph(ICollection collection)
        {
            if (collection is null) _nodes = new TNode[0];
            if (collection.Count is 0) _nodes = new TNode[0];

            _nodes = new TNode[collection.Count];

            collection.CopyTo(_nodes, 0);
        }

        public void Add(TNode node)
        {
            if (node is null) throw new ArgumentNullException(nameof(node));

            TNode[] old = _nodes;
            _nodes = new TNode[Count + 1];

            Array.Copy(old, 0, _nodes, 0, old.Length);
            _nodes[Count - 1] = node;
        }

        public void Connect(TNode nodeOne, TNode nodeTwo)
        {
            if (nodeOne is null || nodeTwo is null) throw new ArgumentNullException();

            if (IsConnected(nodeOne, nodeTwo)) return;

            int firstNeighboursOldLength = nodeOne.Connections.Length;
            int secondNeighboursOldLength = nodeTwo.Connections.Length;

            TNode[] oldFirstNeighboursArray = nodeOne.Connections;
            TNode[] oldSecondNeighboursArray = nodeTwo.Connections;

            nodeOne.Connections = new TNode[firstNeighboursOldLength + 1];
            nodeTwo.Connections = new TNode[secondNeighboursOldLength + 1];

            Array.Copy(oldFirstNeighboursArray, 0, nodeOne.Connections, 0, firstNeighboursOldLength);
            Array.Copy(oldSecondNeighboursArray, 0, nodeTwo.Connections, 0, secondNeighboursOldLength);

            nodeOne.Connections[firstNeighboursOldLength] = nodeTwo;
            nodeTwo.Connections[secondNeighboursOldLength] = nodeOne;
        }

        public bool IsConnected(TNode nodeOne, TNode nodeTwo)
        {
            foreach (var item in nodeOne.Connections)
            {
                if (item.Equals(nodeTwo)) return true;
            }

            foreach (var item in nodeTwo.Connections)
            {
                if (item.Equals(nodeOne)) return true;
            }

            return false;
        }

        public IEnumerator GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
        {
            return _nodes.AsEnumerable().GetEnumerator();
        }
    }
}
