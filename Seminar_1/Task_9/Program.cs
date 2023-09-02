// Написать программу которая принимает на ввод число и выдает евляется ли оно четным

Console.WriteLine("=) %2 =)");
Console.Clear();
Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.Write("Add number a =  ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0) Console.WriteLine($"{a} евляется четным");
else Console.WriteLine($"{a} евляется НЕ четным");