using System;

public class Product : Money
{
    public Product(int input1, int input2, string input3) : base (input1, input2)
    {
        string Price = input3;
    }
    public void PriceChange(int dollaramount, int centamount)
    {
        int fullprice = dollars * 100 + cents;
        int fullamount = dollaramount * 100 + centamount;
        fullprice = fullprice + fullamount;
        dollars = fullprice / 100;
        cents = fullprice - dollars * 100;
        Round();
    }
}
