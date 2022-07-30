// Найти расстояние между точками в пространстве 2D.

Console.Clear();

int FirstPointX = 6, FirstPointY = 5,
    SecondPointX = 14, SecondPointY = 7,
    ThirdPointX = 8, ThirdPointY = 3,
    FourthPointX = 11, FourthPointY = 10;

Console.SetCursorPosition(FirstPointX, FirstPointY);
Console.WriteLine("+");

Console.SetCursorPosition(SecondPointX, SecondPointY);
Console.WriteLine("+");

Console.SetCursorPosition(ThirdPointX, ThirdPointY);
Console.WriteLine("+");

Console.SetCursorPosition(FourthPointX, FourthPointY);
Console.WriteLine("+");

int FirstDistanceBetweenPoints = FirstPointX, SecondDistanceBetweenPoints = SecondPointX,
    DistanceBetweenPoints;

int count = 0;
while (count < 10)
{
    int points = new Random().Next(0, 3); // [0,3) 0 1 2
    if (points == 0)
    {
    FirstDistanceBetweenPoints = (FirstDistanceBetweenPoints + SecondPointX) / 1;
    SecondDistanceBetweenPoints = (SecondDistanceBetweenPoints + SecondPointY) / 1;
    DistanceBetweenPoints = (SecondDistanceBetweenPoints - FirstDistanceBetweenPoints);
    System.Console.WriteLine($"Расстояние между первой и второй точками составляет {DistanceBetweenPoints} пикселей");
    }
    if (points == 1)
    {
    FirstDistanceBetweenPoints = (FirstDistanceBetweenPoints + ThirdPointX) / 1;
    SecondDistanceBetweenPoints = (SecondDistanceBetweenPoints + ThirdPointY) / 1;
    DistanceBetweenPoints = (SecondDistanceBetweenPoints - FirstDistanceBetweenPoints);
    System.Console.WriteLine($"Расстояние между первой и третьей точками составляет {DistanceBetweenPoints} пикселей");
    }
    if (points == 2)
    {
    FirstDistanceBetweenPoints = (FirstDistanceBetweenPoints + FourthPointX) / 1;
    SecondDistanceBetweenPoints = (SecondDistanceBetweenPoints + FourthPointY) / 1;
    DistanceBetweenPoints = (SecondDistanceBetweenPoints - FirstDistanceBetweenPoints);
    System.Console.WriteLine($"Расстояние между первой и четвёртой точками составляет {DistanceBetweenPoints} пикселей");
    }
    if (points >= 2)
    break;
} count++;

// ThirdDistanceBetweenPoints = SecondPointX, FourthDistanceBetweenPoints = ThirdPointX,
// FifthDistanceBetweenPoints = FourthPointX,