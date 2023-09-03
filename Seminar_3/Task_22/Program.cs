// Написать программу которая на вход принимает число и 
// выдает таблицу квадратных чисел от 1 до N

Console.Clear();
Console.WriteLine("Hello, Sqr!");
int EnterData(string data)
{
    Console.Write(data);
    int intenger = Convert.ToInt32(Console.ReadLine());
    return (intenger);
}


void SQR (int arg)
{
    int count = 1;
    while (count <= arg)
    {
        int answer = count * count;
        Console.Write($"{answer}, ");
        count = count + 1;
    }
}


int n = EnterData("add N -> ");
SQR(n);