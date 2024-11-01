using System;

public class City
{
    public string Name;
    private int population;
    public int Population
    {
        get { return population; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Population cannot be negative");
            population = value;
        }
    }
    public City(string name, int population)
    {
        Name = name;
        Population = population;
    }
    public static City operator +(City city, int amount)
    {
        city.Population += amount;
        return city;
    }
    public static City operator -(City city, int amount)
    {
        city.Population -= amount;
        return city;
    }
    public static bool operator ==(City city1, City city2)
    {
        if (city1 is null || city2 is null)
            return false;
        return city1.Population == city2.Population;
    }
    public static bool operator !=(City city1, City city2)
    {
        return city1.Population != city2.Population;
    }
    public static bool operator <(City city1, City city2)
    {
        return city1.Population < city2.Population;
    }
    public static bool operator >(City city1, City city2)
    {
        return city1.Population > city2.Population;
    }
    public override int GetHashCode()
    {
        return Population.GetHashCode();
    }
    public override bool Equals(object obj)
    {
        if (obj is City other)
        {
            return this.Population == other.Population;
        }
        return false;
    }
}
