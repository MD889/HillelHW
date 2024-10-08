using System;

public class DecimalNum
{
	int Value;
	public DecimalNum(int input)
	{
		Value = input;
	}
	public int ToBinary()
	{
		bool isvalid = int.TryParse(Convert.ToString(Value, 2), out int output);
        if (isvalid == false)
        {
            Console.WriteLine("Invalid input, cannot convert");
            return -1;
        }
        return output;
	}
    public int ToOctal()
    {
        bool isvalid = int.TryParse(Convert.ToString(Value, 8), out int output);
        if (isvalid == false)
        {
            Console.WriteLine("Invalid input, cannot convert");
            return -1;
        }
        return output;
    }
    public int ToHexadecimal()
    {
        bool isvalid = int.TryParse(Convert.ToString(Value, 16), out int output);
        if (isvalid == false)
        {
            Console.WriteLine("Invalid input, cannot convert");
            return -1;
        }
        return output;
    }
}
