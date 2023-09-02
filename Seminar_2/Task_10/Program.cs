// Написать программу которая принимает на вход трехзначное число, 
// а на выходе показывает 2ю цифру этого числа


int MiddleNumber(int arg)
{
    int middle = (arg / 10) % 10;
    return middle;
}


Console.Clear();
Console.WriteLine("Hello, Middle number!");
Console.Write("add number -> ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вторая цифра числа {number} это {MiddleNumber(number)}");

