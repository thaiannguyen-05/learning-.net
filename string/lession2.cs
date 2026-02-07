using System;

class Lesson2
{
    static void Main()
    {
        string text = "Hello World";
        string newText = text.Replace("Hello", "Hi");
        Console.WriteLine(newText);

        Console.WriteLine(newText.ToUpper());
        Console.WriteLine(newText.ToLower());

        Console.WriteLine(newText.Contains("")); // boolean that like where name like ? 
        
        Console.WriteLine(newText.StartsWith("You"));

        Console.WriteLine(newText.EndsWith("Google"));
    }
}
