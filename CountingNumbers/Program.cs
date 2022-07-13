// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter a number:");
var input = Console.ReadLine()!;
var len = input
  .Where(char.IsDigit)
  .Count();

Console.ForegroundColor = len != 0 ? ConsoleColor.Green : ConsoleColor.Red;
Console.WriteLine($"{input} contains {len} numbers.");