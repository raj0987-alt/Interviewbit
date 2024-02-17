decimal A = 3;
decimal B = 17;

var days = 5;

var TotalSell = (B) / A;

var result = (TotalSell / days);
var d = Math.Ceiling(result);
var r = (int)d;
Console.WriteLine(TotalSell);
Console.WriteLine(r);