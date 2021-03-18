# 415、字符串相加（Add Strings）

## 题目：

给定两个字符串形式的非负整数 `num1` 和`num2` ，计算它们的和。

 

**提示：**

1. `num1` 和`num2` 的长度都小于 5100
2. `num1` 和`num2` 都只包含数字 `0-9`
3. `num1` 和`num2` 都不包含任何前导零
4. **你不能使用任何內建 BigInteger 库， 也不能直接将输入的字符串转换为整数形式**

## 解答：

```csharp
public string AddStrings(string num1, string num2)
{
    //用阿斯克码
    int i = num1.Length - 1;
    int j = num2.Length - 1;
    int x;
    int y;
    int carry = 0;
    StringBuilder res = new StringBuilder();
    while (i >= 0 || j >= 0 || carry != 0)  
    {
        if (i >= 0) 
        {
            x = num1[i] - '0';
        }
        else
        {
            x = 0;
        }
        if (j >= 0) 
        {
            y = num2[j] - '0';
        }
        else
        {
            y = 0;
        }
        int sum = x + y + carry;
        res.Append(sum % 10);
        carry = sum / 10;
        i--;
        j--;
    }
    if (carry == 1) 
    {
        res = res.Append(carry);
    }
    char[] chr = res.ToString().ToCharArray();
    Array.Reverse(chr);
    return new string(chr);
}
```

