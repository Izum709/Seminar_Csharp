// Написать программу которая на вход принимает трехзначное число 
// а на выходе показывает последнюю цифру этого числа


Console.Clear();
Console.WriteLine("Hello, third number");
Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("Введите 3х значное число -> ");
int n = Convert.ToInt32(Console.ReadLine());
int number = n % 10;
Console.WriteLine(number);
