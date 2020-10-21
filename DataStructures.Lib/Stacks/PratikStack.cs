using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DataStructures.Lib.Stacks
{
    public class PratikStack:IEnumerable
    {
        private List<object> elements = new List<object>();
        public int Count { get => elements.Count; }

        public virtual void Push(object item)
        {
            elements.Insert(0,item);
        }

        public virtual object Pop()
        {
            object popElem = elements.First();
            elements.Remove(popElem);
            return popElem;
        }

        public virtual bool Contains(object item)
        {
            return elements.Contains(item);
        }

        public virtual void Clear()
        {
            elements.Clear();
        }

        public virtual object Peek()
        {
            return elements.First();
        }

        public virtual object[] ToArray()
        {
            return elements.ToArray();
        }

        public virtual IEnumerator GetEnumerator()
        {
            return elements.AsEnumerable().GetEnumerator();
        }
    }
}
