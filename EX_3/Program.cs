Console.WriteLine("Задайте размер массива.");
loop1:
Console.Write("\nРазмер по вертикали число больше 0: ");
int namder_y = Convert.ToInt32(Console.ReadLine());
Console.Write("\nРазмер по горизонтали число больше 0: ");
int namder_x = Convert.ToInt32(Console.ReadLine());
Random random = new Random();

if (namder_y > 0 && namder_x > 0)
{
    int[,] TwoArray = new int[namder_y, namder_x];
    System.Console.WriteLine("Вывожу массив");
    for (int i = 0; i < TwoArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
        {

            TwoArray[i, j] = random.Next(-10, 11);
        }
    }

    for (int i = 0; i < TwoArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
        {

            Console.Write(TwoArray[i, j] + "\t");
        }
        Console.WriteLine();
    }

    Console.Write("Cреднее арифметическое элементов в каждом столбце");
    Console.WriteLine();
    for (int i = 0; i < TwoArray.GetLength(1); i++)
    {
        double arithmetic = 0;
        for (int j = 0; j < TwoArray.GetLength(0); j++)
        {
            arithmetic = arithmetic + TwoArray[j, i];
        }
        Console.Write(+arithmetic / TwoArray.GetLength(0) + "\t");
    }
}
else
{
    Console.WriteLine();
    Console.WriteLine("\nДопускается  ввод числа больше 0.");
    goto loop1;
}