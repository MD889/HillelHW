using System;
using System.ComponentModel;
using System.Numerics;

public class Calculator
{
    float temp;
    float main;
    public Calculator()
    {
        Console.WriteLine("Input base value");
        bool isvalid = float.TryParse(Console.ReadLine(), out main);
        if (isvalid == false)
        {
            Console.WriteLine("Invalid input");
            return;
        }
        Console.WriteLine("Select Operation");
        while (true)
        {
            Console.WriteLine("Add");
            Console.WriteLine("Subtract");
            Console.WriteLine("Multiply");
            Console.WriteLine("Divide");
            string input = Console.ReadLine();
            if (input == "Add")
            {
                Add();
                Console.WriteLine(main);
            }
            else if (input == "Subtract")
            {
                Subtract();
                Console.WriteLine(main);
            }
            else if (input == "Multiply")
            {
                Multiply();
                Console.WriteLine(main);
            }
            else if (input == "Divide")
            {
                Divide();
                Console.WriteLine(main);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
    public float Add()
    {
        Console.WriteLine("Input value");
        bool isvalid = float.TryParse(Console.ReadLine(), out temp);
        if (isvalid == false)
        {
            Console.WriteLine("Invalid input");
            return main;
        }
        main = main + temp;
        return main;
    }
    public float Subtract()
    {
        Console.WriteLine("Input value");
        bool isvalid = float.TryParse(Console.ReadLine(), out temp);
        if (isvalid == false)
        {
            Console.WriteLine("Invalid input");
            return main;
        }
        main = main - temp;
        return main;
    }
    public float Multiply()
    {
        Console.WriteLine("Input value");
        bool isvalid = float.TryParse(Console.ReadLine(), out temp);
        if (isvalid == false)
        {
            Console.WriteLine("Invalid input");
            return main;
        }
        main = main * temp;
        return main;
    }
    public float Divide()
    {
        Console.WriteLine("Input value");
        bool isvalid = float.TryParse(Console.ReadLine(), out temp);
        if (isvalid == false)
        {
            Console.WriteLine("Invalid input");
            return main;
        }
        main = main / temp;
        return main;
    }
}
}

}
