using System;
using System.Globalization;

public class MyArray : IMath
{
    private int[] array;
    public MyArray(int[] input)
    {
        array = input;
    }
    public int Max()
    {
        int output = array[0];
        foreach(int element in array)
        {
            if (element > output)
            {
                output = element;
            }
        }
        return output;
    }
    public int Min()
    {
        int output = array[0];
        foreach (int element in array)
        {
            if (element < output)
            {
                output = element;
            }
        }
        return output;
    }
    public float Avg()
    {
        int output = 0;
        foreach (int element in array)
        {
            output = output + element;
        }
        output = output / array.Length;
        return output;
    }
    public bool Search(int valueToSearch)
    {
        foreach (int element in array)
        {
            if (element == valueToSearch)
            {
                return true;
            }
        }
        return false;
    }
}
