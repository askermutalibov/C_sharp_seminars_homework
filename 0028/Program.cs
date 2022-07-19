// Определить количество цифр в числе. Сделать подпрограмму.

int CountDigits (int N)
{
    int k = 0;
    if (N==0) return 1; // пограничный случай - если вводим 0 в конец алгоритма
    while (N!=0)
    {
        k++;
        N=N/10;
    }
    return k;
};
System.Console.WriteLine(CountDigits(142367));