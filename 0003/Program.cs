// С клавиатуры вводятся два числа a и b. Найти максимальное из них.

double a;
double b;
Console.Write("Введите число: ");
string? s = Console.ReadLine();
a = Convert.ToInt32(s);
Console.Write("Введите число: ");
s = Console.ReadLine();
b = Convert.ToInt32(s);

if (a >= b)
{
    Console.WriteLine("Максимальное число: ");
    Console.WriteLine(a);
}
Console.WriteLine("Максимальное число: ");
Console.WriteLine(b);