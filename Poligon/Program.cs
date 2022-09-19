using Poligon.GC;

var destructor = new Destructor();
GC.Collect();
var largeObj = new byte[85000];
var smallObj = new byte[1000];
Console.WriteLine(GC.GetGeneration(smallObj));
Console.WriteLine(GC.GetGeneration(destructor));
Console.WriteLine(GC.GetGeneration(largeObj));
Console.ReadKey();