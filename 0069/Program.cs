// Найти сумму элементов от M до N, N и M заданы - 1

Console.WriteLine("Введите число M: ");
string? mString = Console.ReadLine();
int M = int.Parse
(mString.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]);
Console.WriteLine("Введите число N: ");
string? nString = Console.ReadLine();
int N = int.Parse(nString.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]);
int[] array = new int[(N + 1)];
int length = ((N - M) + 1);
int sum = 0;

Console.Write($"\nПоследовательность чисел от {M} до {N} выглядит следующим образом:\n");

for (int i = 0; i < length; i++)
{
    array[i] = M;
    sum = M + sum;
    M = M + 1;
    Console.Write($"{array[i], 4}");
}
Console.WriteLine(); Console.WriteLine($"\nСумма чисел в этой последовательности равна {sum}\n");



/* Исходное рекуррентное соотношение: 

int s (m, n) = M, если M = N; (например 5, 5)
s (m, n) = s(M + 1, N) + M, если M < N;

s(8, 10) = s(9, 10) + M // s(8, 10) = 19 + 8 = 27
s(9,10) = s(10,10) + M // s(9, 10) = 10 + 9 = 19
S(10,10) = 10

*/