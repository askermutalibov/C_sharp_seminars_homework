// Выяснить являются ли 3 числа сторонами треугольника с помощью проверки теоремы неравенства треугольников (согласно которой длина любой стороны треугольника всегда меньше суммы 2 других его сторон)


bool IsThisAnTreangle(double a, double b, double c)
{
    return (a + b > c && b + c > a && a + c > b);
}

double a = 3, b = 4, c = 5;

if (IsThisAnTreangle(a, b, c))
{
    Console.WriteLine();
    Console.WriteLine("Это треугольник.");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Это не треугольник.");
}