// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int N = 12;
int[] a = new int[N];
Random random = new Random();

for (int i = 0; i < a.Length; i++)
{
    a[i] = random.Next(-9, 10);
}

for (int i = 0; i < a.Length; i++)
{
    System.Console.Write($"{a[i],4}"); // выделяем 4 знакоместа (но можно это реализовать просто через пробелы)
}

Console.WriteLine(); Console.WriteLine();
int s = 0;
for (int i = 0; i < a.Length; i++)
{
    if ((i % 2) != 0)
        s = s + a[i];
}
System.Console.WriteLine($"сумма чисел массива, расположенных на нечётной позиции равна {s}");