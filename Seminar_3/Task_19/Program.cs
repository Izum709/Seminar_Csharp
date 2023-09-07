// Написать прогрпмму которая на вход принимает пятизначное число
//  и проверяет евляется ли оно палиндромом.

Console.Clear();
Console.WriteLine("Hello, Палиндром");


void Polindrom(int arg)
{
    int a = arg / 10000;
    int b = (arg / 1000) % 10;
    int c = (arg % 100) / 10;
    int d = arg % 10;
    Console.Write($"{a}, {b}, {c}, {d} -> ");
    if (a == d && c == b)
    {
        Console.Write(" N -> Палиндром ");
    }
    else
    {
        Console.Write(" N -> Не палиндром ");
    }
}


int EnterData(string data)
{
    Console.Write(data);
    int intenger = Convert.ToInt32(Console.ReadLine());
    return intenger;
}

int n = EnterData("Add n = -> ");
Console.WriteLine(n);
Polindrom(n);