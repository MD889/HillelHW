MyArray array = new MyArray([1, 3, 2]);
array.SortAsc();
foreach (int element in array.array)
{
    Console.WriteLine(element);
}
array.SortDesc();
foreach (int element in array.array)
{
    Console.WriteLine(element);
}
array.SortByParam(true);
foreach (int element in array.array)
{
    Console.WriteLine(element);
}
array.SortByParam(false);
foreach (int element in array.array)
{
    Console.WriteLine(element);
}