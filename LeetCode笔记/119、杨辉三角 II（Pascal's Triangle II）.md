# 119、杨辉三角 II（Pascal's Triangle II）

## 解答：

给定一个非负索引 *k*，其中 *k* ≤ 33，返回杨辉三角的第 *k* 行。

![img](https://upload.wikimedia.org/wikipedia/commons/0/0d/PascalTriangleAnimated2.gif)

在杨辉三角中，每个数是它左上方和右上方的数的和。

**示例:**

```csharp
输入: 3
输出: [1,3,3,1]
```

**进阶：**

你可以优化你的算法到 *O*(*k*) 空间复杂度吗？

## 解答：

```csharp
public static IList<int> GetRow(int rowIndex)
{
    //添加断点，注意观察步骤
    //currentResult使用完成之后会被清空存到prevResult里边去
    //currentResult通过第一位手动+1和最后一位手动+1得到
    List<int> prevResult = new List<int> { 1 };

    if (rowIndex == 0)
    {
        return prevResult;
    }

    for (int i = 1; i <= rowIndex; i++)
    {
        List<int> currentResult = new List<int>();
        currentResult.Add(1);
        for (int j = 0; j < prevResult.Count - 1; j++)
        {
            currentResult.Add(prevResult[j] + prevResult[j + 1]);
        }
        currentResult.Add(1);
        prevResult = currentResult;
    }
    return prevResult;
}
```

