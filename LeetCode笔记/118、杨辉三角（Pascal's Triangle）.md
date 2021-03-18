# 118、杨辉三角（Pascal's Triangle）

## 题目：

给定一个非负整数 *numRows，*生成杨辉三角的前 *numRows* 行。

![img](118%E3%80%81%E6%9D%A8%E8%BE%89%E4%B8%89%E8%A7%92%EF%BC%88Pascal's%20Triangle%EF%BC%89.assets/PascalTriangleAnimated2.gif)

在杨辉三角中，每个数是它左上方和右上方的数的和。

**示例:**

```csharp
输入: 5
输出:
[
     [1],
    [1,1],
   [1,2,1],
  [1,3,3,1],
 [1,4,6,4,1]
]
```

## 解答：

````csharp
public static IList<IList<int>> Generate(int numRows)
{
    //先做第二个理清过程
    IList<IList<int>> result = new List<IList<int>>();

    if (numRows == 0)
    {
        return result;
    }

    List<int> prevResult = new List<int> { 1 };
    result.Add(prevResult);

    for (int i = 1; i <= numRows; i++)
    {
        List<int> currentResult = new List<int>();
        currentResult.Add(1);
        for (int j = 0; j < prevResult.Count - 1; j++) 
        {
            currentResult.Add(prevResult[j] + prevResult[j + 1]);
        }
        currentResult.Add(1);
        prevResult = currentResult;
        result.Add(prevResult);
    }
    return result;
}
````

