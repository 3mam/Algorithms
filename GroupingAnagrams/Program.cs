// See https://aka.ms/new-console-template for more information

// example input: eat ate apt pat tea now

Console.WriteLine("Put list of anagrams for sorting:");
var input = Console.ReadLine()!.Split(" ");
var sortList = input.GroupBy(
  key => key,
  new Comparer()
).ToList();

Console.WriteLine("Sorted list of anagrams:");
sortList.ForEach(list =>
  {
    list.ToList().ForEach(word => Console.Write($"{word} "));
    Console.WriteLine();
  }
);

#nullable disable
public class Comparer : IEqualityComparer<string>
{
  public bool Equals(string x, string y)
    => SortChars(x) == SortChars(y);

  public int GetHashCode(string obj)
    => SortChars(obj).GetHashCode();

  private string SortChars(string word)
  {
    var chars = word.ToLower().ToCharArray();
    Array.Sort(chars);
    return new string(chars);
  }
}