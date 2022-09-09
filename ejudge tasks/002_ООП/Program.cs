// Описать структуру дробей - рациональных чисел, которые являются отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы структуры.
class Program
{
    struct Fraction
    {
        private int numerator, denumerator; // (числитель и знаменатель)
        public Fraction(int numerator, int denumerator) // создали конструктор
        {
            if (denumerator == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен нулю");
            }
            this.numerator = numerator;
            this.denumerator = denumerator;
        }
        public static Fraction Plus(Fraction a, Fraction b) // объект (метод), описывающий как производится сложение дробей целых чисел
        {
            Fraction c = new Fraction(a.numerator * b.denumerator + b.numerator * a.denumerator, a.numerator * b.denumerator);
            return c;
        }
        public static Fraction Minus(Fraction a, Fraction b) // объект (метод), описывающий как производится вычитание дробей целых чисел
        {
            Fraction c = new Fraction(a.numerator * b.denumerator - b.numerator * a.denumerator, a.numerator * b.denumerator);
            return c;
        }
        public static Fraction Multiplie(Fraction a, Fraction b) // объект (метод), описывающий как производится умножение дробей целых чисел
        {
            Fraction c = new Fraction(a.numerator * b.numerator, a.denumerator * b.denumerator);
            return c;
        }
        public static Fraction Divide(Fraction a, Fraction b) // объект (метод), описывающий как производится деление дробей целых чисел
        {
            Fraction c = new Fraction(a.numerator * b.denumerator, a.denumerator * b.numerator);
            return c;
        }
        public void Print()
        {
            Console.WriteLine($"{numerator}/{denumerator}");
        }
    }
    static void Main()
    {
        Fraction a = new Fraction(1, 2);
        Fraction b = new Fraction(1, 3);
        Fraction c = Fraction.Plus(a, b);
        c.Print();
        c = Fraction.Minus(a, b);
        c.Print();
        c = Fraction.Multiplie(a, b);
        c.Print();
        c = Fraction.Divide(a, b);
        c.Print();
    }
    /*
    try
    {
        Fraction fraction = new Fraction(1, 0);
    }
    catch
    {
        throw new ArgumentException($"\nЗнаменатель не может быть равен 0");
    } // блок try - catch это дублирование исключения в методе public Fraction в ветви if (denumerator == 0)
    */
    //     Fraction Fraction = new Fraction(1, 5);
}