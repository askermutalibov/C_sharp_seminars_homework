/* С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры */

Console.WriteLine();
Console.Write("Введите целое положительное число: ");
int OneNumber = Convert.ToInt32(Console.ReadLine()); // не удалось реализовать через дополнительный метод int{}


Console.WriteLine($"Введите ещё {OneNumber} целых и положительных или целых и отрицательных чисел в строке ниже (например 7 или -24");
int[] readThisIntArray = new int[OneNumber];
int sumPositiveNumbers = 0;

void FillArrayWithUserSupport(int[] filledArr)
{
    for (int i = 0; i < OneNumber; i++)
    {
        Console.Write("Введите ещё одно число: ");
        int ConvertNextElement = Convert.ToInt32(Console.ReadLine());
        filledArr[i] = ConvertNextElement;
    }
}
FillArrayWithUserSupport(readThisIntArray);

void PrintArrayWithUserIntegers(int[] printedArr, int count = 0)
{
    int zero = 0;
    for (int j = 0; j < OneNumber; j++)
    {
        Console.Write($"{printedArr[j],6}");
        if (printedArr[j] > 0)
        {
            count = count + 1;
        }
        if (printedArr[j] == 0) zero = zero + 1; 
    }
    Console.WriteLine(); Console.WriteLine($"С клавиатуры введено {count} положительных чисел (число) и {zero} нулей (нуль)");
}

Console.Write("Последовательность введённых вами чисел выглядит следующим образом:");
PrintArrayWithUserIntegers(readThisIntArray, sumPositiveNumbers);

System.Console.WriteLine();