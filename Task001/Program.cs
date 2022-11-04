// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

Console.Clear();

Console.Write("Введите пятизначное число: ");
int x = Convert.ToInt32(Console.ReadLine());

string palindrom = Palindrom(x);
Console.WriteLine(palindrom);

string Palindrom(int x)
{
    string result = string.Empty;
    if (x > 9999 && x < 100000 || x > -100000 && x <-9999)
    {
        int firstDigit = x/10000; 
        int secondDigit = (x/1000)%10; 
        int forthDigit = (x/10)%10; 
        int fifthDigit = x%10; 
        if (firstDigit==fifthDigit && secondDigit==forthDigit) Console.WriteLine("Палиндром");
        else Console.WriteLine("Число не является палиндромом");
    }
    
    else Console.WriteLine("Вы ввели неправильное число");
    return result;
}

