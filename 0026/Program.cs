// Найти сумму чисел от 1 до А

Console.Write("Введите целое число больше 2 (например 8 или 145): "); // больше 2 для корректной работы методов
string? AString = Console.ReadLine();
int AConvert = Convert.ToInt32(AString);

void FillArray(int[] FirstArray)
{
    int FillLength = (Int32.MaxValue / 1000);
    int index;
    for (index = 0; index < FillLength; index++)
    {
        
        {
            
        }
        FirstArray[index] = new Random().Next(1, 2147483);
    }
}

void PrintArray(int[] FirstArray)
{
    int PrintLength = AConvert;
    int index;
    for (index = 0; index < PrintLength; index++)
    {
        Console.WriteLine(FirstArray[index]);
    }
}

void SortArray(int[] FirstArray)
{
    int SortLength = AConvert;
    int index = 0;
    FirstArray[index] = 1;
    FirstArray[(index + 1)] = (FirstArray[index] + 1);
    while (index < SortLength)
    {
        FirstArray[index] = FirstArray[(index + 1)];
        index++;
    }
}

int[] FirstArray = new int[AConvert];
/* int index = 0;
int count = 2; */

FillArray(FirstArray);
PrintArray(FirstArray);
SortArray(FirstArray);
