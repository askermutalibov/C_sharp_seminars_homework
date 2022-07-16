// Удалить вторую цифру целого числа введенного с клавиатуры.

int a;
Console.WriteLine("Введите целое число");
string? s = Console.ReadLine();
a = Convert.ToInt32(s);
do
{
    a = (a/10);
} while ((a%10)>0);
Console.WriteLine(a); // не разобрался с решением