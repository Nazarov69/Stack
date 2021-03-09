using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Model
{
    public class ArrayStack<T>
    {
        T[] items;
        public int Count => cur + 1;
        private int cur = -1;
        private readonly int length = 1;
        public ArrayStack(int length = 1)
        {
            items = new T[length];
            this.length = length;
        }

        public ArrayStack(T data, int length = 1) : this(length)
        {
            cur++;
            items[cur] = data;

        }

        public void Push(T data)
        {
            if (cur < length - 1)
            {
                cur++;
                items[cur] = data;

            }
            else
            {
                throw new StackOverflowException("array stack is full");
            }
        }

        public T Pop()
        {
            if (cur >= 0)
            {
                var item = items[cur];
                items[cur] = default(T);
                cur--;
                return item;
            }
            else
            {
                throw new NullReferenceException("array stack if empty");
            }
        }

        public T Peek()
        {
            if (cur >= 0)
            {
                return items[cur];
            }
            else
            {
                throw new NullReferenceException("array stack if empty");
            }
        }




    }
}
