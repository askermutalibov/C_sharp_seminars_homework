// Найти сумму чисел от 1 до А. 

Console.Write("Введите число, которое будет выполнять роль верхней границы последовательности чисел, для которой нужно вывести на экран их сумму: ");
string? Astring = Console.ReadLine();
int A = Convert.ToInt32(Astring);
int i;
int sum = 0;
for (i = 1; i <= A; i++)
{
    sum = sum + i;
}
System.Console.WriteLine($"Сумма чисел от 1 до {A} равна {sum}");

/*

Console.Write("Введите целое число больше 2 (например 8 или 145): "); // больше 2 для корректной работы методов
string? AString = Console.ReadLine();
int AConvert = Convert.ToInt32(AString); // эта версия алгоритма пока не работает, уточню у однокурсников рабочий алгоритм

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
*/
/*
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
*/
/*

int[] FirstArray = new int[AConvert];

/* int index = 0;
int count = 2; */

/*
FillArray(FirstArray);
PrintArray(FirstArray);
SortArray(FirstArray);
*/