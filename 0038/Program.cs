// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] arrOneTwoThree;
int length = 123; 
arrOneTwoThree = new int[length];
int countElements = 0;
Random arrOneTwoThreeCreate = new Random();

for (int i = 0; i < length; i++)
{
    arrOneTwoThree[i] = arrOneTwoThreeCreate.Next(1, (length + 1));
}

for (int i = 0; i < length; i++)
{
    if (arrOneTwoThree[i] >= 10 && arrOneTwoThree[i] <= 99)
    {
        countElements++;
    }
}
Console.WriteLine($"Количество элементов в массиве, лежащих в отрезке от 10 включительно до 99 включительно составляет {countElements}");