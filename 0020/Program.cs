// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.Write("Введите абсциссу точки A [например: 4]: ");
string? Xaxis = Console.ReadLine();
double CountXaxis = Convert.ToDouble(Xaxis);

Console.Write("Введите ординату точки A [например: -7]: ");
string? Yaxis = Console.ReadLine();
double СountYaxis = Convert.ToDouble(Yaxis);

if (CountXaxis == 0 | СountYaxis == 0)
{
    Console.Write("Введите числа, отличные от нуля");
}

if (CountXaxis > 0 & СountYaxis > 0)
{
    Console.WriteLine("Точка А находится в первой четверти оси координат");
}
else
{
    if (CountXaxis < 0 & СountYaxis < 0)
    {
        Console.WriteLine("Точка А находится в третьей четверти оси координат");
    }
    if (CountXaxis > 0 & СountYaxis < 0)
    {
        Console.WriteLine("Точка А находится в четвёртой четверти оси координат");
    }
    if (CountXaxis < 0 & СountYaxis > 0)
    {
        Console.WriteLine("Точка А находится во второй четверти оси координат");
    }
} // немного топорный метод, но надеюсь, что для этой задачи приемлемый