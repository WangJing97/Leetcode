# 155、最小栈（Min Stack）

## 题目：

设计一个支持 `push` ，`pop` ，`top` 操作，并能在常数时间内检索到最小元素的栈。

- `push(x)` —— 将元素 x 推入栈中。
- `pop()` —— 删除栈顶的元素。
- `top()` —— 获取栈顶元素。
- `getMin()` —— 检索栈中的最小元素。

 

**示例:**

```csharp
输入：
["MinStack","push","push","push","getMin","pop","top","getMin"]
[[],[-2],[0],[-3],[],[],[],[]]

输出：
[null,null,null,null,-3,null,0,-2]

解释：
MinStack minStack = new MinStack();
minStack.push(-2);
minStack.push(0);
minStack.push(-3);
minStack.getMin();   --> 返回 -3.
minStack.pop();
minStack.top();      --> 返回 0.
minStack.getMin();   --> 返回 -2.
```

 

**提示：**

- `pop`、`top` 和 `getMin` 操作总是在 **非空栈** 上调用。

## 解答：

法一：语言自带方法

```csharp
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
```

法二：两个栈

```csharp
public class MinStack1
{
    //一个栈存值，一个栈存最小值
    //实现过程,注意体会其中的过程
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
```

