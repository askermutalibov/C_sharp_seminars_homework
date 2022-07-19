// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y!
// (X || Y)==!X && !Y

int n = 5;
System.Console.WriteLine($"n = {n}");
bool x, y, f1, f2;
x = true;
y = true;
f1 = !(x || y);
f2 = !x && !y;
System.Console.WriteLine($"{x} {y} {f1} {f2}");