// Задача 42A. Даны две квадратных таблицы чисел. Требуется построить третью, каждый элемент которой равен сумме элементов, стоящих на том же месте в 1-й и 2-й таблицах. Входные данные: Во входном файле записано сначала число N, затем записана первая таблица, а после нее - вторая. Элементы таблиц - числа от 0 до 100. 100>=N>=1.

int[,] FirstArray = new int[8, 8];

int[,] SecondArray = new int[8, 8];

int[,] ThirdArray = new int[8, 8];

void Solution(int[,] First, int[,] Second, int[,] Third) // реализовать через конкретные методы наполнения и вывода каждого из 3 массивов на экран не удалось, для обхода ошибки компилятора (отсуствие переменных или массивов в текущих контекстах) я объединил все итерации в один метод void.
{
    Random numbers = new Random();

    First = new int[8, 8];
    Second = new int[8, 8];
    Third = new int[8, 8];

    Console.WriteLine();
    Console.WriteLine("Первый двумерный массив натуральных целых чисел выглядит следующим образом: "); // пустые строки перед выводом массивов для удобства

    for (int i = 0; i < First.GetLength(0); i++)
    {
        for (int j = 0; j < First.GetLength(1); j++)
        {
            First[i, j] = numbers.Next(0, 101);
            Console.Write($"{First[i, j], 12}");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("Второй двумерный массив натуральных целых чисел выглядит следующим образом: ");

    for (int i = 0; i < Second.GetLength(0); i++)
    {
        for (int j = 0; j < Second.GetLength(1); j++)
        {
            Second[i, j] = numbers.Next(0, 101);
            Console.Write($"{Second[i, j], 12}");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("Третий двумерный массив натуральных целых чисел выглядит следующим образом: ");

    for (int i = 0; i < Third.GetLength(0); i++)
    {
        for (int j = 0; j < Third.GetLength(1); j++)
        {
            Third[i, j] = First[i, j] + Second[i, j];
            Console.Write($"{Third[i, j], 12}");
        }
        Console.WriteLine();
    }
}
Solution(FirstArray, SecondArray, ThirdArray);