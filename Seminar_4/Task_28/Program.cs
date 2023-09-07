// Написать программу которая на ввод принимает число n и на выводе дает
// произведение этих чисел от 1 до n

Console.Clear();
Console.WriteLine("Hello, * ");


int EnterData(string data)
{
    Console.Write(data);
    int intenger = Convert.ToInt32(Console.ReadLine());
    return intenger;
}

void Composition (int arg)
{
    int count = 1;
    int answer = 1;
    while (count <= arg)
    {
        answer *= count;
        count++; 
    }
    Console.WriteLine($"Composition = {answer}");
}

int n = EnterData("Enter N -> ");
Composition(n);
