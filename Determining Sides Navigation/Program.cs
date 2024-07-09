// See https://aka.ms/new-console-template for more information
using Determining_Sides_Navigation;

var lineStart = new Coordinates(20.3, 41.2);
var lineEnd = new Coordinates(40.4, 46.7);
var pointToDetermine = new Coordinates(33.5, 34.2);

var position = SideDeterminer.DetermineCoordinatePosition(lineStart, lineEnd, pointToDetermine);

Console.WriteLine($"The point is on {position} the line.");
Console.ReadLine();


