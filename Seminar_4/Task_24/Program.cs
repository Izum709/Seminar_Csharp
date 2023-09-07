// Написать программу которая на вход принимает число и выдает сумму этих чисел
// от 1 до N

Console.Clear();
Console.WriteLine("Hello, Summ");

int EnterData(string data)
{
    Console.Write(data);
    int intenger = Convert.ToInt32(Console.ReadLine());
    return intenger;
}

int Summa(int n)
{
    
    int summa = 0;
    for (int i = 1; i <= n; i++)
    {
       summa = summa + i; 
    }
    return summa; 
}

int n = EnterData("Enter N -> ");
Console.WriteLine(Summa(n));

