// Вывести на экран числа от 1 до N (N задано) без использования циклов 


void Loop(int i, int N)
{
    Console.Write($"{i, 5}");
    if (i < N)
    {
        Loop(i + 1, N);
    }
}

Loop(1, 10);