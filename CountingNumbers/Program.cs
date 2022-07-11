// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a integer number:");
var input = Console.ReadLine()!;
try
{
  var len = Math.Round(Math.Log10(Math.Abs(int.Parse(input))))+1;
  Console.ForegroundColor = ConsoleColor.Green;
  Console.WriteLine($"{input} contains {len} numbers.");
}
catch
{
  Console.ForegroundColor = ConsoleColor.Red;
  Console.WriteLine($"{input} is not integer number.");
}
