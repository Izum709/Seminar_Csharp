// Написать программу которая на вход принимает координаты x и y а на выходе указывает 
// четверть расположения точки
Console.Clear();
Console.WriteLine("Hello, X & Y!");
Console.Write("Add x -> ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Add y -> ");
int y = Convert.ToInt32(Console.ReadLine());
if(x > 0 && y > 0) Console.WriteLine(" 1 четверть ");
if(x > 0 && y < 0) Console.WriteLine(" 4 четверть ");
if(x < 0 && y < 0) Console.WriteLine(" 3 четверть ");
if(x < 0 && y > 0) Console.WriteLine(" 2 четверть ");


