// Написать программу которая на вход принимает 2 числа и проверяет евляется ли
// первое число квадратом второго
//  а = 25, в = 5 -> да
Console.Clear();
Console.WriteLine("Hello, Sqware =) ");
Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.Write("add first value -> ");
int number_a = Convert.ToInt32(Console.ReadLine());
Console.Write("add second value -> ");
int number_b = Convert.ToInt32(Console.ReadLine());
if (number_a / number_b == number_b)
{
    Console.WriteLine($"число {number_a} является квадратом числа {number_b}");
}
else
{
    Console.WriteLine($"число {number_a} не является квадратом числа {number_b}");
}
