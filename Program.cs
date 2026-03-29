// See https://aka.ms/new-console-template for more information
using apbd_cw1_git_s29640;

Console.WriteLine("Enter numbers separated by spaces:");

string? input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Error: no input provided.");
    return;
}

try
{
    int[] values = input
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    int sum = StatisticsHelper.CalculateSum(values);
    double average = StatisticsHelper.CalculateAverage(values);
    int max = StatisticsHelper.CalculateMax(values);

    Console.WriteLine($"Sum = {sum}");
    Console.WriteLine($"Average = {average}");
    Console.WriteLine($"Max = {max}");
}
catch
{
    Console.WriteLine("Error: please enter valid integers.");
}
