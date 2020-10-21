using System.Collections;
using System.Linq;

namespace DataStructures.Lib.Classes
{
    public class MyGraphNode<T> : IEnumerable
    {
        public T[] Connections { get; set; }

        public MyGraphNode()
        {
            Connections = new T[0];
        }

        public IEnumerator GetEnumerator()
        {
            return Connections.AsEnumerable().GetEnumerator();
        }
    }
}
