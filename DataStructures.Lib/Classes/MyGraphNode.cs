namespace DataStructures.Lib.Classes
{
    public class MyGraphNode<T>
    {
        public T[] Connections { get; set; }
        public bool IsVisited { get; set; }

        public MyGraphNode()
        {
            Connections = new T[0];
        }
    }
}
