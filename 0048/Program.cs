// Написать программу копирования массива

int[] a;
init(out a, 15, -Int16.MaxValue, Int16.MaxValue);
print(a);
int[] b = a;
b = (int[])a.Clone();

void clone(int[] a, out int[] b)
{
    b = new int[a.Length];
    for (int i = 0; i < a.Length; i++)
    {
        b[i] = a[i];
    }
}

clone(a, out b);

System.Console.WriteLine();

print(b);

void init(out int[] t, int length, int min, int max)
{
    t = new int[length];
    Random random = new Random();
    for (int i = 0; i < t.Length; i++)
    {
        t[i] = random.Next(min, max + 1);
    }
}

void print(int[] t)
{
    for (int i = 0; i < t.Length; i++)
    {
        Console.Write($" {t[i]} ");
    }
}