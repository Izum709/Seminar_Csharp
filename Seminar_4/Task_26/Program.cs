// Написать программу которая на ввод принимает число и выдает количество цифр в числе
//  1234 -> 4
Console.Clear();
Console.WriteLine("Hello, Count!");


int Count (int n)
{
    int count = 0;
    while (n > 0)
    {
        n /= 10;
        count++; 
    }
    return count;
}


int EnterData(string data)
{
    Console.Write(data);
    int intenger = Convert.ToInt32(Console.ReadLine());
    return intenger;
}

int n = EnterData("Enter N -> ");
Console.Write(Count(n));