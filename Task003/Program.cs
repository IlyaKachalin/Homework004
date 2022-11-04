// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

Console.Write("Введите число (N). N = ");
int n = Convert.ToInt32(Console.ReadLine());

void Cube (int x)
{
    for (int i = 0; i<=x; i++) Console.WriteLine ($"{i}  {i*i*i}");
}

Cube(n);