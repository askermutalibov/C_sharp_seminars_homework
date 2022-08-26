// Показать двумерный массив размером m x n заполненный целыми случайными числами

int N = 128;
int M = 32;
int[,] a;
a = new int[N, M]; // создание массива

// инициализация случайными числами
Random random = new Random();

for (int i = 0; i < a.GetLength(0); i++) // вместо for (int j = 0; j < M; j++)
{
    for (int j = 0; j < a.GetLength(1); j++) // GetLength считает измерения массива
    {
        a[i, j] = random.Next(1, 96);
    }
}

// вывод массива на экран

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++) // GetLength считает измерения массива
    {
        System.Console.Write($"{a[i, j], 0}  ");
    }
    System.Console.WriteLine();
}