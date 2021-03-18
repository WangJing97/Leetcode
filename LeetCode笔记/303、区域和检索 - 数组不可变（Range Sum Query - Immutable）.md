# 303、区域和检索 - 数组不可变（Range Sum Query - Immutable）

## 题目：

给定一个整数数组  `nums`，求出数组从索引 `i` 到 `j`*（*`i ≤ j`）范围内元素的总和，包含 `i`、`j `两点。

实现 `NumArray` 类：

- `NumArray(int[] nums)` 使用数组 `nums` 初始化对象
- `int sumRange(int i, int j)` 返回数组 `nums` 从索引 `i` 到 `j`*（*`i ≤ j`）范围内元素的总和，包含 `i`、`j `两点（也就是 `sum(nums[i], nums[i + 1], ... , nums[j])`）

 

**示例：**

```
输入：
["NumArray", "sumRange", "sumRange", "sumRange"]
[[[-2, 0, 3, -5, 2, -1]], [0, 2], [2, 5], [0, 5]]
输出：
[null, 1, -1, -3]

解释：
NumArray numArray = new NumArray([-2, 0, 3, -5, 2, -1]);
numArray.sumRange(0, 2); // return 1 ((-2) + 0 + 3)
numArray.sumRange(2, 5); // return -1 (3 + (-5) + 2 + (-1)) 
numArray.sumRange(0, 5); // return -3 ((-2) + 0 + 3 + (-5) + 2 + (-1))
```

 

**提示：**

- `0 <= nums.length <= 104`
- `-105 <= nums[i] <= 105`
- `0 <= i <= j < nums.length`
- 最多调用 `104` 次 `sumRange` 方法

## 解答：

法一（暴力）：

```csharp
public class NumArray
{
    //暴力法 会超时
    private int[] data;
    //使用数组 nums 初始化对象
    public NumArray(int[] nums)
    {
        data = nums;
    }
    //返回数组 nums 从索引 i 到 j（i ≤ j）范围内元素的总和，
    //包含 i、j 两点（也就是 sum(nums[i], nums[i + 1], ... , nums[j])）
    public int SumRange(int i, int j)
    {
        int sum = 0;
        for (int k = i; k <= j; k++)
        {
            sum += data[k];
        }
        return sum;
    }
}
```

法二（动态规划，数学）：

```csharp
public class NumArray1
{
    private int[] sum;
    public NumArray1(int[] nums)
    {
        sum = new int[nums.Length + 1];
        for (int i = 0; i < nums.Length; i++)
        {
            sum[i + 1] = sum[i] + nums[i];
        }
    }

    public int SumRange(int i, int j)
    {
        //sum[k] 定义为 nums[0⋯⋯⋯k-1] 的和。包括这两个值
        //所以SumRange就是
        //sumrange（i，j）=sum[j+1]−sum[i]
        //注意0
        //举例输入[-2, 0, 3, -5, 2, -1]
        //一开始就会
        //sum[]={0,0+-2,0+-2+0,0+-2+0+3⋯⋯⋯⋯⋯⋯}
        //sum[]={0,a,a+b,a+b+c,a+b+c+d,a+b+c+d+e⋯⋯⋯⋯⋯⋯}
        //sumrange（i，j）=sum[j+1]−sum[i] 0 2
        //a+b+c-0=a+b+c
        //1 3
        //a+b+c+d-a=b+c+d
        return sum[j + 1] - sum[i];
    }
}
```

