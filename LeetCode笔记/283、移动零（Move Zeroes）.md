# 283、移动零（Move Zeroes）

## 题目：

给定一个数组 `nums`，编写一个函数将所有 `0` 移动到数组的末尾，同时保持非零元素的相对顺序。

**示例:**

```
输入: [0,1,0,3,12]
输出: [1,3,12,0,0]
```

**说明**:

1. 必须在原数组上操作，不能拷贝额外的数组。
2. 尽量减少操作次数。

## 解答：

法一：

```csharp
public void MoveZeroes(int[] nums)
{
    if (nums == null) 
    {
        return;
    }
    //第一次遍历的时候，把非零的元素往前挪
    int j = 0;
    for (int i = 0; i < nums.Length; i++) 
    {
        if (nums[i] != 0) 
        {
            nums[j++] = nums[i];
        }
    }
    //剩下后面的就都是0了
    for (int i = j; i < nums.Length; i++) 
    {
        nums[i] = 0;
    }
}
```

法二：

```csharp
//参考快速排序的思想
//快速排序首先要确定一个待分割的元素做中间点x，
//然后把所有小于等于x的元素放到x的左边，大于x的元素放到其右边。
//这里我们可以用0当做这个中间点，把不等于0(注意题目没说不能有负数)的放到中间点的左边，等于0的放到其右边。
//只要nums[i]!=0，我们就交换nums[i]和nums[j]
public void MoveZeroes1(int[] nums)
{
    if (nums == null) 
    {
        return;
    }
    int j = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != 0) 
        {
            //避免i=j的交换
            if (i > j) 
            {
                nums[j] = nums[i];
                nums[i] = 0;
            }
            j++;
        }
    }
}
```



什么是快速排序？

```csharp
//什么是快速排序？
//1、设两个指针left right 基数为头部元素base
//2、首先，通过偏移right，找到比基数小的元素，就把这个值给left
//3、接着，通过偏移left，找到比基数大的元素，就把这个值给right
//4、重复2 3 动作，直到left right重合，把基准数给这个重合位置，这样就完成的一次，左边的就比基准数小
//右边就比基准数大。
//5、以基准数为分割点，对他的两边进行重复，递归。
static void sort(int[] a, int left, int right)
{
    //如果左边索引大于或者等于右边的索引就代表已经整理完成一个组了
    if (left >= right)
    {
        return;
    }
    int i = left;
    int j = right;
    int key = a[left];
    //控制在当组内寻找一遍
    while (i < j)                               
    {
        while (i < j && key <= a[j])
            //而寻找结束的条件就是，
            //1，找到一个小于或者大于key的数（大于或小于取决于你想升序还是降序）
            //2，没有符合条件1的，并且i与j的大小没有反转
        {
            //向前寻找
            j--;
        }
        a[i] = a[j];
        //找到一个这样的数后就把它赋给前面的被拿走的i的值（如果第一次循环且key是
        //a[left]，那么就是给key）
        while (i < j && key >= a[i])
            //这是i在当组内向前寻找，同上，不过注意与key的大小关系停止循环和上面相反，
            //因为排序思想是把数往两边扔，所以左右两边的数大小与key的关系相反
        {
            i++;
        }
        a[j] = a[i];
    }
    a[i] = key;//当在当组内找完一遍以后就把中间数key回归
    sort(a, left, i - 1);//最后用同样的方式对分出来的左边的小组进行同上的做法
    sort(a, i + 1, right);//用同样的方式对分出来的右边的小组进行同上的做法*/
    //当然最后可能会出现很多分左右，直到每一组的i = j 为止
}
```

另一种简单写法：

```csharp
//快速排序，简单写法
static void swap(int[] a, int i, int j)
{
    int t;
    t = a[i];
    a[i] = a[j];
    a[j] = t;
}

static void quickSort(int[] a, int left, int right)
{
    int mid, i, j;

    if (left >= right)
        return;

    mid = a[left];
    i = left;
    j = left + 1;
    while (j <= right)
    {
        if (a[j] <= mid)
        {
            i++;
            swap(a, i, j);
        }
        j++;
    }
    swap(a, i, left);
    quickSort(a, left, i - 1);
    quickSort(a, i + 1, right);
}
```

