// Написать программу которая на вход принимает 2ва значения а на выходе показывает
// значение первого числа в степени второго числа
Console.Clear();
Console.WriteLine("Hello, Degree!");


int Degree(int arg1, int arg2)
{
    int answer = arg1;
    for (int i = 0; i < arg2 - 1; i++)
    {
        answer = answer * arg1;
    }
    return answer;
}

int EnterData(string text)
{
    Console.Write(text);
    return(Convert.ToInt32(Console.ReadLine()));
}

int numberA = EnterData("add first number -> ");
int numberB = EnterData("add first number -> ");
Console.WriteLine($"{numberA} in degree {numberB} = {Degree(numberA, numberB)}");
