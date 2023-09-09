// Написать программу которая выводит массив из 0 и 1 в сдучайном порядке.
// Красивый вывод String.Join()
Console.Clear();
Console.WriteLine("Hello, Massive!");

int EnterData(string text)
{
    Console.Write(text);
    return(Convert.ToInt32(Console.ReadLine()));
}

void FillMassive(int[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        arg[i] = new Random().Next( 2);
    }
    Console.Write($"[{String.Join(", ", arg)}]");
    
}

int lengthMassive = EnterData("Add length massive -> ");
int[] massive = new int[lengthMassive];
FillMassive(massive);


