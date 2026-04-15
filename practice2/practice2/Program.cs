Random RNG = new Random();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("15 чисел в диапозоне от 0.0 до 1.0");
Console.ForegroundColor = ConsoleColor.White;

int count = 1;

double[] dec = new double[15];
for (int i = 0; i < dec.Length; i++, count++)
{
    dec[i] = RNG.NextDouble();
    Console.Write($"{dec[i]:F4}  ");
    if (count == 5)
    {
        Console.WriteLine();
        count = 0;
    }
}

count = 1;

int[] massive  = new int[20];

Console.WriteLine("\n\nmassive");
for (int i = 0; i < massive.Length; i++, count++)
{
    massive[i] = RNG.Next(1,500);
    Console.Write($"{massive[i]}  ");
    if (count == 5)
    {
        Console.WriteLine();
        count = 0;
    }
}

Console.WriteLine("\nВсе двузначные элементы: ");

for (int i = 0;i < massive.Length; i++)
{
    int a = massive[i] / 10;
    if (a >= 1 && a < 10)
    {
        Console.Write($"{massive[i]}  ");
    }
}

Console.WriteLine("\n\nВсе трёхзначные элементы: ");