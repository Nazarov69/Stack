using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Model
{
    public class ClassStack<T> : ICloneable
    {
        private List<T> items = new List<T>();

        public void Push(T _item)
        {
            items.Add(_item);
        }

        public T Pop()
        {
            if (!IsEmpty())
            {
                var item = items.LastOrDefault();
                items.Remove(item);

                return item;
            }
            else
            {
                throw new NullReferenceException("stack is empty");
            }
        }

        public T Peek()
        {
            if (!IsEmpty())
            {
                return items.LastOrDefault();
            }
            else
            {
                throw new NullReferenceException("stack is empty");
            }
        }

        public bool IsEmpty()
        {
            return (items.Count <= 0);
        }

        public void Clear()
        {
            items.Clear();
        }

        public object Clone()
        {
            ClassStack<T> _newstack = new ClassStack<T>();
            _newstack.items = new List<T>(items);
            return _newstack;
        }
    }
}
