using System;

namespace DataStructuresAndAlgorithms.Api.Classes
{
    public class TestClassOne : BaseTestClass
    {
        public DateTime Date { get; set; }

        public TestClassOne(int id, string name, DateTime date)
        {
            Id = id;
            Name = name;
            Date = date;
        }
    }
}
