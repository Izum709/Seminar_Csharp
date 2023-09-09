// Написать программу которая выводит массив из 0 и 1 в сдучайном порядке.
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
        arg[i] = new Random().Next(0, 2);
        Console.Write(arg[i]);
    }
}


int lengthMassive = EnterData("Add length massive -> ");
int[] massive = new int[lengthMassive];
FillMassive(massive);
