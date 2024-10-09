using System;
using System.Globalization;

public class MyArray : ISort
{
    public int[] array;
    public MyArray(int[] input)
    {
        array = input;
    }
    public void SortAsc()
    {
        Array.Sort(array);
    }
    public void SortDesc()
    {
        Array.Sort(array);
        Array.Reverse(array);
    }
    public void SortByParam(bool isAsc)
    {
        if (isAsc == true)
        {
            SortAsc();
        }
        else
        {
            SortDesc();
        }
    }
}
