using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabiryntFrontend
{
    public class Stack
    {
        ArrayList tStack;

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)tStack.GetEnumerator();
        }

        public int Count
        {
            get { return tStack.Count; }
        }

        public object push(object o)
        {
            tStack.Add(o);
            return o;
        }

        public object pop()
        {
            if (tStack.Count > 0)
            {
                object val = tStack[tStack.Count - 1];
                tStack.RemoveAt(tStack.Count - 1);
                return val;
            }
            else
                return null;
        }

        public object top()
        {
            if (tStack.Count > 0)
                return tStack[tStack.Count - 1];
            else
                return null;
        }

        public bool empty()
        {
            return (tStack.Count == 0);
        }

        public Stack() { tStack = new ArrayList(); }
    }
}
