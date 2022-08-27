// В двумерном массиве n × k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j])

int[,] a;
a = init(5, 5);
Print(a);
Solution(a);
Console.WriteLine();
Print(a);

int[,] init(int N, int M)
{
    a = new int[N, M]; // создание массива

    // инициализация случайными числами
    Random random = new Random();

    for (int i = 0; i < a.GetLength(0); i++) // вместо for (int j = 0; j < M; j++)
    {
        for (int j = 0; j < a.GetLength(1); j++) // GetLength считает измерения массива
        {
            a[i, j] = random.Next(1, 10);
        }
    }
    return a;
}

void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            System.Console.Write($"{a[i, j],4} ");
        }
        System.Console.WriteLine();
    }
}

void Solution(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++) // GetLength считает измерения массива
        {
            if (a[i, j] % 2 == 0)
                a[i, j] = -a[i, j];
        }
        System.Console.WriteLine();
    }
}