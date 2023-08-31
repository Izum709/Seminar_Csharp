// Написать программу которая будет выводить информацию по дням недели по заданному номеру
// 1 -> Понедельник


Console.Clear();
Console.WriteLine("Hello, Week");
Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine("Введите число от 1 до 7");
int week_day = Convert.ToInt32(Console.ReadLine());
if (week_day == 1) Console.WriteLine("Понедельник");
if (week_day == 2) Console.WriteLine("Вторник");
if (week_day == 3) Console.WriteLine("Среда");
if (week_day == 4) Console.WriteLine("Четверг");
if (week_day == 5) Console.WriteLine("Пятница");
if (week_day == 6) Console.WriteLine("Суббота");
if (week_day == 7) Console.WriteLine("Воскресенье");