// Написать программу которая на вход принимает число и выдает сумму цифр в числе


Console.Clear();
Console.WriteLine("Hello, Summ of number!");

int Summ (int n)
{
    int number = n;
    int summ = 0;
    while (n > 0)
    {
        number = n % 10;
        summ += number;
        n = n / 10;
    }
    return summ;
}

int EnterData(string text)
{
    Console.Write(text);
    return(Convert.ToInt32(Console.ReadLine()));
}


int number = EnterData(" Add number -> ");
Console.Write(Summ(number));

