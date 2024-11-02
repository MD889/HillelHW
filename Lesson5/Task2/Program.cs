internal class Program
{
    private static void Main(string[] args)
    {
        Shop shop = new Shop("Lorem", "ipsum", ShopType.Grocery);
        shop.DisplayInfo();

        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}
