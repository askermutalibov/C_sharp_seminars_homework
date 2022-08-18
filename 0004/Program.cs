// По заданному с клавиатуры номеру дня недели вывести его название

// Вариант №1: "топорный"

/*

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

*/

// Вариант №2 "рефакторинг"

int dayOfWeek = Convert.ToInt32(Console.ReadLine()); // dayOfWeek: camelCase # DayOfWeek: Pascal Case

switch(dayOfWeek) // функция выбора одного из возможных вариантов
{
    case 1:
    System.Console.WriteLine("Сегодня понедельник");
    break;
    case 2:
    System.Console.WriteLine("Сегодня вторник");
    break;
    case 3:
    System.Console.WriteLine("Сегодня среда");
    break;
    case 4:
    System.Console.WriteLine("Сегодня четверг");
    break;
    case 5:
    System.Console.WriteLine("Сегодня пятница");
    break;
    case 6:
    System.Console.WriteLine("Сегодня суббота");
    break;
    case 7:
    System.Console.WriteLine("Сегодня воскресенье");
    break;
    default:
    System.Console.WriteLine("Введите номер дня недели от 1 до 7 включительно");
    break;
}

// Вариант 3: через массив стрококовых данных (string)

Console.Write("Введите номер дня недели: ");
string userD = Console.ReadLine();
int D = Convert.ToInt32(userD);
string[] weekDays = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.WriteLine(weekDays[D - 1]); // нумерация массива с 0