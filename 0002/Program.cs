// С клавиатуры вводится целое число. Необходимо вывести квадрат числа

int a,b;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);

if (a*a==b) // если равно
{
    System.Console.WriteLine("b является квадратом a");
}
else
{
    if (b*b==a)
    {
        System.Console.WriteLine("а является квадратом b");
    }
    else
    {
        System.Console.WriteLine("Числа не являются квадратами друг друга");
    }
} // от этих фигурных скобок можно избавиться, если во вложенных условиях if, then и else есть только одно действие




/*
if (2*2==4) // полное условие
{
     // true
}
else
{
     // false
}

if (2*2==4) // неполное условие
{
     // true
}
*/