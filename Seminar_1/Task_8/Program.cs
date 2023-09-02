// Написать программу которая на вход принимает 3 числа и выдает максимальное из этих чисел

Console.WriteLine("Hello, Min/max");
Console.Clear();
Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.Write("Add number a =  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Add number b =  ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Add number c =  ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max < b) max = b;
if (max < c) max = c;
Console.WriteLine(max);
