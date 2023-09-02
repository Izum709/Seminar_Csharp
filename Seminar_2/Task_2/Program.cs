// Написать программу которая выводит рандомное 3х значное число и удаляет 2ю цифру


void Numbers(int number)
{
    int lust = number % 10;
    int middle = (number /10) % 10;
    int first = number / 100;
    Console.Write(first);
    Console.Write(lust);
}


Console.Clear();
Console.WriteLine("Hello, Random!");
int number = new Random().Next(100, 999);
Console.WriteLine(number);
Numbers(number);
