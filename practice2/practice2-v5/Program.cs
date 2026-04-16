Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Задание 1");
Console.ForegroundColor = ConsoleColor.White;

Random RNG = new Random();
int count = 1;
int a = 0;
int b = 0;
int n = 0;

Console.Write("Введите НИЖНЮЮ границу диапозона: ");
while (true)
{
    try { a = Convert.ToInt32(Console.ReadLine()); break; }
    catch { Console.Write("Ошибка ввода. Повторите попытку: "); }
}

Console.Write("Введите ВЕРХНЮЮ границу диапозона: ");
while (true)
{
    try { b = Convert.ToInt32(Console.ReadLine()); break; }
    catch { Console.Write("Ошибка ввода. Повторите попытку: "); }
}

Console.Write("Введите количество элементов массива: ");
while (true)
{
    try { n = Convert.ToInt32(Console.ReadLine()); break; }
    catch { Console.Write("Ошибка ввода. Повторите попытку: "); }
}

Console.WriteLine("");

double[] massive = new double[n];

for (int i = 0; i < massive.Length; i++, count++)
{
    massive[i] = RNG.Next(a,b+1);
    Console.Write($"[{massive[i]}]  ");
    if (count == 5)
    {
        Console.WriteLine();
        count = 0;
    }
}

Console.WriteLine("");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Задание 2");
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Неотрицательные элементы: ");

count = 0;

foreach (int i in massive)
{
    if (i >= 0)
    {
        Console.Write($"[{i}] ");
        count++;
    }
}
if (count == 0)
{
    Console.WriteLine("Таких нет. ");
}

Console.WriteLine("");

count = 0;

Console.WriteLine("\nОтрицательные элементы: ");
foreach (int i in massive)
{
    if (i < 0)
    {
        Console.Write($"[{i}] ");
        count++;
    }
}
if (count == 0)
{
    Console.WriteLine("Таких нет. ");
}

Console.WriteLine("\n");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Нажмите для завершения. . .");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();