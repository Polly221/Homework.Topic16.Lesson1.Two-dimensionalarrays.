//1
double[,] mas = new double[3, 3];
Random random = new Random(); for (int i = 0; i < mas.GetUpperBound(0) + 1; i++)
{
    for (int j = 0; j < mas.GetUpperBound(1) + 1; j++)
    {
        mas[i, j] = random.NextDouble() * 20;
        Console.Write($"{mas[i, j]:F1} ");
    }
    Console.WriteLine();
}
Console.Write("Введите индекс строки:");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите индекс столбца:");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число:");
int k = int.Parse(Console.ReadLine());
mas[n - 1, m - 1] = k; for (int i = 0; i < mas.GetUpperBound(0) + 1; i++)
{
    for (int j = 0; j < mas.GetUpperBound(1) + 1; j++)
    {
        Console.Write($"{mas[i, j]:F1} ");
    }
    Console.WriteLine();
}
//2
char[,] mas2 = new char[5, 2];
for (int i = 0; i < mas2.GetUpperBound(0) + 1; i++)
{
    for (int j = 0; j < mas2.GetUpperBound(1) + 1; j++)
    {
        mas2[i, j] = char.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < mas2.GetUpperBound(0) + 1; i++)
{
    for (int j = 0; j < mas2.GetUpperBound(1) + 1; j++)
    {
        Console.Write(mas2[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("" + mas2[0, 0] + mas2[0, 1] + mas2[1, 0] + mas2[2, 0] + mas2[2, 1] + mas2[3, 0]);