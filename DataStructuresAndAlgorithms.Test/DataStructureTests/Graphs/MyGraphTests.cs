using Algorithms.Lib.Searching.BFSes;
using DataStructures.Lib.Graphs;
using DataStructures.Lib.Queues;
using DataStructuresAndAlgorithms.Api.Classes;
using System.Collections.Generic;
using Xunit;

namespace DataStructuresAndAlgorithms.Test.DataStructureTests.Graphs
{
    public class MyGraphTests
    {
        [Fact]
        public void GraphNodesCount_Equals_7()
        {
            MyGraph<GraphNodeTestClass> myGraph = new MyGraph<GraphNodeTestClass>(ArrangeMyGraph());

            myGraph.Add(new GraphNodeTestClass { Id = 5 });

            Assert.True(myGraph.Count is 7);
        }

        [Fact]
        public void MyGraphFirstNode_HasTwoConnections()
        {
            Assert.True(ArrangeAndConnectMyGraphNodes()[0].Connections.Length.Equals(2));
        }

        [Fact]
        public void MyGraphSecondNodeConnections_Contains_MyGraphFirstNode()
        {
            MyGraph<GraphNodeTestClass> myGraph = ArrangeAndConnectMyGraphNodes();

            Assert.Contains(myGraph[0], myGraph[1].Connections);
        }

        [Fact]
        public void BFSQueue_Equals_ExpectedQueue()
        {
            MyGraph<GraphNodeTestClass> myGraph = ArrangeAndConnectMyGraphNodes();

            MyQueue bfsQueue = myGraph.BreadthFirstSearch();
            MyQueue expectedQueue = new MyQueue();

            expectedQueue.Enqueue(myGraph[0]);
            expectedQueue.Enqueue(myGraph[1]);
            expectedQueue.Enqueue(myGraph[3]);
            expectedQueue.Enqueue(myGraph[2]);
            expectedQueue.Enqueue(myGraph[5]);
            expectedQueue.Enqueue(myGraph[4]);

            Assert.Equal(expectedQueue, bfsQueue);
        }

        [Fact]
        public void BFSQueueWithGivenStartingPoint_Equals_ExpectedQueue()
        {
            MyGraph<GraphNodeTestClass> myGraph = ArrangeAndConnectMyGraphNodes();

            MyQueue bfsQueue = myGraph.BreadthFirstSearch(myGraph[2]);
            MyQueue expectedQueue = new MyQueue();

            expectedQueue.Enqueue(myGraph[2]);
            expectedQueue.Enqueue(myGraph[1]);
            expectedQueue.Enqueue(myGraph[3]);
            expectedQueue.Enqueue(myGraph[5]);
            expectedQueue.Enqueue(myGraph[0]);
            expectedQueue.Enqueue(myGraph[4]);

            Assert.Equal(expectedQueue, bfsQueue);
        }

        private dynamic ConnectGraphNodes(MyGraph<GraphNodeTestClass> myGraph)
        {
            myGraph.Connect(myGraph[0], myGraph[1]);
            myGraph.Connect(myGraph[0], myGraph[3]);
            myGraph.Connect(myGraph[1], myGraph[0]);
            myGraph.Connect(myGraph[1], myGraph[2]);
            myGraph.Connect(myGraph[2], myGraph[3]);
            myGraph.Connect(myGraph[3], myGraph[1]);
            myGraph.Connect(myGraph[4], myGraph[5]);
            myGraph.Connect(myGraph[5], myGraph[2]);
            myGraph.Connect(myGraph[5], myGraph[3]);

            return myGraph;
        }

        private MyGraph<GraphNodeTestClass> ArrangeAndConnectMyGraphNodes()
        {
            return ConnectGraphNodes(new MyGraph<GraphNodeTestClass>(ArrangeMyGraph()));
        }

        private List<GraphNodeTestClass> ArrangeMyGraph()
        {
            return new List<GraphNodeTestClass>
            {
                new GraphNodeTestClass {Id = 1},
                new GraphNodeTestClass {Id = 2},
                new GraphNodeTestClass {Id = 3},
                new GraphNodeTestClass {Id = 4},
                new GraphNodeTestClass {Id = 5},
                new GraphNodeTestClass {Id = 6}
            };
        }
    }
}
