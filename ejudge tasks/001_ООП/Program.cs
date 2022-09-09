// Вводятся координаты 2 точек - x1, y1 и x2, y2. Нужно написать подпрограмму Distance, которая находит расстояние между точками.

/* Процедурный подход решения задачи

double Distance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)); // c = sqrt(a^2 + b^2);
}

double x1 = 0, y1 = 0, x2 = 4, y2 = 6;
double distanceLaunch = Distance(x1, y1, x2, y2);
Console.WriteLine(distanceLaunch);
*/

/* Реализуем через ООП */
class Program // экземпляр класса
{
    struct Point // создаём сущность с помощью создания структуры. Структура должна быть частью класса.
    {
        public double x, y; // // не совсем верная реализация инкапсуляции, поскольку изначально переменные должны быть типа private. (он делает их защищёнными, но в отличие от типа protected, наследники этого объекта не смогут к нему обращаться при обозначении private)
        static public double DistanceByPoints(Point A, Point B) // добавили в описанию метода public, чтобы получить к нему доступ после слияния этого метода со структурой Point
        {
            return Math.Sqrt(Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y,
            2)); // такая запись с использованием сущностей упрощает работу с переменными и в целом с программой
        }
    }
    static void Main()
    {
        /* Program program = new Program();
        program. */ // обращаться к объекту (double методу) DistanceByPoints через новую программу необязательно, поскольку мы объявили метод DistanceByPoints статическим (static double)
        Point A, B;
        A.x = 2;
        A.y = 3;
        B.x = 5;
        B.y = 8;
        double distanceLaunch2nd = Point.DistanceByPoints(A, B); // Добавляем Point перед вызовом метода, поскольку переместили метод в структуру Point
        Console.WriteLine($"\nДистанция между точками A({A.x}, {A.y}) и B({B.x}, {B.y}) равна {distanceLaunch2nd}\n");
    }
}