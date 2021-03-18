# 344、反转字符串（Reverse String）

## 题目：

编写一个函数，其作用是将输入的字符串反转过来。输入字符串以字符数组 `char[]` 的形式给出。

不要给另外的数组分配额外的空间，你必须**[原地](https://baike.baidu.com/item/原地算法)修改输入数组**、使用 O(1) 的额外空间解决这一问题。

你可以假设数组中的所有字符都是 [ASCII](https://baike.baidu.com/item/ASCII) 码表中的可打印字符。

 

**示例 1：**

```
输入：["h","e","l","l","o"]
输出：["o","l","l","e","h"]
```

**示例 2：**

```
输入：["H","a","n","n","a","h"]
输出：["h","a","n","n","a","H"]
```

## 解答：

法一：

```csharp
public void ReverseString(char[] s)
{
    //C#?
    for (int left = 0, right = s.Length - 1; left < right; left++, right--) 
    {
        (s[left], s[right]) = (s[right], s[left]);
    }

}
```

法二：

```csharp
public void ReverseString1(char[] s)
{
    Array.Reverse(s);
}
```

法三：

```csharp
public void ReverseString2(char[] s)
{
    if (s == null || s.Length <= 0) 
    {
        return;
    }
    char temp = s[0];
    for (int i = 0; i < s.Length / 2; i++) 
    {
        temp = s[i];
        s[i] = s[s.Length - 1 - i];
        s[s.Length - 1 - i] = temp;
    }
}
```

法四：

```csharp
public void ReverseString3(char[] s)
{
    //利用位运算，异或
    //异或满足交换律和结合律
    //x ^ x == 0
    //x ^ 0 == x
    //相同为0，和零异或还是本身
    //            a           b
    //初始值       a           b
    //a=a^b      a^b          b
    //b=a^b      a^b        a^b^b=a
    //a=a^b     a^b^a=b       a
    //结果         b           a
    for (int i = 0; i < s.Length / 2; i++)
    {
        s[i] ^= s[s.Length - 1 - i];
        s[s.Length - 1 - i] ^= s[i];
        s[i] ^= s[s.Length - 1 - i];
    }
}
```

