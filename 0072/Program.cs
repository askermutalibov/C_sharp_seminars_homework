// Написать программу возведения числа A в целую степень B

// 1-я версия: метод стандартного возведения в степень

void GrowNumberToDegrees(double a, double b)
{
    if (b == 0) Console.WriteLine(1);
    else if (b > 0) Console.WriteLine($"\nРезультат возведения числа {a} в {b} степень (по 1-й версии алгоритма) равен {(Math.Pow(a, (b - 1)) * a)}\n");
    else if (b < 0) Console.WriteLine($"\nРезультат возведения числа {a} в {b} степень (по 1-й версии алгоритма) равен {(Math.Pow(a, (b - 1)) * a)} или же 1 / {a}^{-b}\n");
}
double aAfterDegree = 2;
double bAfterDegree = -4;
GrowNumberToDegrees(aAfterDegree, bAfterDegree);

// 2-я версия: метод "ускоренного" возведения в степень

double RapidGrowNumberToDegrees(double aRapid, double bRapid) // этот метод переделать, он выводит какую-то ерунду: "Результат возведения числа 2 в 2 степень равен:" с проставлением пустых строк
{
    if (bRapid == 0) return 1;
    else if (bRapid % 2 != 0) return RapidGrowNumberToDegrees(aRapid, bRapid - 1) * aRapid;
    else if (bRapid < 0) return (Math.Pow(aRapid, (bRapid - 1)) * aRapid); //или же 1 / {a}^{-b}\n
    else return RapidGrowNumberToDegrees(aRapid, bRapid / 2) * RapidGrowNumberToDegrees(aRapid, bRapid / 2);
}
double aRapidAfterDegree = 2;
double bRapidAfterDegree = -3;
Console.Write($"\nРезультат возведения числа {aRapidAfterDegree} в {bRapidAfterDegree} степень (по 2-й версии алгоритма) равен ");
Console.Write(RapidGrowNumberToDegrees(aRapidAfterDegree, bRapidAfterDegree));