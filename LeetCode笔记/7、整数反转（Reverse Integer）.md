# 7、整数反转（Reverse Integer）

## 题目：

给出一个 32 位的有符号整数，你需要将这个整数中每位上的数字进行反转。

**示例**1：

输入：123

输出：321

**示例** 2：

输入：-123

输出： -321

**示例** 3：

输入：120

输出：21

**注意：**

假设我们的环境只能存储得下32位的有符号整数，则其数值范围为$\left[ -{{2}^{31}},{{2}^{31}}-1 \right]$请根据这个假设，如果反转后整数溢出那么就返回0。

 

## 解答：

注意：取反的过程（以123为例，0代表位数，x=123,sum=000）

使用循环

1、把拿到的123（x）取和10取余得到3，把这个取余得到的数给sum。x=123.sum=003(0)

2、把取余过后的123（x）除以10达到把末尾3去掉变成12（x）的功能。x=120(12),sum=003(3)

3、把sum乘10达到把后一位的数往前进一位的效果，再返回第一步如此循环。x=120(12),sum=030(3)

接着添加判断，对溢出的数字返回0。

```c#
static void Main(string[] args)
{
    int result = doReverse(1266);
    Console.WriteLine(result);
    Console.ReadKey();
}
public static int doReverse(int x)
{   
    long sum = 0;
    while (x != 0)
    {
        sum = sum * 10 + x % 10;
        x /= 10;
        //添加判断
        if (sum > int.MaxValue || sum < int.MinValue)
        {
            return 0;
        }
    }
    return (int)sum;
}

```

