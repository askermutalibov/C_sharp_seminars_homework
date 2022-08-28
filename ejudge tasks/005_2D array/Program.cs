// Найти положение первого нулевого элемента в матрице. Вывести сначала номер строки элемента, а потом номер столбца

Console.WriteLine("Введите 2 целых числа для определения размера массива (первое число определяет количество строк, второе - количество столбцов (количество столбцов и строк должно быть больше 1): ");
string readNumbers = Console.ReadLine();
Console.WriteLine(); // для отделения длины массива по строкам и столбцам от самого массива с конкретными элементами
int n = int.Parse(readNumbers.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]);
int m = int.Parse(readNumbers.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
int[,] booleanArray = new int[n, m];

Console.WriteLine($"Введите {n} чисел подряд одной строкой через пробел и {m} чисел подряд через клавишу Enter для заполнения столбцов массива: ");
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    readNumbers = Console.ReadLine();
    string[] splitArr = readNumbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    for (int j = 0; j < splitArr.Length; j++)
    {
        booleanArray[i, j] = int.Parse(splitArr[j]);
    }
}

Console.WriteLine(); Console.WriteLine("Ваш массив выглядит так: ");

for (int i = 0; i < booleanArray.GetLength(0); i++)
{
    for (int j = 0; j < booleanArray.GetLength(1); j++)
    {
        Console.Write($"{booleanArray[i, j]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < booleanArray.GetLength(0); i++)
{
    for (int j = 0; j < booleanArray.GetLength(1); j++)
    {
        if (booleanArray[i, j] == 0)
        {
            Console.WriteLine($"{i + 1} нулевой элемент массива находится на {i} строке {j} столбца");
        }
    }
    Console.WriteLine();
}