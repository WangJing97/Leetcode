using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _225_用队列实现栈
{
    class Program
    {
        static void Main(string[] args)
        {
        }

    }
    public class MyStack
    {
        Queue<int> queue;
        public MyStack()
        {
            queue = new Queue<int>();
        }
        /** Push element x onto stack. */
        public void Push(int x)
        {
            //添加的值把他之前的所有数字全部排到这个数的后面
            queue.Enqueue(x);
            for (int i = 0; i < queue.Count - 1; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            return queue.Dequeue();
        }

        /** Get the top element. */
        public int Top()
        {
            return queue.Peek();
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return queue.Count == 0;
        }
    }
}
