using DataStructuresAndAlgorithms.Api.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructuresAndAlgorithms.Api.Services
{
    public class TestClassOneService
    {
        public static TestClassOne[] GenerateTestClassOnesArray()
        {
            return new TestClassOne[]
            {
                new TestClassOne(5, "just", DateTime.Today.AddDays(-5)),
                new TestClassOne(2, "testing", DateTime.Today),
                new TestClassOne(3, "sorting", DateTime.Today.AddDays(-2)),
                new TestClassOne(7, "of", DateTime.Today.AddDays(-9)),
                new TestClassOne(4, "objects", DateTime.Today.AddDays(10)),
                new TestClassOne(1, "with", DateTime.Today.AddDays(20)),
                new TestClassOne(8, "custom", DateTime.Today.AddDays(7)),
                new TestClassOne(6, "algos", DateTime.Today),
            };
        }
    }
}
