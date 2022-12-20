Console.WriteLine($"Введите первый индекс позиции от 0 до 3:");
int numder_y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите второй индекс позиции от 0 до 4:");
int numder_x = Convert.ToInt32(Console.ReadLine());
Random random = new Random();
int[,] TwoArray = new int[4, 5];

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

if (numder_y >= 0 && numder_y < TwoArray.GetLength(0)
&& numder_x >= 0 && numder_x < TwoArray.GetLength(1))
{
    Console.WriteLine($"Число под идексом {numder_y}, {numder_x} это {TwoArray[numder_y, numder_x]}");

}
else
{
    Console.WriteLine($"элемент под данным индексом отсутствует");

}