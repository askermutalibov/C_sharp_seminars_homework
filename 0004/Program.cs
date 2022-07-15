// По заданному с клавиатуры номеру дня недели вывести его название

int DayNumber;

Console.Write("Введите номер дня недели: ");

string? s = Console.ReadLine();

DayNumber = Convert.ToInt32(s);

if (DayNumber==1)
{
    Console.Write("Сегодня понедельник");
}
else
{
    if (DayNumber==2)
    {
        Console.Write("Сегодня вторник");
    }
    if (DayNumber==3)
    {
        Console.Write("Сегодня среда");
    }
    if (DayNumber==4)
    {
        Console.Write("Сегодня четверг");
    }
    if (DayNumber==5)
    {
        Console.Write("Сегодня пятница");
    }
    if (DayNumber==6)
    {
        Console.Write("Сегодня суббота");
    }
    if (DayNumber==7)
    {
        Console.Write("Сегодня воскресенье");
    }
    if (DayNumber>7)
    {
        Console.Write("Введите число от 1 до 7 включительно");
    }
}