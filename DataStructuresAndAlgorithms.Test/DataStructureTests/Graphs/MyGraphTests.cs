using DataStructures.Lib.Graphs;
using DataStructuresAndAlgorithms.Api.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructuresAndAlgorithms.Test.DataStructureTests.Graphs
{
    public class MyGraphTests
    {
        [Fact]
        public void Testing()
        {
            MyGraph<GraphNodeTestClass> myGraph = new MyGraph<GraphNodeTestClass>(ArrangeMyGraph().ToArray());

            myGraph.Add(new GraphNodeTestClass { Id = 9 });
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
                new GraphNodeTestClass {Id = 6},
                new GraphNodeTestClass {Id = 7},
                new GraphNodeTestClass {Id = 8}
            };
        }
    }
}
