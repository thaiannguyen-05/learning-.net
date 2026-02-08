void logElements<T> (List<T> list)
{
    foreach(var element in list)
    {
        Console.WriteLine(element);
    }
}


List<string> names = ["andev", "ok"];
logElements(names);


List<int> numbers = [1, 2, 3, 4];
logElements(numbers);