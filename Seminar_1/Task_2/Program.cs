// See https://aka.ms/new-console-template for more information
// Напишите программу которая на вход принимает число и возвращает квадрат этого числа
// число умноженное само на себя используя конвертацию и метод вывода в строку
Console.WriteLine(" Hello Square =) ");
Console.Write(" add value -> ");
int a = Convert.ToInt32(Console.ReadLine());
int sqr = a * a;
// Console.Write("  input -> ");
// Console.WriteLine(a);
// Console.Write("  Square = ");
// Console.WriteLine(sqr);
Console.Write($"квадратом числа {a} евляется число {sqr}");
