//  Написать программу которая по введенной четверти выдает диапазон
// возможных значений X & Y



Console.Clear();
int EnterData(string data)
{
    Console.Write(data);
    int intenger = Convert.ToInt32(Console.ReadLine());
    return (intenger);
}


int data = EnterData("Введите номер четверти ");
if (data == 1) Console.WriteLine(" x > 0 & y > 0");
if (data == 2) Console.WriteLine(" x < 0 & y > 0");
if (data == 3) Console.WriteLine(" x < 0 & y < 0");
if (data == 4) Console.WriteLine(" x > 0 & y < 0");