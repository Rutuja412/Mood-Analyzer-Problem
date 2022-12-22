
using System;
using MoodAnalyzerUC1;


Console.WriteLine("Sad or Happy");
string input = Console.ReadLine();

MoodAnalyserClass analyse = new MoodAnalyserClass(input);
Console.WriteLine(analyse.Analyse());
