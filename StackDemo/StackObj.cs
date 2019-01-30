using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    public class StackObj
    {
        public List<object> stacks = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("You pass null, please pass valid input.");
            }

            stacks.Add(obj);
        }

        public object Pop()
        {
            if (stacks.Count == 0)
            {
                throw new InvalidOperationException("Your stack is empty.");
            }

            var lastValue = stacks.LastOrDefault();
            stacks.Remove(lastValue);

            return lastValue;
        }

        public void Clear()
        {
            stacks.Clear();
        }
    }
}
