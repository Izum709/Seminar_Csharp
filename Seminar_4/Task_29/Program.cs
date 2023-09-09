// Написать программу которая выводит массив из n элементов
// количество элементов вводится через терминал

Console.Clear();
Console.WriteLine("Hello, World!");


void FillPrintMassive (int[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        arg[i] = new Random().Next(20);
    }
    Console.Write($"[{String.Join(", ", arg )}]");
}

int EnterData(string text)
{
    Console.Write(text);
    return(Convert.ToInt32(Console.ReadLine()));
}

int lengthMassive = EnterData(" Add length Massive -> ");
int[] massive = new int[lengthMassive];
FillPrintMassive(massive);
