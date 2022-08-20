// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] thirdDigitNumbersArray;
int length = 900; // последовательность чисел от 100 включительно до 999 включительно
thirdDigitNumbersArray = new int[length];
int sumTwo = 0;
int sumNotTwo = 0;
Random createArray = new Random();

for (int i = 0; i < length; i++)
{
    thirdDigitNumbersArray[i] = createArray.Next(100, (length + 1));
}
Console.WriteLine($"\nЧётные элементы массива указаны ниже:"); // добавление пустой строки для обрамления результата и удобства считывания последовательности чётных чисел (и нечётных в частности) в массиве
for (int i = 0; i < length; i++)
{
    if (thirdDigitNumbersArray[i] % 2 == 0)
    {
        Console.Write($"{thirdDigitNumbersArray[i],4}");
        sumTwo++;
    }
}
Console.WriteLine(); Console.WriteLine($"\nНечётные элементы массива указаны ниже:");
for (int i = 0; i < length; i++)
{
    if (thirdDigitNumbersArray[i] % 2 != 0)
    {
        Console.Write($"{thirdDigitNumbersArray[i],4}");
        sumNotTwo++;
    }
}
Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); // обрамление результатов алгоритма
Console.WriteLine($"Количество чётных чисел: {sumTwo}");
Console.WriteLine($"Количество нечётных чисел: {sumNotTwo}");