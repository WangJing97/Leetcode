# 88、合并两个有序数组（Merge Sorted Array）

## 题目：

给你两个有序整数数组 *nums1* 和 *nums2*，请你将 *nums2* 合并到 *nums1* 中*，*使 *nums1* 成为一个有序数组。

**说明:**

- 初始化 *nums1* 和 *nums2* 的元素数量分别为 *m* 和 *n* 。
- 你可以假设 *nums1* 有足够的空间（空间大小大于或等于 *m + n*）来保存 *nums2* 中的元素。

**示例:**

```csharp
输入:
nums1 = [1,2,3,0,0,0], m = 3
nums2 = [2,5,6],       n = 3

输出: [1,2,2,3,5,6]
```

## 解答：

```csharp
public void Merge(int[] nums1, int m, int[] nums2, int n)
{
    //从后往前排好点
    int lenNums1 = m + n - 1;
    while (m > 0 && n > 0) 
    {
        if (nums1[m - 1] > nums2[n - 1]) 
        {
            nums1[lenNums1] = nums1[m - 1];
            m--;
            lenNums1--;
        }
        else
        {
            nums1[lenNums1] = nums2[n - 1];
            n--;
            lenNums1--;
        }                
    }
    if (m == 0)
    {
        for (int i = 0; i < n; i++)
        {
            nums1[i] = nums2[i];
        }
    }
}
```

