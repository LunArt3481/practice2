string[] massive = new string[20];
int count = 1;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Задание 1");
Console.ForegroundColor = ConsoleColor.White;


for (int i = 0; i < massive.Length; i++) 
{
    massive[i] = "#";
}

foreach (string s in massive)
{
    Console.Write($"{s} ");
    count++;
    if (count == 6)
    {
        Console.WriteLine();
        count = 1;
    }
}
count = 1;

Console.WriteLine("");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Задание 2");
Console.ForegroundColor = ConsoleColor.White;

int[] massive2 = new int[20];
int nums = 1;

for (int i = 0;i < massive2.Length; i++, nums++, count++)
{
    massive2[i] = nums;
    Console.Write($"[{massive2[i],2}] ");

    if (count == 5)
    {
        Console.WriteLine();
        count = 0;
    }
}

Console.WriteLine("\nЭлементы, кратные двум: ");

foreach(int n in massive2)
{
    if(n%2 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"{n} ");
        Console.ForegroundColor = ConsoleColor.White;
    }
}

Console.WriteLine("\n\nЭлементы, кратные трём: ");

foreach (int n in massive2)
{
    if (n % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{n} ");
        Console.ForegroundColor = ConsoleColor.White;
    }
}

Console.WriteLine("\n");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Нажмите для завершения. . .");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();