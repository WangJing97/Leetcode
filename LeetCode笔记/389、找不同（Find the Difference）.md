# 389、找不同（Find the Difference）

## 题目：

给定两个字符串 ***s*** 和 ***t***，它们只包含小写字母。

字符串 *t* 由字符串 *s* 随机重排，然后在随机位置添加一个字母。

请找出在 ***t*** 中被添加的字母。

 

**示例 1：**

```
输入：s = "abcd", t = "abcde"
输出："e"
解释：'e' 是那个被添加的字母。
```

**示例 2：**

```
输入：s = "", t = "y"
输出："y"
```

**示例 3：**

```
输入：s = "a", t = "aa"
输出："a"
```

**示例 4：**

```
输入：s = "ae", t = "aea"
输出："a"
```

 

**提示：**

- `0 <= s.length <= 1000`
- `t.length == s.length + 1`
- `s` 和 `t` 只包含小写字母

## 解答：

法一：

```csharp
public char FindTheDifference(string s, string t)
{
    //用一个列表
    //先把两个字符串连接上，有就添加，没有就加上
    List<char> list = new List<char>();
    char[] chars = new char[] { };
    chars = s.Concat(t).ToArray();
    for (int i = 0; i < chars.Length; i++) 
    {
        if (list.Contains(chars[i])) 
        {
            list.Remove(chars[i]);
        }
        else
        {
            list.Add(chars[i]);
        }
    }
    return (char)list.ToArray()[0];
}
```

法二：

```csharp
public char FindTheDifference1(string s, string t)
{
    //a ^ a=0; 任何数字和自己异或都是0
    //a ^ 0 = a; 任何数字和0异或还是他自己
    //a ^ b ^ a = a ^ a ^ b 异或运算具有交换律
    //因为s和t合并之后，偶数个的字符通过异或都会变为0，奇数个的字符异或之后还是他自己，我们只需要把合并的字符全部异或一遍即可
    char[] chars = s.Concat(t).ToArray();
    char res = (char)0;
    foreach (char item in chars)
    {
        res ^= item;
    }
    return res;
}
```

