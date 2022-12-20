Console.WriteLine("Задайте размер массива.");
loop1:
Console.Write("\nРазмер по вертикали число больше 0: ");
int namder_y = Convert.ToInt32(Console.ReadLine());
Console.Write("\nРазмер по горизонтали число больше 0: ");
int namder_x = Convert.ToInt32(Console.ReadLine());
Random random = new Random();

if (namder_y > 0 && namder_x > 0)
{
    double[,] TwoArray = new double[namder_y, namder_x];
    Console.WriteLine();
    for (int i = 0; i < TwoArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
        {

            TwoArray[i, j] = random.NextDouble() * (55.34 + 55.34) - 55.34;  // RandomObj.NextDouble() * (end - begin) + begin

        }

    }

    for (int i = 0; i < TwoArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
        {

            Console.Write(Math.Round(TwoArray[i, j], random.Next(1, 5)) + "\t");
        }
        Console.WriteLine();
    }
}

else
{   
    Console.WriteLine();
    Console.WriteLine("\nДопускается  ввод числа больше 0.");
    goto loop1;
}