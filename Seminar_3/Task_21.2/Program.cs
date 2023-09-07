// Написать программу которая принимает на вход координаты 2х точек и высчитывает
// расстояние между ними в 2D пространстве
Console.Clear();
int EnterData(string data)
{
    Console.Write(data);
    int intenger = Convert.ToInt32(Console.ReadLine());
    return (intenger);
}

double GPS(int x1, int y1, int z1,  int x2, int y2, int z2)
{
    double answer = Math.Sqrt(((x1 - x2)*(x1 - x2)) +((y1 - y2)*(y1 - y2) + (z1 - z2)*(z1 - z2)));
    return answer;
}

int x1 = EnterData("Add x1 ->  ");
int y1 = EnterData("Add y1 ->  ");
int z1 = EnterData("Add z1 ->  "); 

int x2 = EnterData("Add x2 ->  ");
int y2 = EnterData("Add y2 ->  ");
int z2 = EnterData("add z2 ->  "); 

Console.WriteLine(GPS(x1, y1, z1,  x2, y2, z2));
