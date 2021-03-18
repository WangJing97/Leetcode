# 401、二进制手表（Binary Watch）

## 题目：

二进制手表顶部有 4 个 LED 代表 **小时（0-11）**，底部的 6 个 LED 代表 **分钟（0-59）**。

```csharp
8 4 2 1
o o x x
32 16 8 4 2 1
x  o  o x x o
```



例如，上面的二进制手表读取 “3:25”。

给定一个非负整数 *n* 代表当前 LED 亮着的数量，返回所有可能的时间。

 

**示例：**

```
输入: n = 1
返回: ["1:00", "2:00", "4:00", "8:00", "0:01", "0:02", "0:04", "0:08", "0:16", "0:32"]
```

 

**提示：**

- 输出的顺序没有要求。
- 小时不会以零开头，比如 “01:00” 是不允许的，应为 “1:00”。
- 分钟必须由两位数组成，可能会以零开头，比如 “10:2” 是无效的，应为 “10:02”。
- 超过表示范围（**小时 0-11，分钟 0-59**）的数据将会被舍弃，也就是说不会出现 "13:00", "0:61" 等时间。

## 解答：

法一：

```csharp
public IList<string> ReadBinaryWatch(int num) 
{
    //暴力列举即可
    //这题的意思就是给一个数字，分配给上下
    //注意上面的数字最大只能是3 因为上面是0-11，8421最多只有3位
    //下面是0-59 32 16 8 4 2 1 最后可以5位
    IList<string> res = new List<string>();
    for (int hour = 0; hour <= Math.Min(num, 3); hour++)
    {
        if (num - hour <= 5)
        {
            string[] hours = GetHoursList(hour);
            string[] minutes = GetMinutesList(num - hour);
            foreach (string h in hours)
            {
                foreach (string m in minutes)
                {
                    res.Add(h + ':' + m);
                }
            }
        }
    }
    return res;

}
public string[] GetHoursList(int num)
{
    switch (num)
    {
        case 0:
            return new string[] { "0" };
            break;
        case 1:
            return new string[] { "1", "2", "4", "8" };
            break;
        case 2:
            return new string[] { "3", "5", "9", "6", "10" };
            break;
        default:
            return new string[] { "7", "11" };
            break;
    }
}
public string[] GetMinutesList(int num)
{
    switch (num)
    {
        case 0:
            return new string[] { "00" };
            break;
        case 1:
            return new string[] { "01", "02", "04", "08", "16", "32" };
            break;
        case 2:
            return new string[] { "03", "05", "06", "09", "10", "12", "17", "18", "20", "24", "33", 
                                 "34", "36", "40", "48" };
            break;
        case 3:
            return new string[] { "07", "11", "13", "14", "19", "21", "22", "25", "26", "28", "35",
                                 "37", "38", "41", "42", "44", "49", "50", "52", "56" };
            break;
        case 4:
            return new string[] { "15", "23", "27", "29", "30", "39", "43", "45", "46", "51", "53",
                                 "54", "57", "58" };
            break;
        default:
            return new string[] { "31", "47", "55", "59" };
            break;
    }
}
```

