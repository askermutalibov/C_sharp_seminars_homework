// Определить, присутствует ли в заданном массиве некоторое число

int N = 12;
int[] a = new int [N];
Random random = new Random();

for (int i = 0; i < a.Length; i++)
{
    a[i] = random.Next(-9, 10);
}

int f = 400;
a[3] = f;
int j = 0; // линейный поиск
while (j < a.Length && a[j] != f)
{
    j++;
}

for (int i = 0; i < a.Length; i++)
{
    System.Console.Write($"{a[i],4}"); // выделяем 4 знакоместа (но можно это реализовать просто через пробелы)
}

if (j == a.Length)
{
System.Console.WriteLine("Not Found");
}
else System.Console.WriteLine($"\nЭлемент {f} найден на позиции {j} индекса массива"); // \n - new line, добавляет новую линию внутри сообщения