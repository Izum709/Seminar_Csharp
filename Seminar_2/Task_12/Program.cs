// Написать программу которая на вход принимает 2 числа и выводит,
//  является ли второе число кратным первому, если не кратно то 
// программа выводит остаток от деления. 

void Multiplisity(int arg1, int arg2)
{
    int remains = 0;
    if (arg1 % arg2 == 0)
    {
        Console.WriteLine($"Второе число кратно первому");
    }
    else
    {
        remains = arg1 % arg2;
        Console.WriteLine($"Второе число НЕ кратно первому, остаток = {remains}");
    }
}


Console.Clear();
Console.Write("add first number -> ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("add second number -> ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Multiplisity(firstNumber, secondNumber);