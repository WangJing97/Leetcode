# 14、最长公共前缀（ Longest Common Prefix）

## 题目：

编写一个函数来查找字符串数组中的最长公共前缀。

如果不存在公共前缀，返回空字符串 ""。

**示例 1:**

输入: ["flower","flow","flight"]
输出: "fl"

**示例 2:**

输入: ["dog","racecar","car"]
输出: ""
解释: 输入不存在公共前缀。

**说明:**

所有输入只包含小写字母 a-z 。

## 解答：

- 法一

```csharp
public static string LongestCommonPrefix(string[] strs)
{
    if (strs == null || strs.Length == 0)
    {
        return "";
    }
    string pre = strs[0];
    //例如flower,flow,flight
    //此时把第一个字符串给pre flower
    //历遍字符串数组
    for (int i = 1; i < strs.Length; i++)
    {
        //现在是操作第一个字符串
        //利用IndexOf这个方法，从1开始寻找，此例中找的是flow返回-1,
        //进入循环
        //flow中没有flowe返回-1，继续循环去掉最后一位变成flow,退出循环
        //接着开始用flow检查flight，不存在则循环去掉pre的最后一位变成flo
        //直到变成fl返回，完成此方法
        while (strs[i].IndexOf(pre) != 0)
        {
            //Substring是把从0开始到Length - 1（不包括）的字符串输出
            //在这里就是把最后一个字母去掉flower变成flowe
            pre = pre.Substring(0, pre.Length - 1);
        }
    }
    return pre;
}
```

- 法二

```csharp
public static string LongestCommonPrefix1(string[] strs)
{
    if (strs.Length == 0)
    {
        return "";
    }
    //求出最小的循环次数，也就是找出最短的长度
    //其实就是求最小值的方法
    int strsLength = strs[0].Length;
    for (int i = 0; i < strs.Length; i++)
    {
        //如果找的字符串长度比第一个小则把小的长度在给strsLength
        if (strsLength > strs[i].Length) 
        {
            strsLength = strs[i].Length;
        }
    }
    string res = "";
    for (int i = 0; i < strsLength; i++)
    {
        //例如flower,flow,flight
        //把第0个字符串的第0个字符给target(f)
        char target = strs[0][i];
        for (int j = 1; j < strs.Length; j++)
        {
            //判断
            if (strs[j][i] != target)
            {
                //假如第1个字符串flow的第0个字符不等于target(f)
                return res;
            }
            //等于target(f)时继续循环，到flight，数组结束
        }
        //把f给res
        res += target;
        //第二遍就是l
    }
    return res;
}
```

