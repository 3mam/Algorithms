﻿// See https://aka.ms/new-console-template for more information

// example input: eat ate apt pat tea now

Console.WriteLine("Put list of anagrams for sorting:");
var input = Console.ReadLine()!.Split(" ");
var sortList = input.GroupBy(SortChars).ToList();

Console.WriteLine("Sorted list of anagrams:");
sortList.ForEach(list =>
  {
    list.ToList().ForEach(word => Console.Write($"{word} "));
    Console.WriteLine();
  }
);

string SortChars(string word)
{
  var chars = word.ToLower().ToCharArray();
  Array.Sort(chars);
  return new string(chars);
}