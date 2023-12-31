﻿using PSB_Test_Assignment;

var parser = new InputDataParser();
var calculator = new ScoreCalculation();

var data = InputDataParser.ReadInputData(@"Match Results\matchResults.txt");
var results = parser.ParseInputData(data);

(int teamOneScore, int teamTwoScore) = calculator.CalculateScore(results);

Console.WriteLine($"Final results: Team One = {teamOneScore}, Team Two = {teamTwoScore}");

Console.ReadLine();
