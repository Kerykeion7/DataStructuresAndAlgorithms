using DataStructures.Lib.Stacks;
using DataStructuresAndAlgorithms.Api.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructuresAndAlgorithms.Test.DataStructureTests.Stacks
{
    public class PratikStackTest
    {
        private readonly StackService _stackService;
        public PratikStackTest()
        {
            _stackService = new StackService();
        }

        [Fact]
        public void MyStack_Equals_OriginalStack()
        {
            Stack originalStack = _stackService.CreateStack(new Stack()) as Stack;
            PratikStack pratikStack = _stackService.CreateStack(new PratikStack()) as PratikStack;

            Assert.Equal<object>(pratikStack, originalStack);
        }

        [Fact]
        public void MyStack_NotEquals_OriginalStack()
        {
            Stack originalStack = _stackService.CreateStack(new Stack()) as Stack;
            PratikStack pratikStack = _stackService.CreateStack(new PratikStack()) as PratikStack;

            pratikStack.Clear();

            Assert.NotEqual<object>(pratikStack, originalStack);
        }
    }
}
