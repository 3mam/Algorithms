using System.Text.RegularExpressions;

string[] Combination(string[] element)
{
  if (element.Length == 0) return new string[1];
  var firstElement = element[0];
  var restElements = element[1..];
  var combinationsWithoutFirst = Combination(restElements);
  var combinationsWithFirst = combinationsWithoutFirst
    .Select(s => s + firstElement).ToArray();

  var combined = new string[combinationsWithFirst.Length + combinationsWithoutFirst.Length];
  combinationsWithoutFirst.CopyTo(combined, 0);
  combinationsWithFirst.CopyTo(combined, combinationsWithoutFirst.Length);
  return combined;
}

Console.WriteLine("Enter a string of characters:");
var input = Console.ReadLine()!;
var splitSentence = new Regex("").Split(input)[1..^1];
var combination = Combination(splitSentence)
  .Skip(1)
  .ToList()
  .OrderBy(s => s.Length)
  .ToArray();
foreach (var str in combination)
  Console.WriteLine($"\"{str}\"");