// Показать двумерный массив размером m×n заполненный вещественными случайными числами

int N = 32;
int M = 32;
double[,] a;
a = new double[N, M]; // создание массива

// инициализация случайными числами
Random random = new Random();

for (int i = 0; i < a.GetLength(0); i++) // вместо for (int j = 0; j < M; j++)
{
    for (int j = 0; j < a.GetLength(1); j++) // GetLength считает измерения массива
    {
        a[i, j] = random.NextDouble() * 100+2; // "+2 - смещение запятой на 2 знака - будут выводиться числа от 1 до 100"
    }
}
// вывод массива на экран

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++) // GetLength считает измерения массива
    {
        System.Console.Write($"{a[i, j]:F2}  "); // F2 - оставить 2 знака после запятой
    }
    System.Console.WriteLine();
}