internal class Program
{
    private static void Main(string[] args)
    {
        Play play = new Play("Lorem", "ipsum", "dolor", 1875);
        play.DisplayInfo();

        GC.Collect();
        GC.WaitForPendingFinalizers();

        Shop shop = new Shop("Lorem", "ipsum", ShopType.Grocery);
        shop.DisplayInfo();

        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}