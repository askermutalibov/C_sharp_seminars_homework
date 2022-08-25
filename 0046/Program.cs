// С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1

Console.Write("Введите положительное целое число для вывода чисел Фибоначчи от 0 до указанного вами числа: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(); // новая строка для выделенного отображения результатов

double[] fibonacciArray = new double[length]; // массив из вещественных чисел для работы с большими и огромными целыми числами, которые не могут быть обработаны типом integer

void FillArrayFibonacciNumbers(double[] fibonacci) // массив, наполняющий элементы массива числами по формуле (числа от 0 до 2 включительно заполнены исключениями)
{
    for (int i = 3; i < fibonacci.Length; i++)
    {
        fibonacciArray[0] = 0;
        fibonacciArray[1] = 1;
        fibonacciArray[2] = 1;
        fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];
        // Console.WriteLine($"{i + 1} число Фибоначчи равняется {fibonacciArray[i]}");
    }
}

void PrintFibonacciFromOneToNumber(double[] printFibonacci) // вывод элементов массива на экран (выводится именно последовательность)
{
    Console.Write($"Последовательность первых {length} чисел Фибоначчи равна: ");
    Console.WriteLine();
    for (int i = 0; i < printFibonacci.Length; i++)
    {
        if (i >= 0 && i <= 11)
        {
            Console.Write($"{fibonacciArray[i],4}"); // разделение на несколько циклов if > then > else добавлено для расставления нужного количества пробелов между элементами последовательности разной величины и длины по пикселям экрана
        }
        if (i >= 12 && i <= 16)
        {
            Console.Write($"{fibonacciArray[i],5}");
        }
        if (i >= 17 && i <= 20)
        {
            Console.Write($"{fibonacciArray[i],6}");
        }
        if (i >= 21 && i <= 24)
        {
            Console.Write($"{fibonacciArray[i],8}");
        }
        if (i >= 25 && i <= 30)
        {
            Console.Write($"{fibonacciArray[i],9}");
        }
        if (i >= 31 && i <= 52)
        {
            Console.Write($"{fibonacciArray[i],14}");
        }
        if (i >= 53)
        {
            Console.Write($"{fibonacciArray[i],17}");
        }
    }
}

FillArrayFibonacciNumbers(fibonacciArray);

if (length == 0) Console.WriteLine("Введите число больше 0"); // исключения для первых 3 элементов 0 1 и 1
if (length == 1) Console.WriteLine($"Первое число из последовательности чисел Фибоначчи равно {0}");
else if (length == 2) Console.WriteLine($"Последовательность первых 2 чисел Фибоначчи равна  0  1  ");
else if (length == 3)
{
    Console.Write($"Последовательность первых 3 чисел Фибоначчи равна ");
    Console.Write(" 0  1  1 ");
}

else if (length >= 3)
{
    PrintFibonacciFromOneToNumber(fibonacciArray);
    Console.WriteLine();
}