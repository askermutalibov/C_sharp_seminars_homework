// С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа


double RandomNumber;
Console.WriteLine("Введите число от 10 (включительно) до 99 (включительно)");
string? s = Console.ReadLine();
RandomNumber = Convert.ToDouble(s);
if ((RandomNumber % 10) > (RandomNumber / 10))
{
    Console.WriteLine((RandomNumber % 10));
}
if ((RandomNumber % 10) < (RandomNumber / 10))
{
    Console.WriteLine((RandomNumber / 10));
}
if (RandomNumber > 99)
{
    Console.WriteLine("Введите число не более 99");
}
if (RandomNumber < 10)
{
    Console.WriteLine("Введите число не менее 10");
}