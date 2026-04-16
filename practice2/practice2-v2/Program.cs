Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Задание 1");
Console.ForegroundColor = ConsoleColor.White;

double[] massive = new double[10];
Random RNG = new Random();

Console.WriteLine("Вводите значения: ");

for (int i = 0; i < massive.Length; ++i)
{
num:
    try
    {
        massive[i] = Convert.ToDouble(Console.ReadLine());
    }
    catch
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ошибка ввода. Нажмите для продолжения. . .");
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadKey();
        goto num;
    }
}

Console.Clear();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Задание 1");
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Введенный массив: ");

for (int i = 0; i < massive.Length; ++i)
{
    Console.Write($"{massive[i]}  ");
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\n\nЗадание 2");
Console.ForegroundColor = ConsoleColor.White;

int count = 1;
double[] zero = new double[25];
double[] ch = new double[25];

double[] dec = new double[25];
for (int i = 0; i < dec.Length; i++, count++)
{
    dec[i] = RNG.Next(-100,100);
    Console.Write($"[{dec[i],4}]  ");
    if (count == 5)
    {
        Console.WriteLine();
        count = 0;
    }
    if (dec[i]%10 == 0)
    {
        zero[i] = dec[i];
    }
    if (dec[i]%2 == 0)
    {
        ch[i] = dec[i];
    }
}

count = 0;
Console.WriteLine("\nЧетные числа: ");

for (int i = 0; i < ch.Length; i++)
{
    if (ch[i] != 0)
    {
        Console.Write($"{ch[i]}  ");
        count++;
    }
}
if (count == 0)
{
    Console.WriteLine("Таких нет");
}

Console.WriteLine("");

count = 0;
Console.WriteLine("\nЧисла, оканчивающиеся на ноль: ");

for (int i = 0; i < zero.Length; i++)
{
    if (zero[i] != 0)
    {
        Console.Write($"{zero[i]}  ");
        count++;
    }
}
if (count == 0)
{
    Console.WriteLine("Таких нет");
}

Console.WriteLine("\n");


Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Нажмите для завершения. . .");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();