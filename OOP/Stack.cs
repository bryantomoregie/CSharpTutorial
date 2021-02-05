using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial
{
    class Stack
    {
     
        public List<int> list { get; set; }

        public Stack()
        {
            list = new List<int>();
        }

        public void Push(int num)
        {
            if (num == 0)
                return;
            list.Add(num);
        }

        public int Pop()
        {
            if (list.Count < 1)
                throw new InvalidOperationException();
            var lastObject = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return lastObject;
        }

        public void Clear()
        {
            for (var i = 0; i < list.Count; i++)
            {
                list.RemoveAt(i);
            }

        }
    }
}
