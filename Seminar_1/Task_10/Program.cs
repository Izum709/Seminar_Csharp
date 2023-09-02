// Написать программу которая которая на вход принимает число, а на выходе показывает
// все четные числа от 1 до N


Console.Clear();
Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("=) %2 =)");
Console.Write("Add number N =  ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count < n)
{
    
    if (count % 2 == 0)
    {
        Console.Write($"{count}, ");
    }
    count += 1;
}   
