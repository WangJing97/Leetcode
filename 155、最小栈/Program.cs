using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _155_最小栈
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    //完全使用语言所含的方法
    public class MinStack
    {
        //把最小值
        private Stack<int> myStack;

        public MinStack()
        {
            myStack = new Stack<int>();
        }

        public void Push(int x)
        {
            myStack.Push(x);
        }

        public void Pop()
        {
            myStack.Pop();
        }

        public int Top()
        {
            return myStack.FirstOrDefault();
        }

        public int GetMin()
        {
            return myStack.Min();
        }
    }
    public class MinStack1
    {
        //一个栈存值，一个栈存最小值
        //实现过程
        private Stack<int> dataStack;
        private Stack<int> minStack;
        public MinStack1()
        {
            dataStack = new Stack<int>();
            minStack = new Stack<int>();
        }
        //push时首先在dataStack进一个数据，如果min中最顶上的数据比x还要小，就还要放入minStack
        public void Push(int x)
        {
            dataStack.Push(x);
            if (minStack.Count == 0 || x <= minStack.Peek()) 
            {
                minStack.Push(x);
            }
        }
        //pop的时候首先pop在dataStack里边的数据，如果这个数和minStack顶部的数据一样，minStack也要pop出
        public void Pop()
        {
            int x = dataStack.Pop();
            if (x == minStack.Peek()) 
            {
                minStack.Pop();
            }
        }
        public int Top()
        {
            return dataStack.Peek();
        }
        public int GetMin()
        {
            return minStack.Peek();
        }
    }

}
