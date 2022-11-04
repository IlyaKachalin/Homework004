// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

Console.WriteLine("Введите координаты точки А:");
Console.Write("x1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1 = ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1 = ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
Console.Write("x2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2 = ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2 = ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance (x1,x2,y1,y2,z1,z2);
Console.Write("Расстояние между заданными точками равно ");
Console.Write (Math.Round(distance,2,MidpointRounding.ToZero));

double Distance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return distance;
}
