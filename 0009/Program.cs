// Вывод на экран всех чётных чисел от 1 до N

int i = 1; // можно через int = 2 
int N = 20;
while (i<=N)
{
    if (i%2==0)
    {
        System.Console.Write($"{i} ");
    }
    i++;
}
