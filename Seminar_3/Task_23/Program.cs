// Написать программу которая принимает на ввод число и выдает таблицу кубов от 1 до N
Console.Clear();
Console.WriteLine("Hello, Sqr!");
int EnterData(string data)
{
    Console.Write(data);
    int intenger = Convert.ToInt32(Console.ReadLine());
    return (intenger);
}

void Qube (int n)
{
    int coint = 1;
    while (coint <= n)
    {
        int answer = coint * coint * coint;
        Console.Write($"{answer}  ");
        coint++;
    }
}


int n = EnterData("add N -> ");
Qube (n);
