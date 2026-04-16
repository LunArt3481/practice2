Random RNG = new Random();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Задание 1");
Console.ForegroundColor = ConsoleColor.White;

int[] massive = {37, 0, 50, 46, 34, 46, 0, 13};

foreach (int i in massive)
{
    Console.Write($"[{i}] ");
}

Console.WriteLine("\n");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Задание 2");
Console.ForegroundColor = ConsoleColor.White;

int count = 1;

double[] massive2 = new double[20];
for (int i = 0; i < massive2.Length; i++, count++)
{
    massive2[i] = RNG.Next(-50,151);
    Console.Write($"{massive2[i]}  ");
    if (count == 5)
    {
        Console.WriteLine();
        count = 0;
    }
}
Console.WriteLine("\n");

Console.WriteLine("Все неотрицательные элементы: ");
foreach (int i in massive2)
{
    if (i > 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"[{i}] ");
        Console.ForegroundColor = ConsoleColor.White;
    }
}

Console.WriteLine("\n");

Console.WriteLine("Все отрицательные элементы: ");
foreach (int i in massive2)
{
    if (i < 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"[{i}] ");
        Console.ForegroundColor = ConsoleColor.White;
    }
}

Console.WriteLine("\n");

Console.WriteLine("Все элементы, не превышыющие 100: ");
foreach (int i in massive2)
{
    if (i <= 100)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"[{i}] ");
        Console.ForegroundColor = ConsoleColor.White;
    }
}

Console.WriteLine("\n");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Нажмите для завершения. . .");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();