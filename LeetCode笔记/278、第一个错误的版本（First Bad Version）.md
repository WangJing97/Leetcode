# 278、第一个错误的版本（First Bad Version）

## 题目：

你是产品经理，目前正在带领一个团队开发新的产品。不幸的是，你的产品的最新版本没有通过质量检测。由于每个版本都是基于之前的版本开发的，所以错误的版本之后的所有版本都是错的。

假设你有 `n` 个版本 `[1, 2, ..., n]`，你想找出导致之后所有版本出错的第一个错误的版本。

你可以通过调用 `bool isBadVersion(version)` 接口来判断版本号 `version` 是否在单元测试中出错。实现一个函数来查找第一个错误的版本。你应该尽量减少对调用 API 的次数。

**示例:**

```
给定 n = 5，并且 version = 4 是第一个错误的版本。

调用 isBadVersion(3) -> false
调用 isBadVersion(5) -> true
调用 isBadVersion(4) -> true

所以，4 是第一个错误的版本。 
```

## 解答：

```csharp
public class Solution
{
    bool IsBadVersion(int version);
    public int FirstBadVersion(int n)
    {
        /*
        二分法：
        利用题意排列只有是前面是好的后面的是坏的
        举例：
        情景一：
        1 2 3 4 5 6 7
        G G G G B B B
        |     |     |
        L     M     R
        判断isBadVersion(mid)返回false，这时就是从左到这里全部是正确的，
        所以下一步left=mid+1
        情景二：
        1 2 3 4 5 6 7
        G G G B B B B
        |     |     |
        L     M     R
        判断isBadVersion(mid)返回true，这时mid右侧（不包括自身）的所有版本的不可能是第一个错误的版本。
        所以下一步right=mid
        最后，当左右相等时就可以返回left了
        为了防止溢出通常这么算中间的mid = left + (right - left) / 2;
            */
        int left = 1;
        int right = n;
        while (left < right) 
        {
            int mid = left + (right - left) / 2;
            if (IsBadVersion(mid)) 
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }
        return left;
    }
}
```

