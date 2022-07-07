// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter a number that is strobogrammatic prime.");
var input = Console.ReadLine()!;
try
{
  CheckIfContainProperNumbers(input);
  var rotate = Rotate180Degree(input);
  CheckIsStrobogrammaticNumber(input, rotate);
  CheckIsPrimeNumber(rotate);
  Console.ForegroundColor = ConsoleColor.Green;
  Console.WriteLine($"{input} is strobogrammatic prime number.");
}
catch (Exception e)
{
  Console.ForegroundColor = ConsoleColor.Red;
  Console.WriteLine($"{input} {e.Message}");
}

void CheckIsPrimeNumber(string number)
{
  var n = int.Parse(number);
  var tmp = 0;
  for (var i = 2; i <= n / 2; i++)
    if (n % i == 0)
      tmp++;
  if (tmp != 0)
    throw new Exception("is strobogrammatic, but not prime number.");
}

void CheckIsStrobogrammaticNumber(string number, string reversNumber)
{
  if (!reversNumber.Contains(number))
    throw new Exception("is not strobogrammatic number.");
}

void CheckIfContainProperNumbers(string number)
{
  foreach (var c in number)
  {
    switch (c)
    {
      case '0' or '1' or '6' or '8' or '9':
        continue;
      default:
        throw new Exception("is not contain proper number.");
    }
  }
}

string Rotate180Degree(string number)
{
  var revers = number.Select(c => c switch
    {
      '6' => '9',
      '9' => '6',
      _ => c
    })
    .Reverse()
    .ToArray();
  return new string(revers);
}