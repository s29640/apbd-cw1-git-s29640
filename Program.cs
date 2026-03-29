// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter numbers separated by spaces:");

string? input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Error: no input provided.");
    return;
}

Console.WriteLine($"You entered: {input}");
