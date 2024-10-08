﻿using ElementalWords;

var word = "snack";

var periodicTable = new PeriodicTable();

var elementalWords = new ElementalWords.ElementalWords(periodicTable);
var results = elementalWords.ElementalForms(word);

if (!results.Any())
{
    Console.WriteLine($"No ElementalForms found for word: {word}");
    return;
}


Console.WriteLine($"Found ElementalForms for word: {word}");
Console.WriteLine();

int resultNumber = 1;
foreach (var result in results)
{
    Console.WriteLine($"Result {resultNumber}:");
    var elementRow = string.Join(", ", result);
    Console.WriteLine(elementRow);
    Console.WriteLine("-----------------------------");
    Console.WriteLine();

    resultNumber++;
}