using System;

public class Instrument
{
    public string name;
    public string sound;
    public string description;
    public string history;
    public Instrument(string input1, string input2, string input3, string input4)
    {
        name = input1;
        sound = input2;
        description = input3;
        history = input4;
    }
    public void Sound()
	{
		Console.WriteLine(sound);
	}
    public void Show()
    {
        Console.WriteLine(name);
    }
    public void Desc()
    {
        Console.WriteLine(description);
    }
    public void History()
    {
        Console.WriteLine(history);
    }
}
public class Violin : Instrument
{
    public Violin(string input2, string input3, string input4) : base ("Violin", input2, input3, input4)
    {

    }
}
public class Trombone : Instrument
{
    public Trombone(string input2, string input3, string input4) : base("Trombone", input2, input3, input4)
    {

    }
}
public class Ukulele : Instrument
{
    public Ukulele(string input2, string input3, string input4) : base("Ukulele", input2, input3, input4)
    {

    }
}
public class Cello : Instrument
{
    public Cello(string input2, string input3, string input4) : base("Cello", input2, input3, input4)
    {

    }
}