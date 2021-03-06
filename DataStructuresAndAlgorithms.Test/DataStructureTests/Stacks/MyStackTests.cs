﻿using DataStructures.Lib.Stacks;
using DataStructuresAndAlgorithms.Api.Services;
using System.Collections;
using Xunit;

namespace DataStructuresAndAlgorithms.Test.DataStructureTests.Stacks
{
    public class MyStackTests
    {
        private readonly StackService _stackService;
        public MyStackTests()
        {
            _stackService = new StackService();
        }

        [Fact]
        public void MyStack_Equals_OriginalStack()
        {
            Stack originalStack = _stackService.CreateStack(new Stack()) as Stack;
            MyStack myStack = _stackService.CreateStack(new MyStack()) as MyStack;

            Assert.Equal<object>(myStack, originalStack);
        }

        [Fact]
        public void MyStack_NotEquals_OriginalStack()
        {
            Stack originalStack = _stackService.CreateStack(new Stack()) as Stack;
            MyStack myStack = _stackService.CreateStack(new MyStack()) as MyStack;

            myStack.Clear();

            Assert.NotEqual<object>(myStack, originalStack);
        }
    }
}
