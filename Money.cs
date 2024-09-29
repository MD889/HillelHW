using System;

public class Money
{
	public int dollars;
	public int cents;
	public Money(int input1, int input2)
	{
		dollars = input1;
		cents = input2;
		Round();
	}
	public void Round()
	{
		dollars = dollars + cents / 100;
		cents = cents - (cents / 100) * 100;
	}
	public void OutputDollars()
	{
		Console.WriteLine($"You have {dollars} dollars");
	}
    public void OutputCents()
    {
        Console.WriteLine($"You have {cents} cents");
    }
}
