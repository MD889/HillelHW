using System;

public class Employee
{
    private string name;
    private int salary;

    public Employee(string name, int salary)
    {
        this.Name = name;
        this.Salary = salary;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Salary
    {
        get { return salary; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Salary cannot be negative.");
            salary = value;
        }
    }
    public static Employee operator +(Employee emp, int amount)
    {
        emp.Salary += amount;
        return emp;
    }
    public static Employee operator -(Employee emp, int amount)
    {
        emp.Salary -= amount;
        if (emp.Salary < 0)
            emp.Salary = 0;
        return emp;
    }
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        if (emp1 is null || emp2 is null)
            return false;
        return emp1.Salary == emp2.Salary;
    }
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }
    public static bool operator <(Employee emp1, Employee emp2)
    {
        return emp1.Salary < emp2.Salary;
    }
    public static bool operator >(Employee emp1, Employee emp2)
    {
        return emp1.Salary > emp2.Salary;
    }
    public override bool Equals(object obj)
    {
        if (obj is Employee other)
        {
            return this.Salary == other.Salary;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return Salary.GetHashCode();
    }
    public override string ToString()
    {
        return $"Name: {Name}, Salary: {Salary:C}";
    }
}
