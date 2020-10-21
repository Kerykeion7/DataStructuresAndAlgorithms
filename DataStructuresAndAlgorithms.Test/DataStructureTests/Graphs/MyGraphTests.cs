using DataStructures.Lib.Graphs;
using DataStructuresAndAlgorithms.Api.Classes;
using System.Collections.Generic;
using Xunit;

namespace DataStructuresAndAlgorithms.Test.DataStructureTests.Graphs
{
    public class MyGraphTests
    {
        [Fact]
        public void GraphNodesCount_Equals_9()
        {
            MyGraph<GraphNodeTestClass> myGraph = new MyGraph<GraphNodeTestClass>(ArrangeMyGraph());

            myGraph.Add(new GraphNodeTestClass { Id = 5 });

            Assert.True(myGraph.Count is 5);
        }

        [Fact]
        public void MyGraphFirstNode_HasThreeConnections()
        {
            Assert.True(ArrangeAndConnectMyGraphNodes()[0].Connections.Length.Equals(3));
        }

        [Fact]
        public void MyGraphThirdNodedConnections_Contains_MyGraphFirstNode()
        {
            MyGraph<GraphNodeTestClass> myGraph = ArrangeAndConnectMyGraphNodes();

            Assert.Contains(myGraph[0], myGraph[2].Connections);
        }

        private dynamic ConnectGraphNodes(MyGraph<GraphNodeTestClass> myGraph)
        {
            myGraph.Connect(myGraph[0], myGraph[1]);
            myGraph.Connect(myGraph[0], myGraph[3]);
            myGraph.Connect(myGraph[1], myGraph[0]);
            myGraph.Connect(myGraph[1], myGraph[2]);
            myGraph.Connect(myGraph[2], myGraph[0]);
            myGraph.Connect(myGraph[2], myGraph[3]);
            myGraph.Connect(myGraph[3], myGraph[1]);

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
                new GraphNodeTestClass {Id = 4}
            };
        }
    }
}
