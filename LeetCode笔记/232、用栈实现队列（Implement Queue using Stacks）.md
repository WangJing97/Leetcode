# 232、用栈实现队列（Implement Queue using Stacks）

## 题目：

请你仅使用两个栈实现先入先出队列。队列应当支持一般队列的支持的所有操作（`push`、`pop`、`peek`、`empty`）：

实现 `MyQueue` 类：

- `void push(int x)` 将元素 x 推到队列的末尾
- `int pop()` 从队列的开头移除并返回元素
- `int peek()` 返回队列开头的元素
- `boolean empty()` 如果队列为空，返回 `true` ；否则，返回 `false`

**说明：**

- 你只能使用标准的栈操作 —— 也就是只有 `push to top`, `peek/pop from top`, `size`, 和 `is empty` 操作是合法的。
- 你所使用的语言也许不支持栈。你可以使用 list 或者 deque（双端队列）来模拟一个栈，只要是标准的栈操作即可。

**进阶：**

- 你能否实现每个操作均摊时间复杂度为 `O(1)` 的队列？换句话说，执行 `n` 个操作的总时间复杂度为 `O(n)` ，即使其中一个操作可能花费较长时间。

**示例：**

```csharp
输入：
["MyQueue", "push", "push", "peek", "pop", "empty"]
[[], [1], [2], [], [], []]
输出：
[null, null, null, 1, 1, false]

解释：
MyQueue myQueue = new MyQueue();
myQueue.push(1); // queue is: [1]
myQueue.push(2); // queue is: [1, 2] (leftmost is front of the queue)
myQueue.peek(); // return 1
myQueue.pop(); // return 1, queue is [2]
myQueue.empty(); // return false
```

**提示：**

- `1 <= x <= 9`
- 最多调用 `100` 次 `push`、`pop`、`peek` 和 `empty`
- 假设所有操作都是有效的 （例如，一个空的队列不会调用 `pop` 或者 `peek` 操作）

## 解答：

```csharp
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
```

