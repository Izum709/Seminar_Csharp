// Написать программу которая выводит случайное число из отрезка от 10 до 99 и 
// показывает наибольшую цифру числа
Console.Clear();
Console.WriteLine("Hello, Random!");
int number = new Random().Next(10, 99);
Console.WriteLine(number);
int a1 = number / 10;
int a2 = number % 10;
if (a1 > a2)
{
    Console.WriteLine($"В числе {number} цифра {a1} больше чем {a2}");
}
if( a1 == a2)
{
    Console.WriteLine($"В числе {number} цифра {a1} равна {a2}");
}
else
{
    Console.WriteLine($"В числе {number} цифра {a2} больше чем {a1}");
}
