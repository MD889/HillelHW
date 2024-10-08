using System;

public class MyArray : IOutput
{
    private int[] array;
    public MyArray(int[] input)
    {
        array = input;
    }
    public void Show()
    {
        foreach (int element in array)
        {
            Console.WriteLine(element);
        }
    }
    public void Show(string info)
    {
        Show();
        Console.WriteLine(info);
    }
}
