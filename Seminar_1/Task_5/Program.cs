// Напишите программу которая на вход принимает число, а на выходе показывает все числа от -N до N
Console.Clear();
Console.WriteLine("Hello, Numbers =) ");
Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("Введите число -> ");
int n = Convert.ToInt32(Console.ReadLine());
int count = -n;
while (count <= n )
{
    Console.Write($"{count}, ");
    count += 1;
}

