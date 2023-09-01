// Написать программу которая на вход принимает два числа и выдает какое число большее,
//  а какое меньшее.
//  a = 5, b = 7 -> max = 7


Console.WriteLine("Hello Comparsion");
Console.Clear();
Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.Write("Add number a =  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Add number b =  ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write($"Max = {a}");
}
else
{
    Console.Write($"Max = {b}");

}