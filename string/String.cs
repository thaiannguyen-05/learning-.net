// normal log
string greeting = "                  HELLO WORD";
Console.WriteLine($"{greeting}");

// trim only head
string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"{trimmedGreeting}");

// trim only end
trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"{trimmedGreeting}");

// trim between 
trimmedGreeting = greeting.Trim();
Console.WriteLine($"{trimmedGreeting}");