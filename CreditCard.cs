using System;

public class CreditCard
{
    public string CardNumber;
    private int cvc;
    public int CVC
    {
        get { return cvc; }
        set
        {
            if (value < 100 || value > 999)
                throw new ArgumentException("CVC must consist of three digits");
            cvc = value;
        }
    }
    private int balance;
    public int Balance
    {
        get { return balance; }
        set
        {
            balance = value;
        }
    }
    public CreditCard(string cardNumber, int cvc, int balance)
    {
        CardNumber = cardNumber;
        CVC = cvc;
        Balance = balance;
    }
    public static CreditCard operator +(CreditCard card, int amount)
    {
        card.Balance += amount;
        return card;
    }
    public static CreditCard operator -(CreditCard card, int amount)
    {
        card.Balance -= amount;
        return card;
    }
    public static bool operator ==(CreditCard card1, CreditCard card2)
    {
        return card1.CVC == card2.CVC;
    }
    public static bool operator !=(CreditCard card1, CreditCard card2)
    {
        return card1.CVC != card2.CVC;
    }
    public static bool operator <(CreditCard card1, CreditCard card2)
    {
        return card1.Balance < card2.Balance;
    }
    public static bool operator >(CreditCard card1, CreditCard card2)
    {
        return card1.Balance > card2.Balance;
    }
    public override bool Equals(object obj)
    {
        if (obj is CreditCard other)
        {
            return this.CVC == other.CVC;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return CVC.GetHashCode();
    }
}