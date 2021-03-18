# 219、存在重复元素 II（Contains Duplicate II）

## 题目：

给定一个整数数组和一个整数 *k*，判断数组中是否存在两个不同的索引 *i* 和 *j*，使得 **nums [i] = nums [j]**，并且 *i* 和 *j* 的差的 **绝对值** 至多为 *k*。

**示例 1:**

```
输入: nums = [1,2,3,1], k = 3
输出: true
```

**示例 2:**

```
输入: nums = [1,0,1,1], k = 1
输出: true
```

**示例 3:**

```
输入: nums = [1,2,3,1,2,3], k = 2
输出: false
```

## 解答：

```csharp
//解题，利用字典
//key装数组，value装序号
//用i往后
//如果字典里没有这个key
//就把这个序号i放里边
//如果字典里已经包含了key就进入判断
//如果这时的i小于当前到的（<=符合要求的）
//返回正确
//不符合的就把当前的序号i更新他
//最后都不符合的就返回失败
public bool ContainsNearbyDuplicate(int[] nums, int k)
{
    Dictionary<int, int> dic = new Dictionary<int, int>();
    for (int i = 0; i < nums.  Length; i++)
    {
        if (!dic.ContainsKey(nums[i])) 
        {
            dic[nums[i]] = i;
        }
        else
        {
            if (i - dic[nums[i]] <= k)  
            {
                return true;
            }
            else
            {
                dic[nums[i]] = i;
            }
        }
    }
    return false;
}
```

