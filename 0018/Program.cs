// По двум заданным числам проверять является ли одно квадратом другого (с использованием метода)

bool Check(int a, int b)
{
    return a*a == b;
}

int a, b;
System.Console.Write("Введите число: ");
string? s = Console.ReadLine();
a = Convert.ToInt32(s);
System.Console.Write("Введите число: ");
s = Console.ReadLine();
b = Convert.ToInt32(s);

if (Check(a,b))
{
    System.Console.WriteLine("b является квадратом a");
}
else
{
    if (Check(b,a))
    {
        System.Console.WriteLine("а является квадратом b");
    }
    else
    {
        System.Console.WriteLine("Числа не являются квадратами друг друга");
    }
}