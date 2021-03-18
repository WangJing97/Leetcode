using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _232_用栈实现队列
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class MyQueue
    {
        //写一个先入先出的
        //使用两个栈，一个用于进栈stackPush 一个用于出栈stackPop
        //pop 
        //1）stackPop里边有元素，直接出
        //2）没有元素把stackPush全部放进stackPop在出

        Stack<int> stackPop = new Stack<int>();
        Stack<int> stackPush = new Stack<int>();

        /** Initialize your data structure here. */
        public MyQueue()
        {

        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            //直接进
            stackPush.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            //从stackPop取元素
            if (stackPop.Count != 0) 
            {
                return stackPop.Pop();
            }
            //如果stackPop没有 就把stackPush全部倒入
            while (stackPush.Count != 0)
            {
                stackPop.Push(stackPush.Pop());
            }
            return stackPop.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            //同pop
            //从stackPop取元素
            if (stackPop.Count != 0)
            {
                return stackPop.Peek();
            }
            //如果stackPop没有 就把stackPush全部倒入
            while (stackPush.Count != 0)
            {
                stackPop.Push(stackPush.Pop());
            }
            return stackPop.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return stackPush.Count == 0 && stackPop.Count == 0;
        }
    }

    /**
     * Your MyQueue object will be instantiated and called as such:
     * MyQueue obj = new MyQueue();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Peek();
     * bool param_4 = obj.Empty();
     */
}
