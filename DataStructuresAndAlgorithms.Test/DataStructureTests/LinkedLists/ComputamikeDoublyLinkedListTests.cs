﻿using DataStructures.Lib.Arrays;
using DataStructures.Lib.LinkedLists;
using DataStructuresAndAlgorithms.Api.Services;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace DataStructuresAndAlgorithms.Test.DataStructureTests
{
    public class ComputamikeDoublyLinkedListTests
    {
        [Fact]
        public void TestThatANodeHasThreeProperties()
        {
            var dataProperty= typeof(DoublyLinkedListNode).GetProperty("Data");
            var nextProperty = typeof(DoublyLinkedListNode).GetProperty("Next");
            var prevProperty = typeof(DoublyLinkedListNode).GetProperty("Prev");

            Assert.NotNull(dataProperty);
            Assert.NotNull(nextProperty);
            Assert.NotNull(prevProperty);

            Assert.True(dataProperty.PropertyType == typeof(object));
            Assert.True(nextProperty.PropertyType == typeof(DoublyLinkedListNode));
            Assert.True(prevProperty.PropertyType == typeof(DoublyLinkedListNode));
        }

        [Fact]
        public void TestThatAListHasStartAndEndNodes()
        {
            var firstNodeProperty = typeof(ComputamikeDoublyLinkedList).GetProperty("FirstNode");
            var lastNodeProperty = typeof(ComputamikeDoublyLinkedList).GetProperty("LastNode");
 

            Assert.NotNull(firstNodeProperty);
            Assert.NotNull(lastNodeProperty);
 
            Assert.True(firstNodeProperty.PropertyType == typeof(DoublyLinkedListNode));
            Assert.True(lastNodeProperty.PropertyType == typeof(DoublyLinkedListNode));
 
        }

        [Fact]
        public void TestAddingAFirstNode() {

            // Arrange
            var SUT = new ComputamikeDoublyLinkedList();
            var newNode = new DoublyLinkedListNode() { Data = "123"};
            // Act

            SUT.Add(newNode);
            // Assert

            Assert.Equal(SUT.FirstNode, SUT.LastNode);

        }

        [Fact]
        public void TestAdding2Nodes()
        {

            // Arrange
            var SUT = new ComputamikeDoublyLinkedList();
            var newNode = new DoublyLinkedListNode() { Data = "123" };
            var newNode2 = new DoublyLinkedListNode() { Data = "456" };

            // Act

            SUT.Add(newNode);
            SUT.Add(newNode2);
            // Assert

            Assert.Equal(newNode, SUT.FirstNode);
            Assert.Equal(newNode2, SUT.LastNode);
        }


        [Fact]
        public void TestGettingNthNode()
        {
            // Arrange
            var SUT = new ComputamikeDoublyLinkedList();
            var newNode = new DoublyLinkedListNode() { Data = "123" };
            var newNode2 = new DoublyLinkedListNode() { Data = "456" };
            var newNode3 = new DoublyLinkedListNode() { Data = "789" };
          
            SUT.Add(newNode);
            SUT.Add(newNode2);
            SUT.Add(newNode3);
            
            // Act
            var firstItem = SUT[0];
            var secondItem = SUT[1];
            var thirdItem = SUT[2];


            // Assert

            Assert.Equal(firstItem.Data, newNode.Data );
            Assert.Equal(secondItem.Data, newNode2.Data);
            Assert.Equal(thirdItem.Data, newNode3.Data);

        }

        [Fact]
        public void TestInsertingANodeAtNthNode()
        {
            // Arrange
            var SUT = new ComputamikeDoublyLinkedList();
            var newNode = new DoublyLinkedListNode() { Data = "123" };
            var newNode2 = new DoublyLinkedListNode() { Data = "456" };
            var newNode3 = new DoublyLinkedListNode() { Data = "789" };

            SUT.Add(newNode);
            SUT.Add(newNode2);
            SUT.Add(newNode3);

            // Act

            var newNode2b = new DoublyLinkedListNode() { Data = "777" };
            SUT.Add(1, newNode2b);
            //Assert
            Assert.Equal("123", SUT[0].Data);
            Assert.Equal("456", SUT[1].Data);
            Assert.Equal("777", SUT[2].Data);
            Assert.Equal("789", SUT[3].Data);

            // Assert that navigation works on the newly added Node.
            Assert.Equal("456", SUT[2].Prev.Data);
            Assert.Equal("789", SUT[2].Next.Data);







        }

        [Fact]
        public void TestRemovingANodeAtNthNode()
        {
            // Arrange
            var SUT = new ComputamikeDoublyLinkedList();
            var newNode = new DoublyLinkedListNode() { Data = "123" };
            var newNode2 = new DoublyLinkedListNode() { Data = "456" };
            var newNode3 = new DoublyLinkedListNode() { Data = "789" };

            SUT.Add(newNode);
            SUT.Add(newNode2);
            SUT.Add(newNode3);

            // Act
            SUT.RemoveAt(1);
            //Assert
            Assert.Equal("123", SUT[0].Data);
            Assert.Equal("789", SUT[1].Data);
        }




    }
}
