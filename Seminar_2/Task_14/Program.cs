// Написать программу которая принимает на вход число и выводит 
// является ли оно одновременно кратным 7 и 23

void Multiplisity(int arg)
{
    if (arg % 7 == 0 && arg % 23 == 0)
    {
        Console.WriteLine("-> ДА");
    }
    else
    {
        Console.WriteLine("-> НЕТ");
    }
}


Console.Clear();
Console.WriteLine("Hello, multiplisity");
Console.WriteLine("Введите число -> ");
int number = Convert.ToInt32(Console.ReadLine());
Multiplisity(number);

