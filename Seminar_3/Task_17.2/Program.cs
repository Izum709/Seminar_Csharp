// Написать программу которая на вход принимает координаты x и y а на выходе указывает 
// четверть расположения точки используя функции EnterData

Console.Clear();
Console.WriteLine("Hello, Function!");

int EnterData(string data)
{
    Console.WriteLine(data);
    int intenger = Convert.ToInt32(Console.ReadLine());
    return (intenger);
}


int x = EnterData("Введите данные -> ");
int y = EnterData("Введите данные -> ");
if(x > 0 && y > 0) Console.WriteLine(" 1 четверть ");
if(x > 0 && y < 0) Console.WriteLine(" 4 четверть ");
if(x < 0 && y < 0) Console.WriteLine(" 3 четверть ");
if(x < 0 && y > 0) Console.WriteLine(" 2 четверть ");