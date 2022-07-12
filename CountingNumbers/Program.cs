// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a number:");
var input = Console.ReadLine()!;
var len = input
  .Where(char.IsDigit)
  .Count();
if (len > 0)
{
  Console.ForegroundColor = ConsoleColor.Green;
  Console.WriteLine($"{input} contains {len} numbers.");
}
else
{
  Console.ForegroundColor = ConsoleColor.Red;
  Console.WriteLine($"{input} don't contains an numbers.");
}
